using System.Text.RegularExpressions;
using CinemaCentral.Models;
using CinemaCentral.Providers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CinemaCentral.Controllers;

[ApiController]
[Route("api/[controller]")]
public partial class SeriesController
{
    private readonly AppDbContext _appDbContext;
    private readonly TmdbProvider _tmdbProvider = new();
    
    [GeneratedRegex(@"([\w,': ]+) - S(\d{2})E(\d{2}) - ([\w,': ]+)")]
    private static partial Regex DecodeEpisodePathRegex();

    public SeriesController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    
    [HttpGet]
    public async Task<List<Series>> All()
    {
        return await _appDbContext.Series.ToListAsync();
    }

    [HttpPost("Update")]
    public async Task Update()
    {
        await _appDbContext.Database.ExecuteSqlRawAsync("DELETE FROM Series");
        await _appDbContext.Database.ExecuteSqlRawAsync("DELETE FROM Episodes");

        var files = Directory.EnumerateFiles("Libraries/Series", "*", SearchOption.AllDirectories);
        foreach (var file in files)
        {
            var episodeDetails = DecodeEpisodePath(file);
            if (episodeDetails.Title is null)
                continue;

            var series = await _appDbContext.Series.Include(s => s.Episodes).Where(e => e.Title == episodeDetails.Title).FirstOrDefaultAsync();
            if (series is null)
            {
                series = await _tmdbProvider.FindSeries(episodeDetails.Title);
                if (series is null)
                    continue;
                series.Episodes = new List<Episode>();
                
                _appDbContext.Series.Add(series);
            }

            var episode =
                await _tmdbProvider.FindEpisode(series.TmdbId, episodeDetails.Season, episodeDetails.Episode);
            if (episode is null)
                continue;
            
            series.Episodes.Add(episode);
            await _appDbContext.SaveChangesAsync();
        }
    }

    [HttpGet("{id:Guid}")]
    public async Task<Series?> Get([FromRoute] Guid id)
    {
        var series = await _appDbContext.Series.Include(s => s.Episodes).FirstOrDefaultAsync(s => s.Id == id);
        series?.Episodes?.ForEach(e => e.Series = null);
        return series;
    }
    
    private static (string? Title, int Season, int Episode) DecodeEpisodePath(string path)
    {
        var match = DecodeEpisodePathRegex().Match(path);
        if (!match.Success)
            return (null, 0, 0);

        var title = match.Groups[1].Value;
        var season = int.Parse(match.Groups[2].Value);
        var episode = int.Parse(match.Groups[3].Value);
        return (title, season, episode);
    }
}
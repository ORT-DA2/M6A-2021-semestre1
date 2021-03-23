using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HolaMundo.Api.Controllers
{
  [ApiController]
  [Route("api/songs")]
  public class SongController : ControllerBase
  {
    private static List<Song> Playlist = new List<Song>
    {
        new Song(){
            Name = "Heat Waves",
            Artist = "Glass Animals",
            Date = new DateTime()
        },
        new Song(){
            Name = "We're Good",
            Artist = "Dua Lipa",
            Date = new DateTime()
        },
        new Song(){
            Name = "What's Next",
            Artist = "Drake",
            Date = new DateTime()
        },
        new Song(){
            Name = "Save Your Tears",
            Artist = "The Weeknd",
            Date = new DateTime()
        }
    };

    private readonly ILogger<SongController> _logger;

    public SongController(ILogger<SongController> logger)
    {
      _logger = logger;
    }

    // GetAllExample
    // [HttpGet]
    // public List<Song> GetAll()
    // {
    //   return Playlist;
    // }

    [HttpGet("{id:int}")]
    public IActionResult GetSpecificSong(int id)
    {
      return Ok(Playlist[id]);
    }

    [HttpGet]
    public IActionResult GetAll([FromQuery] string name)
    {

      if (name != null)
      {
        Song lookedSong = Playlist.Find(s => s.Name.ToLower() == name.ToLower());
        return Ok(lookedSong);
      }
      return Ok(Playlist);
    }

    [HttpPost]
    public IActionResult CreateSong([FromBody] Song song)
    {
      Playlist.Append(song);
      return Created("api/touristPoints/" + Playlist.Count(), song);
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteSong(int id)
    {
      Playlist.RemoveAt(id);
      return Ok("Element removed");
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateSong([FromBody] Song song, int id)
    {
      Playlist[id] = song;
      return Ok("Element Updated");
    }
  }
}

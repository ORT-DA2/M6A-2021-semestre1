using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BusinessLogic;
using Domain;

namespace SpotifyCloneAPI.Controllers
{
  [ApiController]
  [Route("api/songs")]
  public class SongController : ControllerBase
  {

    private readonly SongBusinessLogic businessLogic;

    public SongController()
    {
      this.businessLogic = new SongBusinessLogic();
    }

    [HttpGet]
    public IActionResult GetAll([FromQuery] string name)
    {
      IEnumerable<Song> songs = this.businessLogic.GetAll(name);
      return Ok(songs);
    }

    [HttpPost]
    public IActionResult CreateSong([FromBody] Song song)
    {
      Song newSong = this.businessLogic.CreateSong(song);
      return Created("api/songs", newSong);
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteSong(int id)
    {
      this.businessLogic.DeleteSong(id);
      return Ok("Element removed");
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateSong([FromBody] Song song, int id)
    {
      this.businessLogic.UpdateSong(id, song);
      return Ok("Element Updated");
    }
  }
}

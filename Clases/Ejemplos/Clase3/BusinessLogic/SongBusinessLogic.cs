using System;
using Domain;
using DataAccess;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
  public class SongBusinessLogic
  {
    private readonly SongRepository dataAccess;

    public SongBusinessLogic()
    {
      this.dataAccess = new SongRepository();
    }

    public IEnumerable<Song> GetAll(string name)
    {
      IEnumerable<Song> results = this.dataAccess.GetAll();
      if (name != null)
      {
        return results.Where(s => s.Name.ToLower() == name.ToLower());
      }

      return results;
    }

    public Song CreateSong(Song song)
    {

      return this.dataAccess.CreateSong(song);
    }

    public void DeleteSong(int id)
    {
      this.dataAccess.DeleteSong(id);
    }

    public void UpdateSong(int id, Song song)
    {
      this.dataAccess.UpdateSong(id, song);
    }

  }
}

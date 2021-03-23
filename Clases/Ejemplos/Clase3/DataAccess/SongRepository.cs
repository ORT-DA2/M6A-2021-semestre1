using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace DataAccess
{
  public class SongRepository
  {
    private List<Song> Playlist = new List<Song>
    {
        new Song(){
            Name = "Heat Waves",
            Artist = "Glass Animals",
        },
        new Song(){
            Name = "We're Good",
            Artist = "Dua Lipa",
        },
        new Song(){
            Name = "What's Next",
            Artist = "Drake",
        },
        new Song(){
            Name = "Save Your Tears",
            Artist = "The Weeknd",
        }
    };

    public IEnumerable<Song> GetAll()
    {
      return Playlist;
    }

    public Song CreateSong(Song song)
    {
      Playlist.Append(song);
      return song;
    }

    public void DeleteSong(int id)
    {
      Playlist.RemoveAt(id);
    }

    public void UpdateSong(int id, Song song)
    {
      Playlist[id] = song;
    }

  }
}

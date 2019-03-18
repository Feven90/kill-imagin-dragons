using System;
using System.Collections.Generic;
using System.Linq;

namespace KillImagineDragons
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Song> goodSongs = new List<Song>();
            var allSongs = new List<Song>();
            allSongs.Add(new Song("Imagine Dragons", "Whatever It Takes"));
            allSongs.Add(new Song("Imagine Dragons", "Bleeding Out"));
            allSongs.Add(new Song("Imagine Dragons", "Friction"));
            allSongs.Add(new Song("Imagine Dragons", "Friction"));
            allSongs.Add(new Song("Imagine Dragons", "Amsterdam"));
            allSongs.Add(new Song("Imagine Dragons", "Shots"));
            allSongs.Add(new Song("Imagine Dragons", "Believer"));
            allSongs.Add(new Song("Imagine Dragons", "Demons"));
            allSongs.Add(new Song("Imagine Dragons", "Walking The Wire"));
            allSongs.Add(new Song("Imagine Dragons", "Radioactive"));
            allSongs.Add(new Song("Imagine Dragons", "It’s Time"));
            allSongs.Add(new Song("Aster Abebe", "Mihret"));
            allSongs.Add(new Song("Aster Abebe", "Tebarek"));

            goodSongs = from song in allSongs
                        where song.Artist != "Imagine Dragons"
                        select song;
            foreach (var goodSong in goodSongs)
            {
                Console.WriteLine($"{goodSong.Artist}: { goodSong.Name}");
            }
            Console.ReadLine();
        }
    }
}

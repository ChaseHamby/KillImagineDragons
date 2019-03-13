using System;
using System.Collections.Generic;
using System.Linq;

namespace KillImagineDragons
{
    class Program
    {
        public class Song
        {
            public string Artist { get; }
            public string Name { get; }

            public Song(string name, string artist)
            {
                Name = name;
                Artist = artist;
            }

            static void Main(string[] args)
            {
                List<Song> goodSongs = new List<Song>()
                {
                };

                List<Song> allSongs = new List<Song>()
                {
                new Song ("Bleeding Out", "Imagine Dragons" ),
                new Song ("Whatever It Takes", "Imagine Dragons" ),
                new Song ("Lateralus", "Tool" ),
                new Song ("Head Like A Hole", "Nine Inch Nails" ),
                new Song ("Cicatriz ESP", "The Mars Volta" ),
                new Song ("The Only Thing", "Sufjan Stevens" ),
                new Song ("Pink Rabbits", "The National" ),
                new Song ("Firestarter", "The Prodigy" ),
                new Song ("Southbound Pachyderm", "Primus" ),
                new Song ("Uncle John's Band", "Grateful Dead" ),
                new Song ("Friction", "Imagine Dragons" ),
                new Song ("Radioactive", "Imagine Dragons" ),
                new Song ("It's Time", "Imagine Dragons" )
                };

                goodSongs = allSongs
                    .Where(song => song.Artist != "Imagine Dragons").ToList();

                foreach (var song in goodSongs)
                {
                    Console.WriteLine($"{song.Artist} : {song.Name}");
                }
                Console.ReadKey();
            }
        }
    }
}

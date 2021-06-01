using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {

        static void Main(string[] args) {

            var songs = new Song[] {
                new Song("アグレッシ部","KREVA",5),
            };
            PrintSongs(songs);
        }


        //2.1.4
        private static void PrintSongs(Song[] songs) {
            foreach (var song in songs) {
                Console.WriteLine(@"{0},{1},{2:m\:ss}",song.Title,song.ArtistName,TimeSpan.FromSeconds(song.Length));
                //Console.WriteLine(song.Title);
                //Console.WriteLine(song.ArtistName);
                //Console.WriteLine(song.Length);
            }
        }
    }
}

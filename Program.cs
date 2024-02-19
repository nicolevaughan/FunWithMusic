using System;
namespace FunWithMusic
{
    class Program
    {
        enum Genre
        {
            Grunge,
            Country,
            ClassicRock,
            Pop,
            Indie
        }
        struct Song
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;

            public Song(string title, string artist, string album, string length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }

            public void setTitle(string title)
            {
                Title=title;
            }
            public void setArtist(string artisit)
            {
                Artist=artisit;
            }
            public void setAlbum(string album)
            {
                Album=album;
            }
            public void setLength(string length)
            {
                Length=length;
            }
            public void setGenre(Genre genre)
            {
                Genre = genre;
            }

            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist + "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
            }

        }
        static void Main(string[] args) 
        {
            //Song song=new Song();

        
            Console.WriteLine("What is the title of your favorite song?");
            string tempTitle=Console.ReadLine();
            Console.WriteLine("What is name of the artist that performs the song?");
            string tempArtist=Console.ReadLine();
            Console.WriteLine("What is the name of the album that contains the song?");
            string tempAlbum=Console.ReadLine();
            Console.WriteLine("What is the length of the song?");
            string tempLength=Console.ReadLine();
            Console.WriteLine("What is the genre?");
            Console.WriteLine("G - Grunge\nO - Country\nCR - Classic Rock\nP - Pop\nI - Indie");
            Genre tempGenre = Genre.Grunge;
            char g = char.Parse(Console.ReadLine());
            switch(g)
            {
                case 'G':
                    tempGenre = Genre.Grunge; 
                    break;
                case 'C':
                    tempGenre = Genre.Country;
                    break;
                case 'O':
                    tempGenre = Genre.ClassicRock;
                    break;
                case 'P':
                    tempGenre = Genre.Pop;
                    break;
                case 'I':
                    tempGenre = Genre.Indie;
                    break;

            }
            Song song = new Song(tempTitle,tempArtist,tempAlbum,tempLength,tempGenre);
            
            Song newSong = song;

            newSong.setTitle("Vampire");
            newSong.setLength("3 minutes");
            Console.WriteLine("Here's song #2");
            Console.WriteLine($"{newSong.Display()}");

            Console.WriteLine($"Here's song #1");
            Console.WriteLine($"{song.Display()}");


        }
    }
}
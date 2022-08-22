using System;

namespace BookLibrary
{
    public class BookShelf
    {
        public string name;
        public string genres;
        public string author;

        static void Main(string[] args)
        {
            Console.WriteLine("Horror Books:\n");
            Console.WriteLine(HorrorBook1.name + " " + HorrorBook1.genres + " " + HorrorBook1.author);
            Console.WriteLine(HorrorBook2.name + " " + HorrorBook2.genres + " " + HorrorBook2.author);
            Console.WriteLine(HorrorBook3.name + " " + HorrorBook3.genres + " " + HorrorBook3.author);
            Console.WriteLine("Poetry Books:\n");
            Console.WriteLine(PoetryBook1.name + " " + PoetryBook1.genres + " " + PoetryBook1.author);
            Console.WriteLine(PoetryBook2.name + " " + PoetryBook2.genres + " " + PoetryBook2.author);
            Console.WriteLine(PoetryBook3.name + " " + PoetryBook3.genres + " " + PoetryBook3.author);
            Console.WriteLine("Romance Books:\n");
            Console.WriteLine(RomanceBook1.name + " " + RomanceBook1.genres + " " + RomanceBook1.author);
            Console.WriteLine(RomanceBook2.name + " " + RomanceBook2.genres + " " + RomanceBook2.author);
            Console.WriteLine(RomanceBook3.name + " " + RomanceBook3.genres + " " + RomanceBook3.author);

        }
        public BookShelf(string bookName, string genreName, string authorName)
        {
            name = bookName;
            genres = genreName;
            author = authorName;
        }

        public static BookShelf HorrorBook1 = new BookShelf("Manhunt", "Gretchen Felker-Martin", "2020");
        public static BookShelf HorrorBook2 = new BookShelf("The Haciendat", "Isabel Cañas", "2022");
        public static BookShelf HorrorBook3 = new BookShelf("Black Tide", "Kc Jones", "2018");

        public static BookShelf PoetryBook1 = new BookShelf("Sister Tongue", "Farnaz Fatemi", "2015");
        public static BookShelf PoetryBook2 = new BookShelf("The Spectral Wildernesst", "Oliver Bendorf", "2017");
        public static BookShelf PoetryBook3 = new BookShelf("The Many Names for Mother", "Julia Kolchinsky Dasbach", "2016");

        public static BookShelf RomanceBook1 = new BookShelf("Rebel", "Beverly Jenkins", "2018");
        public static BookShelf RomanceBook2 = new BookShelf("A Lady for a Duke", "Alexis Hall", "2010");
        public static BookShelf RomanceBook3 = new BookShelf("The Duke Heist", "Erica Ridley", "1995");
    }
}

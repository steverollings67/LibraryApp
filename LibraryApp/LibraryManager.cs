using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class LibraryManager
    {
        private eBook[] alleBooks = new eBook[7]{
            new eBook{Id=1, Name="How To Cook, F'Real", Author="Tiffany", Description="Recipes and such"},
            new eBook{Id=2, Name="Wearing Glasses", Author="Ben Franklin", Description="Where Glasses came from."},
            new eBook{Id=3, Name="Take a Chance", Author="Jimbo John", Description="A fictional work on Chance" },
            new eBook{Id=4, Name="IT", Author="Stephen King", Description="Scary book about clowns" },
            new eBook{Id=4, Name="Outliers", Author="Malcolm Gladwell", Description="A book about Outliers" },
            new eBook{Id=5, Name="Blink", Author="Malcolm Gladwell", Description="Subconcious thinking book" },
            new eBook{Id=6, Name="Little Women", Author="Mary Balder", Description="A book about litte women" },
            new eBook{Id=7, Name="Forrest Gump", Author="Seth Marshall", Description="A man journey's through history" }
        };
        private DVD[] allDVDs = new DVD[7]  {
            new DVD{Id=8, Name="The Dark Knight", Author="Christopher Nolan", Description="A Batman movie." },
            new DVD{Id=9, Name="Jurassic Park", Author="Steven Speilberg", Description="Dinosuar movie" },
            new DVD{Id=10, Name="Star Wars", Author="George Lucas", Description="Space Ninja movie" },
            new DVD{Id=11, Name="Iron Man", Author="Jon Favreau", Description="Superhero movie" },
            new DVD{Id=12, Name="Super8", Author="JJ Abrams", Description="Kid Monster movie" },
            new DVD{Id=12, Name="Fury", Author="David Ayer", Description="WW2 movie" },
            new DVD{Id=13, Name="300", Author="Zack Snyder", Description="Spartan movie" },
            new DVD{Id=14, Name="Little Women", Author="Greta Gerwig", Description="Drama movie" }
    };
    public void IssueLibraryItemToMember(Member member, LibraryItem libraryItem)
    {
        bool issued = false;
        for (int i = 0; i < member.BorrowedLibraryItems.Length; i++)
        {
            LibraryItem item = member.BorrowedLibraryItems[i];
            if (item == null)
            {
                member.BorrowedLibraryItems[i] = libraryItem;
                Console.WriteLine($"You're checking out {libraryItem.Name} to {member.Name}");
                issued = true;
                break;
            }
            if (!issued)
            {
                Console.WriteLine($"You already have 5 items checked out");
            }
        }
        LibraryItem GetLibraryItem(int id)
        {
            LibraryItem libraryItem = null;
            bool found = false;
            for (int i = 0; i < alleBooks.Length; i++)
            {
                if (alleBooks[i].Id == id)
                {
                    libraryitem = alleBooks[i];
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                for (int i = 0; i < allDVDs.Length; i++)
                {
                    if (allDVDs[i].Id == id)
                    {
                        libraryItem = allDVDs[i];
                        break;
                    }
                }
            }
            return libraryItem;
        }
        void ReturnLibraryItem(Member member, int id)
        {
            bool issued = false;
            for (int i = 0; i < member.BorrowedLibraryItems.Length; i++)
            {
                LibraryItem item = member.BorrowedLibraryItems[i];
                if (item != null && item.Id == id)
                {
                    string libItemName = item.Name;
                    member.BorrowedLibraryItems[i] = null;
                    Console.WriteLine($"{member.Name} is returning {libItemName} on {DateTime.Now.ToString("MMM/dd/yyyy")}");
                    issued = true;
                    break;
                }
            }
            if (!issued)
            {
                Console.WriteLine("Could not find the item to return. Please try again");
            }
        }
        eBook[] ListAllAvailableeBooks()
        {
            Console.WriteLine("All available eBooks");
            foreach (LibraryItem item in alleBooks)
            {
                Console.WriteLine($"Book - ID:{item.Id}, Name: {item.Name} written by {item.Author}");
            }
            return alleBooks;
        }
        eBook[] ListAllAvailableDVDs()
        {
            Console.WriteLine("All Available DVDs.");
            foreach(LibraryItem item in allDVDs)
            {
                Console.WriteLine($"DVD - ID:{item.Id}, Name: {item.Name} directed by {item.Author}");
            }
            return alleBooks;
        }
        }
    }
}

using System;

namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Library App n\ Enter your ID, Name, and Email.");
            int id;
            int.TryParse(Console.ReadLine(), out id);
            string name = Console.ReadLine();
            string email = Console.ReadLine();

            Member member = new Member() { MemberID = id, Name = name, Email = email };

            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("-------------");

            LibraryManager libraryManager = new LibraryManager();
            Console.WriteLine("List of all the eBooks");
            eBook[] allEBooks = libraryManager.ListAllAvailableeBooks();

            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("List of all DVDs");
            eBook[] allDVDs = libraryManager.ListAllAvailableDVDs();

        IssueAnItem:

            Console.WriteLine("Enter Library Item's ID to borrow");
            int libItemId;
            int.TryParse(Console.ReadLine(), out libItemId);

            LibraryItem libraryItemToIssue = libraryManager.GetLibraryItem(libItemId);

            libraryManager.IssueLibraryItemToCustomer(member, libraryItemToIssue);

            Console.WriteLine("More eBooks or DVDs? Enter YES or NO");
            string userResponse = Console.ReadLine();

            if (userResponse == "YES")
            {
                goto IssueAnItem;
            }

            member.ViewMyBorrowedLibraryItems();

        PlayAnItem:
            Console.WriteLine("Enter ID to play an item from your list.");
            int libItemToPlayId;
            int.TryParse(Console.ReadLine(), out libItemToPlayId);

            Console.WriteLine("Want to play again? Enter YES or NO");
            string userResponsePlay = Console.ReadLine();

            if(userResponsePlay == "YES")
            {
                goto PlayAnItem;
            }

            Console.WriteLine("Enter ID to return to library");
            int libItemToReturnId;
            int.TryParse(Console.ReadLine(), out libItemToReturnId);

            libraryManager.ReturnLibraryItem(member, libItemToReturnId);
            member.ViewMyBorrowedLibraryItems();
            

        }
    }
}

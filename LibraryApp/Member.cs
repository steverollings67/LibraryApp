using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Member
    {
        public Member()
        {
            BorrowedLibraryItems = new LibraryItem[5]
        }
        public int MemberID { get; set; };
        public string Name { get; set; };
        public string Email { get; set; };
        public LibraryItem[] BorrowedLibraryItems { get; set; };
        public ViewMyBorrowedLibrayItems()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("These are the items you've checked out.");
            System.Threading.Thread.Sleep(1000);

            if (this.BorrowedLibraryItems != null && this.BorrowedLibraryItems > 0)
            {
                foreach (LibraryItem libitem in this.BorrowedLibraryItems)
                {
                    if (libitem != null)
                        Console.WriteLine($"{ libitem.Name} by {libitem.Author}");
                    Console.WriteLine($" -- {libitem.Description}");

                }
            }
        }
        Console.Foreground = ConsoleColor.White;

        pulic void PlaybyId(int Id)
        {
            foreach(LibraryItem item in BorrowedLibraryItems)
            {
                if(item != null && item.Id == id)
                {
                    item.Play();
                    return;
                }
            }
        }
    }


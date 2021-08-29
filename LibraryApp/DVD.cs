using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class DVD : LibraryItem
    {
        public override void Play()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Playing video and audio for {this.Name} by {this.Author}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

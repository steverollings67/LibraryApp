using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class eBook : LibraryItem
    {
        public override void Play()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Playing the audio for {this.Name} by {this.Author}");
            Console.ResetColor;
        }
    }
}

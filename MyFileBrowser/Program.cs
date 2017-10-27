using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFileBrowser
{
    class Program
    {
        static void Main(string[] args)
        {
            if( args.Length == 0 )
            {
                Console.WriteLine("Geef een argument!");
            } else
            {
                switch(args[0])
                {
                    case "-c":
                        ShowCurrentDirectory();
                        break;
                    case "-f":
                        ShowAllFilesInCurrentDirectory();
                        break;
                    default:
                        Console.WriteLine("Onbekend argument");
                        break;
                }
            }
        }

        static void ShowCurrentDirectory()
        {
            Console.WriteLine("Current Directory:");
        }

        static void ShowAllFilesInCurrentDirectory()
        {
            Console.WriteLine("Alle files in current directory:");
        }
    }
}

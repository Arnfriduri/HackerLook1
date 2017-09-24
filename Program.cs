using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerLook
{
    class Program
    {
        static void Main(string[] args)
        {
            int Height = Console.WindowHeight;
            int Width = Console.WindowWidth;
            string Version = "Version 1.0";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            //Use SetWindowSize so we can control the size of the window
            //Console.SetWindowSize(70, 30);
            //It is called Character Map to create the layout.
            //Console.SetCursorPosition(10, 2);
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("             ##   ##  #######  #######  ##   ##  #######  #######             ");
            Console.WriteLine("             ##   ##  ##   ##  ##       ##  ##   ##       ##  ##              ");
            Console.WriteLine("             #######  #######  ##       #####    #####    #####               ");
            Console.WriteLine("             ##   ##  ##   ##  ##       ##  ##   ##       ##  ##              ");
            Console.WriteLine("             ##   ##  ##   ##  #######  ##   ##  #######  ##   ##             ");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.SetCursorPosition((Width-Version.Length)/2, 7);
            Console.WriteLine(Version);
            Console.ReadKey();
        }
    }
}
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
            string Version = "Version 1.2";
            string Project = "Project";
            string Descrption = "Describe your project";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("*-----------------------------------------------------------------------------*");
            Console.WriteLine("*             ##   ##  #######  #######  ##   ##  #######  #######            *");
            Console.WriteLine("*             ##   ##  ##   ##  ##       ##  ##   ##       ##  ##             *");
            Console.WriteLine("*             #######  #######  ##       #####    #####    #####              *");
            Console.WriteLine("*             ##   ##  ##   ##  ##       ##  ##   ##       ##  ##             *");
            Console.WriteLine("*             ##   ##  ##   ##  #######  ##   ##  #######  ##   ##            *");
            Console.WriteLine("*-----------------------------------------------------------------------------*");
            Console.WriteLine("                         ,--,                    ,--,                  ");
            Console.WriteLine("     |__          __ ___/ /\\|                    |/\\ \\___ __           __|");
            Console.WriteLine(" :__ |_|___/ __ ;(  )__, )                          ( ,__ (  ); __ \\___|_| __:");
            Console.WriteLine(" /-\\|___/-\\_/  ; / /   '--;                        ;--'    \\ \\ ;  \\_/-\\___|/-\\");
            Console.WriteLine(" \\ /    \\ /      \\      |                            |       /      \\ /    \\ /");
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

            Console.SetCursorPosition((Width-Version.Length)/2, 7);
            Console.WriteLine(Version);
            Console.SetCursorPosition((Width-Project.Length)/2, 9);
            Console.WriteLine(Project);
            Console.SetCursorPosition((Width - Descrption.Length)/2, 10);
            Console.WriteLine(Descrption);

            Console.SetCursorPosition(0, 14);
            do
            {
                Console.WriteLine("Test test");

                Console.Write("Do you want to run the program again? y/n: ");
            } while (Console.ReadLine() == "y");
        }
    }
}
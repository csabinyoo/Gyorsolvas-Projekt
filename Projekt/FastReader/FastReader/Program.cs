using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FastReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Használat: FastReader.exe <szövegfájl> <wpm>");
                return;
            }

            string szövegFájl = args[0];
            int wpm = int.Parse(args[1]);

            int szavankentiVarakozas = 60000 / wpm;

            string szöveg = File.ReadAllText(szövegFájl);
            string[] szavak = szöveg.Split(' ');

            int konzolSzélesség = Console.WindowWidth;
            int konzolMagassag = Console.WindowHeight;
            Console.BufferHeight = konzolMagassag;
            Console.CursorVisible = false;

            List<string> márMegjelenítettSzavak = new List<string>();

            while (true)
            {
                foreach (string szó in szavak)
                {
                    int szóSzélesség = szó.Length;

                    Console.Clear();

                    foreach (string márMegjelenítettSzó in márMegjelenítettSzavak)
                    {
                        Console.Write(márMegjelenítettSzó + " ");
                    }

                    int cursorTop = konzolMagassag / 2;
                    int cursorLeft = (konzolSzélesség - szóSzélesség) / 2;

                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.Write(szó);
                    márMegjelenítettSzavak.Add(szó);


                    Thread.Sleep(szavankentiVarakozas);
                }

                Console.Clear();

                foreach (string márMegjelenítettSzó in márMegjelenítettSzavak)
                {
                    Console.Write(márMegjelenítettSzó + " ");
                }

                Console.ReadLine();
            }
        }
    }
}
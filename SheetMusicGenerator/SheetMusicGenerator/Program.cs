using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SheetMusicGenerator.Domain.Builder;
using SheetMusicGenerator.Domain.Pitch;
using SheetMusicGenerator.Domain.Print;

namespace SheetMusicGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var sheet = new SheetMusicBuilder()
                .AddSheet()
                    .AddBar() //Ma-ry had a
                        .AddNode("E")
                        .AddNode("D")
                        .AddNode("C")
                        .AddNode("D")
                    .EndBar()
                    .AddBar() //lit-tle lamb
                        .AddNode("E")
                        .AddNode("E")
                        .AddNode("E")                        
                    .EndBar()
                    .AddBar() //lit-tle lamb
                        .AddNode("D")
                        .AddNode("D")
                        .AddNode("D")
                    .EndBar()
                    .AddBar() //lit-tle lamb
                        .AddNode("E")
                        .AddNode("G")
                        .AddNode("G")
                    .EndBar()
                    .AddBar() //Ma-ry had a
                        .AddNode("E")
                        .AddNode("D")
                        .AddNode("C")
                        .AddNode("D")
                    .EndBar()
                    .AddBar() //lit-tle lamb whose
                        .AddNode("E")
                        .AddNode("E")
                        .AddNode("E")
                        .AddNode("E")
                    .EndBar()
                    .AddBar() //fleece was white as
                        .AddNode("D")
                        .AddNode("D")
                        .AddNode("E")
                        .AddNode("D")
                    .EndBar()
                    .AddBar() //snow
                        .AddNode("C")
                    .EndBar()
                .EndSheet()
            .Build();

            var sheetPrinter = new SheetPrinter();
            var pitchShifter = new Pitchshifter();
            sheetPrinter.PrintSheet(sheet);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Enter + to increment pitch, or - to lower the pitch of the nodes.");
            Console.WriteLine("Enter x to exit.");

            var input = Console.ReadLine();
            while (!input.Equals("x"))
            {
               
                if (!input.Equals("+") && !input.Equals("-"))
                {
                    Console.WriteLine("Illegal character detected. Please only input '+' or '-' ( or x to exit )");                    
                }
                else
                {
                    pitchShifter.ShiftPitch(input, sheet);
                    sheetPrinter.PrintSheet(sheet);
                }

                input = Console.ReadLine();
            }

        }
    }
}

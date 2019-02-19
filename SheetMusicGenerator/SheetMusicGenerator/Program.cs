using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SheetMusicGenerator.Domain.Builder;

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

            Console.WriteLine();

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}

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
                    .AddBar()
                        .AddNode("E")
                        .AddNode("D")
                        .AddNode("C")
                        .AddNode("D")
                    .EndBar()                    
                .EndSheet()
            .Build();

            Console.WriteLine();

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}

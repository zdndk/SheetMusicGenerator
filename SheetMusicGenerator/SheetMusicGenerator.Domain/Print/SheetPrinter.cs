using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SheetMusicGenerator.Domain.Model;
using SheetMusicGenerator.Model;

namespace SheetMusicGenerator.Domain.Print
{
    public class SheetPrinter
    {
        public void PrintSheet(Sheet sheet)
        {
            Console.Write(" | ");
            foreach (var bar in sheet.Bars)
            {
                

                foreach (var barNode in bar.Nodes)
                {
                    Console.Write(barNode.Value + " ");
                }

                Console.Write("| ");
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SheetMusicGenerator.Model;

namespace SheetMusicGenerator.Domain.Model
{
    public class Sheet
    {
        public Sheet(IList<Bar> bars)
        {
            if(bars != null && bars.Any())
                Bars = bars;
            else
                Bars = new List<Bar>();
        }

        public IList<Bar> Bars { get; }
    
    }
}

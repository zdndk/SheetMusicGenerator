using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheetMusicGenerator.Domain.Builder
{
    public interface ISheetBuilder
    {
        IBarBuilder AddBar();
        ISheetMusicBuilder EndSheet();
    }
}

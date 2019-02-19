using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheetMusicGenerator.Domain.Builder
{
    internal interface IInternalSheetBuilder : ISheetBuilder
    {
        IList<IInternalBarBuilder> GetBarBuilders();
    }
}

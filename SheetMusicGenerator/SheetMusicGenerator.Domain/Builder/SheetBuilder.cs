using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SheetMusicGenerator.Model;

namespace SheetMusicGenerator.Domain.Builder
{
    internal class SheetBuilder : IInternalSheetBuilder
    {
        private ISheetMusicBuilder _sheetMusicBuilder;
        private List<IInternalBarBuilder> _barBuilders = new List<IInternalBarBuilder>();

        public SheetBuilder(ISheetMusicBuilder sheetMusicBuilder)
        {
            _sheetMusicBuilder = sheetMusicBuilder;
        }

        public IBarBuilder AddBar()
        {
            IInternalBarBuilder barBuilder = new BarBuilder(this);
            _barBuilders.Add(barBuilder);
            return barBuilder;
        }

        public ISheetMusicBuilder EndSheet()
        {
            return _sheetMusicBuilder;
        }

        public IList<IInternalBarBuilder> GetBarBuilders()
        {
            return _barBuilders;
        }
    }
}

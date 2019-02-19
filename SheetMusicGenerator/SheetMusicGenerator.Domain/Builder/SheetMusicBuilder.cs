using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SheetMusicGenerator.Domain.Model;
using SheetMusicGenerator.Model;

namespace SheetMusicGenerator.Domain.Builder
{
    public class SheetMusicBuilder : ISheetMusicBuilder
    {
        private IInternalBarBuilder _barBuilder = null;
        
        public IBarBuilder AddSheet()
        {
            if (_barBuilder == null) //effectively map all content to one sheet. Multiple sheets not supported in this version
                _barBuilder = new BarBuilder(this);
            return _barBuilder;
        }

        public Sheet Build()
        {
            var returnSheet = new Sheet(null);

            while (_barBuilder != null)
            {
                returnSheet.Bars.Add(new Bar(_barBuilder.GetNodes()));
                _barBuilder = _barBuilder.GetParentBuilder();
            }
            
            return returnSheet;
        }
    }
}

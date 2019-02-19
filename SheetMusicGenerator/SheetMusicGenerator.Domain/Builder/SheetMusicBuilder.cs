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
        private IInternalSheetBuilder _sheetBuilder;
        
        public ISheetBuilder AddSheet()
        {
            return _sheetBuilder ?? (_sheetBuilder = new SheetBuilder(this)); //only one sheet is supported in this version, so the same sheetbuilder is returned once created.
        }

        public Sheet Build()
        {
            var returnSheet = new Sheet(null);

            foreach (var barBuilder in _sheetBuilder.GetBarBuilders())
            {
               returnSheet.Bars.Add(new Bar(barBuilder.GetNodes()));
            }
            
            return returnSheet;
        }
    }
}

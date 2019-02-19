using System;
using SheetMusicGenerator.Domain.Model;

namespace SheetMusicGenerator.Domain.Builder
{
    public interface ISheetMusicBuilder
    {
        ISheetBuilder AddSheet();
        Sheet Build();
    }
}

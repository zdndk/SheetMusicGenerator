﻿using System.Collections.Generic;
using SheetMusicGenerator.Model;

namespace SheetMusicGenerator.Domain.Builder
{
    public interface IBarBuilder
    {
        INodeBuilder AddNode(string note);
        ISheetBuilder EndBar();
    }
}
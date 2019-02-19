using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SheetMusicGenerator.Model;

namespace SheetMusicGenerator.Domain.Builder
{
    internal interface IInternalBarBuilder : IBarBuilder
    {
        void AddNodes(IList<Node> nodes);
        IList<Node> GetNodes();
        //IInternalBarBuilder GetParentBuilder();
    }
}

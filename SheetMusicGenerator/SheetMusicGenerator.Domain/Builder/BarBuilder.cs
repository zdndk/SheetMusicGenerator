using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SheetMusicGenerator.Model;

namespace SheetMusicGenerator.Domain.Builder
{
    internal class BarBuilder : IInternalBarBuilder
    {
        private List<Node> _nodes = new List<Node>();
        private ISheetBuilder _sheetBuilder;

        public void AddNodes(IList<Node> nodes)
        {
            if(nodes != null)
            {
                _nodes.AddRange(nodes);
            }
        }

        public IList<Node> GetNodes()
        {
            return _nodes;
        }

        public INodeBuilder AddNode(string node)
        {
            return new NodeBuilder(this, node);
        }

        public ISheetBuilder EndBar()
        {
            return _sheetBuilder;
        }

        internal BarBuilder(ISheetBuilder sheetBuilder)
        {
            _sheetBuilder = sheetBuilder;
        }
    }
}

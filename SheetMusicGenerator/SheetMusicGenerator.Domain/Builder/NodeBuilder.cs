using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SheetMusicGenerator.Model;

namespace SheetMusicGenerator.Domain.Builder
{
    internal class NodeBuilder : INodeBuilder
    {
        private IInternalBarBuilder _barBuilder = null;
        private IList<Node> _nodes = new List<Node>();

        public IBarBuilder EndBar()
        {
            _barBuilder.AddNodes(_nodes);
            return _barBuilder;
        }

        public INodeBuilder AddNode(string node)
        {
            _nodes.Add(new Node(node));
            return this;
        }

        internal NodeBuilder(IInternalBarBuilder barBuilder, string node)
        {
            _barBuilder = barBuilder;
            _nodes.Add(new Node(node));
        }
    }
}

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
        private IInternalBarBuilder _previousBarBuilder = null;
        private ISheetMusicBuilder _sheetMusicBuilder = null;
        private List<Node> _nodes = new List<Node>();

        public IBarBuilder AddBar()
        {
            if (_previousBarBuilder == null)
                return this;
            return new BarBuilder(this);
        }

        public void AddNodes(IList<Node> nodes)
        {
            if(nodes != null)
                _nodes.AddRange(nodes);
        }

        public ISheetMusicBuilder GetSheetMusicBuilder()
        {
            if (_sheetMusicBuilder != null)
                return _sheetMusicBuilder;
            if (_previousBarBuilder == null)
                throw new Exception("Illegal state: No parent bar found, and no sheetmusic builder set.");
            return _previousBarBuilder.GetSheetMusicBuilder();
        }

        public IList<Node> GetNodes()
        {
            return _nodes;
        }

        public IInternalBarBuilder GetParentBuilder()
        {
            return _previousBarBuilder;
        }

        public INodeBuilder AddNode(string node)
        {
            return new NodeBuilder(this, node);
        }

        public ISheetMusicBuilder EndSheet()
        {
            return GetSheetMusicBuilder();
        }

        internal BarBuilder(ISheetMusicBuilder sheetMusicBuilder)
        {
            _sheetMusicBuilder = sheetMusicBuilder;
        }

        internal BarBuilder(IInternalBarBuilder previousBarBuilder)
        {
            _previousBarBuilder = previousBarBuilder;
        }
    }
}

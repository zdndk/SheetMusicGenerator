using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheetMusicGenerator.Model
{
    public class Bar
    {
        public Bar(IList<Node> nodes)
        {
            if (nodes != null && nodes.Any())
                Nodes = nodes;
            else
                Nodes = new List<Node>();
        }

        public IList<Node> Nodes { get; }    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheetMusicGenerator.Model
{
    public class Node
    {
        public Node(string value)
        {
            Value = value;
        }

        public string Value { get; internal set; }
    }
}
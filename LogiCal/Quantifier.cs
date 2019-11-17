using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiCal
{
    abstract class Quantifier : Node
    {
        public char Variable { get; }
        public Node Proposition { get; }
        public Quantifier(char variable, Node proposition)
        {
            Variable = variable;
            Proposition = proposition;
        }
        public sealed override string ToString()
        {
            return Label + Variable + "." + "(" + Proposition.ToString() + ")";
        }
        public sealed override string ToPrefixString()
        {
            return ShortLabel.ToString() + Variable + "." + "(" + Proposition.ToPrefixString() + ")";
        }
        public sealed override string ToASCIIString() => ToPrefixString();
        public sealed override string GenerateBinaryTree()
        {
            return "node" + ID + " [ label = \"" + ShortLabel.ToString() + Variable + "." + "\" ]\n" +
            "node" + ID + " -- node" + Proposition.ID +
            "\n" +
            Proposition.GenerateBinaryTree();
        }
        public override void ReplaceObjectVariable(char from, char to)
        {
            Proposition.ReplaceObjectVariable(from, to);
        }
    }
}

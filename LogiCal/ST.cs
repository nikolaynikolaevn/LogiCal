using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiCal
{
    class ST
    {
        public bool IsTautology { get; }
        public STElement Root { get; }
        public ST(Node proposition)
        {
            Root = new STElement(new HashSet<Node> { new NegationSign(proposition) }, new List<char>(), "");
            Root.Simplify();
            IsTautology = Root.IsClosed();
        }
    }
}

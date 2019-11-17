using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiCal
{
    class ExistentialQuantifier : Quantifier
    {
        public ExistentialQuantifier(char variable, Node proposition) : base(variable, proposition)
        {
            ShortLabel = '!';
            Label = "∃";
        }
        public override bool Calculate(Row r)
        {
            throw new NotImplementedException();
        }

        public override Node Copy()
        {
            return new ExistentialQuantifier(Variable, Proposition.Copy());
        }

        public override Node Nandify()
        {
            throw new NotImplementedException();
        }
        public override Node ReplaceObjectVariableNewNode(char from, char to)
        {
            return new ExistentialQuantifier(Variable, Proposition.ReplaceObjectVariableNewNode(from, to));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiCal
{
    class UniversalQuantifier : Quantifier
    {
        public UniversalQuantifier(char variable, Node proposition) : base(variable, proposition)
        {
            ShortLabel = '@';
            Label = "∀";
        }
        public override bool Calculate(Row r)
        {
            throw new NotImplementedException();
        }

        public override Node Copy()
        {
            return new UniversalQuantifier(Variable, Proposition.Copy());
        }

        public override Node Nandify()
        {
            throw new NotImplementedException();
        }
        public override Node ReplaceObjectVariableNewNode(char from, char to)
        {
            return new UniversalQuantifier(Variable, Proposition.ReplaceObjectVariableNewNode(from, to));
        }
    }
}

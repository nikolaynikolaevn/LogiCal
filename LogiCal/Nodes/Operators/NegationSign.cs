using System.Collections.Generic;

namespace LogiCal
{
    sealed class NegationSign : UnaryOperator
    {
        public NegationSign(Node childNode) : base(childNode)
        {
            Label = "¬";
            ShortLabel = '~';
        }
        public override bool Calculate(Row r)
        {
            return !childNode.Calculate(r);
        }
        public override Node Copy()
        {
            return new NegationSign(childNode.Copy());
        }
    }
}

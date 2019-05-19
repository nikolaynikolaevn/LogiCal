using System.Collections.Generic;

namespace LogiCal
{
    sealed class BiImplicationSign : BinaryOperator
    {
        public BiImplicationSign(Node leftNode, Node rightNode) : base(leftNode, rightNode)
        {
            Label = "⇔";
            ShortLabel = '=';
        }
        public override bool Calculate(Row r)
        {
            return leftNode.Calculate(r) == rightNode.Calculate(r);
        }
        public override Node Copy()
        {
            return new BiImplicationSign(leftNode.Copy(), rightNode.Copy());
        }
    }
}

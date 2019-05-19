using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiCal.Nodes.Operators
{
    sealed class NANDSign : BinaryOperator
    {
        public NANDSign(Node leftNode, Node rightNode) : base(leftNode, rightNode)
        {
            Label = "↑";
            ShortLabel = '%';
        }
        public override bool Calculate(Row r)
        {
            return !(leftNode.Calculate(r) && rightNode.Calculate(r));
        }
        public override Node Copy()
        {
            return new NANDSign(leftNode.Copy(), rightNode.Copy());
        }
    }
}

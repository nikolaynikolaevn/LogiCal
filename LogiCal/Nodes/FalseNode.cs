using System.Collections.Generic;

namespace LogiCal
{
    sealed class FalseNode : Node
    {
        public FalseNode()
        {
            Label = "False";
            ShortLabel = 'F';
        }
        public override bool Calculate(Row r)
        {
            return false;
        }
        public override string ToString()
        {
            return Label;
        }
        public override string ToPrefixString()
        {
            return ShortLabel.ToString();
        }
        public override Node Copy()
        {
            return new FalseNode();
        }
    }
}

using System.Collections.Generic;

namespace LogiCal
{
    sealed class TrueNode : Node
    {
        public TrueNode()
        {
            Label = "True";
            ShortLabel = 'T';
        }
        public override bool Calculate(Row r)
        {
            return true;
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
            return new TrueNode();
        }
    }
}

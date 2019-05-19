using System.Collections.Generic;

namespace LogiCal
{
    sealed class VariableNode : Node
    {
        public VariableNode(char c)
        {
            ShortLabel = c;
            Label = c.ToString();
        }
        public override bool Calculate(Row r)
        {
            return r.Values[ShortLabel];
        }
        public override string ToString()
        {
            return Label;
        }
        public override string ToPrefixString()
        {
            return Label;
        }
        public override Node Copy()
        {
            return new VariableNode(ShortLabel);
        }
    }
}

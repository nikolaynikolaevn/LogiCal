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
        public override string ToASCIIString() => ToString();
        public override string ToPrefixString()
        {
            return Label;
        }
        public override Node Copy()
        {
            return new VariableNode(ShortLabel);
        }
        public override Node Nandify()
        {
            return this;
        }

        public override Node ReplaceObjectVariableNewNode(char from, char to)
        {
            return this;
        }

        public override void ReplaceObjectVariable(char from, char to) { }
    }
}

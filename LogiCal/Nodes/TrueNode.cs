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
        public override string ToASCIIString() => ToString();
        public override string ToPrefixString()
        {
            return ShortLabel.ToString();
        }
        public override Node Copy()
        {
            return new TrueNode();
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

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
        public override string ToASCIIString() => ToString();
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

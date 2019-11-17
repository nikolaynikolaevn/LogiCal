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
        public override Node Nandify()
        {
            return new NANDSign(childNode.Nandify(), childNode.Nandify());
        }
        public override Node ReplaceObjectVariableNewNode(char from, char to)
        {
            return new NegationSign(childNode.ReplaceObjectVariableNewNode(from, to));
        }
    }
}

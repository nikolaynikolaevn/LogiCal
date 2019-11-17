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
        public override Node Nandify()
        {
            return new NANDSign(new NANDSign(new NANDSign(leftNode.Nandify(), leftNode.Nandify()), new NANDSign(rightNode.Nandify(), rightNode.Nandify())),
                new NANDSign(leftNode.Nandify(), rightNode.Nandify()));
        }
        public override Node ReplaceObjectVariableNewNode(char from, char to)
        {
            return new BiImplicationSign(leftNode.ReplaceObjectVariableNewNode(from, to), rightNode.ReplaceObjectVariableNewNode(from, to));
        }
    }
}

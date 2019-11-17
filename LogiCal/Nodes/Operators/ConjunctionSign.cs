namespace LogiCal
{
    sealed class ConjunctionSign : BinaryOperator
    {
        public ConjunctionSign(Node leftNode, Node rightNode) : base(leftNode, rightNode)
        {
            Label = "⋀";
            ShortLabel = '&';
        }
        public override bool Calculate(Row r)
        {
            return leftNode.Calculate(r) && rightNode.Calculate(r);
        }
        public override Node Copy()
        {
            return new ConjunctionSign(leftNode.Copy(), rightNode.Copy());
        }
        public override Node Nandify()
        {
            return new NANDSign(new NANDSign(leftNode.Nandify(), rightNode.Nandify()), new NANDSign(leftNode.Nandify(), rightNode.Nandify()));
        }
        public override Node ReplaceObjectVariableNewNode(char from, char to)
        {
            return new ConjunctionSign(leftNode.ReplaceObjectVariableNewNode(from, to), rightNode.ReplaceObjectVariableNewNode(from, to));
        }
    }
}

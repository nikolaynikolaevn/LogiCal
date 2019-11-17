namespace LogiCal
{
    sealed class ImplicationSign : BinaryOperator
    {
        public ImplicationSign(Node leftNode, Node rightNode) : base(leftNode, rightNode)
        {
            Label = "⇒";
            ShortLabel = '>';
        }
        public override bool Calculate(Row r)
        {
            return !leftNode.Calculate(r) || rightNode.Calculate(r);
        }
        public override Node Copy()
        {
            return new ImplicationSign(leftNode.Copy(), rightNode.Copy());
        }

        public override Node Nandify()
        {
            return new NANDSign(leftNode.Nandify(), new NANDSign(rightNode.Nandify(), rightNode.Nandify()));
        }

        public override Node ReplaceObjectVariableNewNode(char from, char to)
        {
            return new ImplicationSign(leftNode.ReplaceObjectVariableNewNode(from, to), rightNode.ReplaceObjectVariableNewNode(from, to));
        }
    }
}

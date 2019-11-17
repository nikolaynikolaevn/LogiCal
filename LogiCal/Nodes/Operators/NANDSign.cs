namespace LogiCal
{
    sealed class NANDSign : BinaryOperator
    {
        public NANDSign(Node leftNode, Node rightNode) : base(leftNode, rightNode)
        {
            Label = "↑";
            ShortLabel = '%';
        }
        public override bool Calculate(Row r)
        {
            return !(leftNode.Calculate(r) && rightNode.Calculate(r));
        }
        public override Node Copy()
        {
            return new NANDSign(leftNode.Copy(), rightNode.Copy());
        }
        public override Node Nandify()
        {
            return this;
        }
        public override Node ReplaceObjectVariableNewNode(char from, char to)
        {
            return new NANDSign(leftNode.ReplaceObjectVariableNewNode(from, to), rightNode.ReplaceObjectVariableNewNode(from, to));
        }
    }
}

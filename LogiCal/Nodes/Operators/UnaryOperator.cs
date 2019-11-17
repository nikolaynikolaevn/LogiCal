namespace LogiCal
{
    abstract class UnaryOperator : Node
    {
        protected Node childNode;
        public UnaryOperator(Node childNode)
        {
            this.childNode = childNode;
        }
        public Node ReturnChildNode()
        {
            return childNode;
        }
        public sealed override string ToString()
        {
            return Label + "(" + childNode.ToString() + ")";
        }
        public sealed override string ToASCIIString()
        {
            return ShortLabel + "(" + childNode.ToASCIIString() + ")";
        }
        public sealed override string ToPrefixString()
        {
            return ShortLabel + "(" + childNode.ToPrefixString() + ")";
        }
        public sealed override string GenerateBinaryTree()
        {
            return base.GenerateBinaryTree() +
            "node" + ID + " -- node" + childNode.ID +
            "\n" +
            childNode.GenerateBinaryTree();
        }
        public override void ReplaceObjectVariable(char from, char to)
        {
            childNode.ReplaceObjectVariable(from, to);
        }
    }
}

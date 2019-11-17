namespace LogiCal
{
    abstract class BinaryOperator : Node
    {
        protected Node leftNode;
        protected Node rightNode;
        public BinaryOperator(Node leftNode, Node rightNode)
        {
            this.leftNode = leftNode;
            this.rightNode = rightNode;
        }
        public Node ReturnLeftNode()
        {
            return leftNode;
        }
        public Node ReturnRightNode()
        {
            return rightNode;
        }
        public sealed override string ToString()
        {
            return "(" + leftNode.ToString() + " " + Label + " " + rightNode.ToString() + ")";
        }
        public sealed override string ToASCIIString()
        {
            return "(" + leftNode.ToASCIIString() + " " + ShortLabel + " " + rightNode.ToASCIIString() + ")";
        }
        public sealed override string ToPrefixString()
        {
            return ShortLabel + "(" + leftNode.ToPrefixString() + "," + rightNode.ToPrefixString() + ")";
        }
        public sealed override string GenerateBinaryTree()
        {
            string nodeRefStr = "node" + ID + " -- node";
            return base.GenerateBinaryTree() +
            nodeRefStr + leftNode.ID +
            "\n" +
            leftNode.GenerateBinaryTree() +
            nodeRefStr + rightNode.ID +
            "\n" +
            rightNode.GenerateBinaryTree();
        }
        public override void ReplaceObjectVariable(char from, char to)
        {
            leftNode.ReplaceObjectVariable(from, to);
            rightNode.ReplaceObjectVariable(from, to);
        }
    }
}

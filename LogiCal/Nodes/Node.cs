namespace LogiCal
{
    public abstract class Node
    {
        private static int id = 1;
        public int ID { get; }
        public string Label { get; protected set; }
        public char ShortLabel { get; protected set; }
        //public int ValueChar => Calculate(truthRow) == true ? '1' : '0';
        public Node()
        {
            ID = id;
            id++;
        }
        public abstract Node Copy();
        public abstract bool Calculate(Row r);
        public virtual string GenerateBinaryTree()
        {
            return "node" + ID + " [ label = \"" + ShortLabel + "\" ]\n";
        }
        public abstract string ToPrefixString();
        public abstract string ToASCIIString();
        public abstract Node Nandify();

        public override bool Equals(object other)
        {
            return (other is Node n) ? ToPrefixString().Equals(n.ToPrefixString()) : false;
        }
        public override int GetHashCode()
        {
            return ToPrefixString().GetHashCode();
        }
        public abstract Node ReplaceObjectVariableNewNode(char from, char to);
        public abstract void ReplaceObjectVariable(char from, char to);
    }
}

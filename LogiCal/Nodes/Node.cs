using System.Collections.Generic;

namespace LogiCal
{
    abstract class Node
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
        //public abstract Node Nandify();
    }
}

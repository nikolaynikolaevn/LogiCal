using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiCal
{
    class PredicateNode : Node
    {
        public char Letter { get; }
        public char[] Variables { get; private set; }
        public PredicateNode(char letter, char[] variables)
        {
            ShortLabel = Letter = letter;
            Variables = variables;
            Label = ToString();
        }
        public override bool Calculate(Row r)
        {
            throw new NotImplementedException();
        }

        public override Node Copy()
        {
            return new PredicateNode(Letter, Variables.Clone() as char[]);
        }

        public override Node Nandify()
        {
            throw new NotImplementedException();
        }

        public sealed override string ToString()
        {
            string temp = Letter + "(";
            for (int i = 0; i < Variables.Length; i++)
            {
                temp += Variables[i];
                if (i != Variables.Length - 1) temp += ", ";
            }
            return temp + ")";
        }

        public override string GenerateBinaryTree()
        {
            return "node" + ID + " [ label = \"" + Label + "\" ]\n";
        }

        public sealed override string ToASCIIString() => ToString();

        public sealed override string ToPrefixString() => ToString();
        public void NewVariables()
        {
            for (int i = 0; i < Variables.Length; i++)
            {
                Variables[i]++;
            }
        }
        public override Node ReplaceObjectVariableNewNode(char fromz, char to)
        {
            PredicateNode temp = (PredicateNode)Copy();
            for (int i = 0; i < Variables.Length; i++)
            {
                if (temp.Variables[i] == from)
                {
                    temp.Variables[i] = to;
                    return temp;
                }
            }
            return this;
        }
        public override void ReplaceObjectVariable(char from, char to)
        {
            for (int i = 0; i < Variables.Length; i++)
            {
                if (Variables[i] == from)
                {
                    Variables[i] = to;
                    return;
                }
            }
        }
    }
}

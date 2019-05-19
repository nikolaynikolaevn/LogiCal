using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace LogiCal
{
    sealed class Parser
    {
        public char[] Variables { get; private set; }
        public Node ParseExpression(string s)
        {
            s = TranslateExpression(s);
            Regex r = new Regex("^[~>=&\\|01,()A-Z ]*$");
            if (!r.IsMatch(s)) throw new InvalidCharacterException();
            int leftBracketsCount = s.Count(x => x == '(');
            int rightBracketsCount = s.Count(x => x == ')');
            if (leftBracketsCount != rightBracketsCount) throw new MissingBracketException();
            s = s.Replace(" ", string.Empty);
            if (s.Length > 0)
            {
                if (s.Length == 1)
                {
                    if (!char.IsLetter(s[0])) throw new InvalidExpressionException();
                }
                Variables = s.Distinct().Where(char.IsLetter).ToArray();
                Array.Sort(Variables);
                return Parse(ref s);
            }
            return null;
        }

        private string TranslateExpression(string s)
        {
            s = s.ToUpper();
            s = s.Replace("NOT", "~");
            s = s.Replace("¬", "~");
            s = s.Replace("⇒", ">");
            s = s.Replace("=>", ">");
            s = s.Replace("⇔", "=");
            s = s.Replace("<=>", "=");
            //s = s.Replace("⋀", "&");
            //s = s.Replace("^", "&");
            //s = s.Replace("⋁", "|");
            //s = s.Replace("V", "|");
            s = s.Replace("FALSE", "F");
            s = s.Replace("TRUE", "T");
            s = s.Replace("0", "F");
            s = s.Replace("1", "T");
            return s;
        }

        private Node Parse(ref string s)
        {
            Node a, b;
            char c = s[0];
            s = s.Substring(1);
            if (c == '>' || c == '=' || c == '&' || c == '|')
            {
                SkipCharacter(ref s, '(');
                a = Parse(ref s);
                SkipCharacter(ref s, ',');
                b = Parse(ref s);
                SkipCharacter(ref s, ')');
                if (c == '>') return new ImplicationSign(a, b);
                else if (c == '=') return new BiImplicationSign(a, b);
                else if (c == '&') return new ConjunctionSign(a, b);
                else return new DisjunctionSign(a, b);
            }
            else if (c == '~')
            {
                SkipCharacter(ref s, '(');
                a = Parse(ref s);
                SkipCharacter(ref s, ')');
                return new NegationSign(a);
            }
            else if (c == 'F' || c == 'T')
            {
                if (c == 'F') return new FalseNode();
                return new TrueNode();
            }
            else if (char.IsLetter(c))
            {
                if (s.Length > 0) Validate(s);
                return new VariableNode(c);
            }
            throw new InvalidExpressionException();
        }

        private void Validate(string s)
        {
            if (s[0] != ',' && s[0] != ')') throw new InvalidExpressionException();
        }

        private void SkipCharacter(ref string s, char c)
        {
            if (s[0] != c)
            {
                switch (c)
                {
                    case '(':
                        //throw new LeftBracketExpectedException();
                        break;
                    case ',':
                        throw new SeparatorExpectedException();
                    case ')':
                        //throw new RightBracketExpectedException();
                        break;
                }
            }
            s = s.Substring(1);
        }
    }
}

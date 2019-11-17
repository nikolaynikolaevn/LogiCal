using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LogiCal
{
    public sealed class Parser
    {
        public char[] Variables { get; private set; }
        public bool IsProposition { get; private set; }
        public Node ParseExpression(string s)
        {
            s = TranslateExpression(s);
            Regex r = new Regex("^[~>=&%\\|01,()@!.A-Za-z ]*$");
            if (!r.IsMatch(s)) throw new InvalidCharacterException();
            int leftBracketsCount = s.Count(x => x == '(');
            int rightBracketsCount = s.Count(x => x == ')');
            if (leftBracketsCount != rightBracketsCount) throw new MissingBracketException();
            s = s.Replace(" ", string.Empty);
            if (s.Length > 0)
            {
                if (s.Length == 1)
                {
                    if (!char.IsLetter(s[0]) && !char.IsDigit(s[0])) throw new InvalidExpressionException();
                }
                Variables = s.Distinct().Where(char.IsLetter).ToArray();
                Array.Sort(Variables);
                CheckIfProposition(s);
                if (!IsProposition)
                {
                    CheckBounding(s);
                    CheckPredicateMismatch(s);
                }
                return Parse(ref s);
            }
            return null;
        }

        private string TranslateExpression(string s)
        {
            //s = s.ToUpper();
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
            s = s.Replace("FALSE", "0");
            s = s.Replace("TRUE", "1");
            //s = s.Replace("F", "0");
            //s = s.Replace("T", "1");
            return s;
        }

        private Node Parse(ref string s)
        {
            CheckIfEmpty(s);
            Node a, b;
            char c = s[0];
            s = s.Substring(1);
            if (c == '>' || c == '=' || c == '&' || c == '|' || c == '%')
            {
                SkipCharacter(ref s, '(');
                a = Parse(ref s);
                SkipCharacter(ref s, ',');
                b = Parse(ref s);
                SkipCharacter(ref s, ')');
                if (c == '>') return new ImplicationSign(a, b);
                else if (c == '=') return new BiImplicationSign(a, b);
                else if (c == '&') return new ConjunctionSign(a, b);
                else if (c == '|') return new DisjunctionSign(a, b);
                else return new NANDSign(a, b);
            }
            else if (c == '~')
            {
                SkipCharacter(ref s, '(');
                a = Parse(ref s);
                SkipCharacter(ref s, ')');
                return new NegationSign(a);
            }
            else if (c == '@' || c == '!')
            {
                if (!char.IsLetter(s[0]) || char.IsUpper(s[0])) throw new InvalidExpressionException();
                char var = s[0];
                s = s.Substring(1);
                SkipCharacter(ref s, '.');
                SkipCharacter(ref s, '(');
                a = Parse(ref s);
                SkipCharacter(ref s, ')');
                if (c == '@') return new UniversalQuantifier(var, a);
                return new ExistentialQuantifier(var, a);
            }
            else if (c == '0' || c == '1')
            {
                if (c == '0') return new FalseNode();
                return new TrueNode();
            }
            else if (char.IsLetter(c) && char.IsUpper(c) && s != "" && s[0] == '(')
            {
                s = s.Substring(1);
                List<char> vars = new List<char>();
                while (s != "" && char.IsLetter(s[0]))
                {
                    if (char.IsUpper(s[0])) throw new InvalidExpressionException();
                    vars.Add(s[0]);
                    s = s.Substring(1);
                    Validate(s);
                    s = s.Substring(1);
                }
                return new PredicateNode(c, vars.ToArray());
            }
            else if (char.IsLetter(c) && char.IsUpper(c))
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
            CheckIfEmpty(s);
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
                    case '.':
                        throw new Exception("Dot expected");
                }
            }
            s = s.Substring(1);
        }
        private void CheckIfEmpty(string s)
        {
            if (s == "") throw new InvalidExpressionException();
        }

        private void CheckBounding(string s)
        {
            foreach (char var in Variables.Where(x => char.IsLower(x)))
            {
                if (!s.Contains(var + ".") && (s.Contains("@") || s.Contains("!"))) throw new Exception(var + " is not bound.");
            }
        }
        private void CheckPredicateMismatch(string s)
        {
            MatchCollection predicates = Regex.Matches(s, "[A-Z](([^)]+))");
            foreach (Match ItemMatchA in predicates)
            {
                foreach (Match ItemMatchB in predicates)
                {
                    if (ItemMatchA.Value[0] == ItemMatchB.Value[0] && ItemMatchA.Value.Length != ItemMatchB.Value.Length)
                        throw new Exception("Predicate " + ItemMatchA.Value[0] + " definitions have a mismatching number of object variables.");
                }
            }
        }
        private void CheckIfProposition(string s)
        {
            if (s.Contains("@") || s.Contains("!") || s != s.ToUpper()) IsProposition = false;
            else IsProposition = true;
        }
    }
}

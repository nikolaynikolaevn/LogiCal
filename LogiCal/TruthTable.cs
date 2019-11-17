using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LogiCal
{
    public sealed class TruthTable
    {
        public char[] Variables { get; }
        public int VariablesCount { get; }
        public string[] RowsString { get; private set; }
        public string[] Rows { get; private set; }
        public int CombinationsCount { get; }
        private char[] truthValues;
        public string BinHashValue { get; private set; }
        public string HexHashValue { get; private set; }
        public Node Proposition { get; }
        public TruthTable Simplified { get; }

        /*
         * Generate sample TruthTable for the variables
        */

        public TruthTable(char[] variables, Node root)
        {
            if (root != null)
            {
                Variables = variables;
                VariablesCount = variables.Length;
                Proposition = root;

                CombinationsCount = 1 << VariablesCount;
                RowsString = GenerateNewTruthTable();
                Simplified = Simplify(GetRowsMerged());
            }
        }

        public TruthTable(char[] variables, Node root, string[] rows)
        {
            Variables = variables;
            VariablesCount = variables.Length;
            Proposition = root;
            CombinationsCount = rows.Length;
            Rows = rows;
            truthValues = GetResultColumn();
            RowsString = GenerateTruthTable();
        }

        private char[] GetResultColumn()
        {
            char[] temp = new char[Rows.Length];
            for (int i = 0; i < Rows.Length; i++)
            {
                temp[i] = Rows[i][VariablesCount];
            }
            return temp;
        }

        //private void GenerateRows()
        //{
        //    for (int i = 1; i < RowsString.Length; i++)
        //    {
        //        Rows.Add(new Row(row)
        //    }
        //}

        private string[] GenerateNewTruthTable()
        {
            if (Rows != null) throw new Exception("Not a new truth table.");
            string[] temp = new string[CombinationsCount + 1];
            string[] lines = GenerateTruthTableValues();
            truthValues = CalculateTruthTableChar();

            temp[0] = string.Join("    ", Variables) + "    " + Proposition.ToString();
            for (int k = 0; k < lines.Length; k++)
            {
                temp[k + 1] = lines[k] + truthValues[k];
            }
            CalculateHash();
            return temp;
        }

        private string[] GenerateTruthTable()
        {
            if (Rows == null) throw new Exception("Table does not exist.");
            string[] temp = new string[CombinationsCount + 1];
            temp[0] = string.Join("    ", Variables) + "    " + Proposition.ToString();
            for (int k = 0; k < Rows.Length; k++)
            {
                temp[k + 1] = SplitString(Rows[k]);
            }
            CalculateHash();
            return temp;
        }

        private string[] GenerateTruthTableValues()
        {
            Rows = new string[CombinationsCount];
            string[] rowsSplitted = new string[CombinationsCount];
            for (int k = 0; k < CombinationsCount; k++)
            {
                Rows[k] = Convert.ToString(k, 2).PadLeft(VariablesCount, '0');
                rowsSplitted[k] = SplitString(Rows[k]);
            }
            return rowsSplitted;
        }

        private string SplitString(string row)
        {
            string temp = "";
            foreach (char c in row)
            {
                temp += c + "    ";
            }
            return temp;
        }

        /*
        * Calculate TruthTable
        */

        private Row GetRow(int index)
        {
            Dictionary<char, bool> temp = new Dictionary<char, bool>();
            for (int i = 0; i < VariablesCount; i++)
            {
                temp.Add(Variables[i], Rows[index][i] == '1');
            }
            return new Row(temp);
        }

        private Dictionary<string, bool> GetRowsMerged()
        {
            Dictionary<string, bool> temp = new Dictionary<string, bool>();
            for (int k = 0; k < Rows.Length; k++)
            {
                temp.Add(Rows[k] + truthValues[k], false);
            }
            return temp;
        }

        private string[] GetRows()
        {
            string[] temp = new string[Rows.Length];
            for (int k = 0; k < Rows.Length; k++)
            {
                temp[k] = Rows[k] + truthValues[k];
            }
            return temp;
        }

        private bool[] CalculateTruthTable()
        {
            bool[] truthColumn = new bool[CombinationsCount];
            for (int k = 0; k < CombinationsCount; k++)
            {
                truthColumn[k] = Proposition.Calculate(GetRow(k));
            }
            return truthColumn;
        }

        private char[] CalculateTruthTableChar()
        {
            char[] truthColumn = new char[CombinationsCount];
            for (int k = 0; k < CombinationsCount; k++)
            {
                truthColumn[k] = (Proposition.Calculate(GetRow(k)) == true) ? '1' : '0';
            }
            return truthColumn;
        }

        private void CalculateHash()
        {
            char[] binChars = truthValues.Clone() as char[];
            Array.Reverse(binChars);
            BinHashValue = new string(binChars);
            HexHashValue = Calculator.BinaryStringToHexString(new string(binChars));
        }

        /*
        * Simplify TruthTable
        */

        private TruthTable ConstructSimplifiedTruthTable(Dictionary<string, bool> mergedRows)
        {
            List<string> temp = new List<string>();
            foreach (KeyValuePair<string, bool> row in mergedRows)
            {
                if (!row.Value) temp.Add(row.Key);
            }
            return new TruthTable(Variables, Proposition, temp.ToArray());
        }

        private TruthTable Simplify(Dictionary<string, bool> mergedRows)
        {
            int mergedCount = 0;
            for (int k = 0; k < mergedRows.Count; k++)
            {
                for (int m = 0; m < mergedRows.Count; m++)
                {
                    if (Merge(mergedRows.Keys.ElementAt(k), mergedRows.Keys.ElementAt(m), mergedRows))
                    {
                        mergedCount++;
                    }
                }
            }
            //if (mergedCount > 0) Simplify(mergedRows);
            return ConstructSimplifiedTruthTable(mergedRows);
        }

        private bool Merge(string r1, string r2, Dictionary<string, bool> mergedRows)
        {
            int diff = Compare(r1, r2);
            if (diff > -1)
            {
                mergedRows[r1] = mergedRows[r2] = true;
                StringBuilder sb = new StringBuilder(r1);
                sb[diff] = '*';
                if (AddLine(sb.ToString(), mergedRows))
                {
                    return true;
                }
            }
            return false;
        }

        private int Compare(string r1, string r2)
        {
            if (r1 == r2 || r1[VariablesCount] != r2[VariablesCount]) return -1;
            int count = 0;
            int diff = -1;
            for (int i = 0; i < VariablesCount; i++)
            {
                if ((r1[i] == '*' && r2[i] != '*') || (r1[i] != '*' && r2[i] == '*')) return -1;
                if (r1[i] != r2[i])
                {
                    count++;
                    diff = i;
                }
            }
            if (count > 1) return -1;
            return diff;
        }

        private bool AddLine(string r, Dictionary<string, bool> mergedRows)
        {
            if (mergedRows.ContainsKey(r)) return false;
            mergedRows.Add(r, false);
            return true;
        }

        /*
         * DNF
        */

        public Node CreateDNF()
        {
            string[] rows = GetRows();
            List<string> disjuncts = new List<string>();
            foreach (string row in rows)
            {
                if (row[VariablesCount] == '1') disjuncts.Add(GenerateConjunct(row));
            }
            string temp = "";
            foreach (string disjunct in disjuncts)
            {
                if (temp == "") temp = disjunct;
                else temp = GenerateVariableDisjunctionString(temp, disjunct);
            }
            Parser p = new Parser();
            return p.ParseExpression(temp);
        }

        private string GenerateConjunct(string row)
        {
            string temp = "";
            string dnf = "";
            for (int i = 0; i < VariablesCount; i++)
            {
                if (row[i] == '1') dnf = Variables[i].ToString();
                else if (row[i] == '*') dnf = GenerateUnknownVariableString(Variables[i]);
                else dnf = GenerateVariableNegationString(Variables[i]);
                if (temp == "") temp = dnf;
                else temp = GenerateVariableConjunctionString(temp, dnf);
            }
            return temp;
        }

        private string GenerateVariableNegationString(char variable)
        {
            return new NegationSign(new VariableNode(variable)).ToPrefixString();
        }

        private string GenerateVariableConjunctionString(string str1, string str2)
        {
            return "&(" + str1 + "," + str2 + ")";
        }

        private string GenerateVariableDisjunctionString(string str1, string str2)
        {
            return "|(" + str1 + "," + str2 + ")";
        }

        private string GenerateUnknownVariableString(char variable)
        {
            return "|(" + variable + "," + GenerateVariableNegationString(variable) + ")";
        }
    }
}
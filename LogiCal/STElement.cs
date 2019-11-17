using System;
using System.Collections.Generic;

namespace LogiCal
{
    class STElement
    {
        private static int id = 1;
        public int ID { get; }
        public List<char> ActiveVariables;
        private HashSet<Node> propositions;
        public string LastRule { get; }
        private STElement leftNode;
        private STElement rightNode;
        public STElement(HashSet<Node> propositions, List<char> activeVariables, string lastRule)
        {
            ID = id;
            id++;
            this.propositions = propositions;
            ActiveVariables = activeVariables;
            LastRule = lastRule;
        }
        public virtual string GenerateBinaryTree()
        {
            string nodeRefStr = "node" + ID + " -- node";
            string temp = "node" + ID + " [ label = \"" + ToString() + "\" ]\n";
            if (leftNode != null) temp += nodeRefStr + leftNode.ID + "\n" + leftNode.GenerateBinaryTree();
            if (rightNode != null) temp += nodeRefStr + rightNode.ID + "\n" + rightNode.GenerateBinaryTree();
            return temp;
        }
        public sealed override string ToString()
        {
            int counter = 0;
            string temp = "";
            if (LastRule != "") temp += LastRule + Environment.NewLine;
            if (ActiveVariables.Count != 0)
            {
                temp += "<";
                foreach (char var in ActiveVariables)
                {
                    temp += var;
                    if (var != ActiveVariables[ActiveVariables.Count - 1]) temp += ", ";
                }
                temp += ">" + Environment.NewLine;
            }
            foreach (Node n in propositions)
            {
                counter++;
                temp += n.ToPrefixString();
                if (counter != propositions.Count) temp += Environment.NewLine;
            }
            return temp;
        }

        public bool IsClosed()
        {
            if (leftNode != null)
            {
                if (rightNode != null) return leftNode.IsClosed() && rightNode.IsClosed();
                return leftNode.IsClosed();
            }
            return ExistsContradiction();
        }
        protected bool ExistsContradiction()
        {
            foreach (Node n in propositions)
            {
                if (propositions.Contains(new NegationSign(n))) return true;
            }
            return false;
        }

        public void Simplify()
        {
            if (!ApplyNegationRule())
            {
                if (!ApplyAlfaRules())
                {
                    if (!ApplyDeltaRules())
                    {
                        if (!ApplyBetaRules())
                        {
                            ApplyGammaRules();
                        }
                    }
                }
            }
        }

        private bool ApplyNegationRule()
        {
            string rule = "Negation rule";
            foreach (Node n in propositions)
            {
                if (n is NegationSign)
                {
                    if (((NegationSign)n).ReturnChildNode() is NegationSign)
                    {
                        HashSet<Node> props = new HashSet<Node>(propositions);
                        props.Remove(n);
                        HashSet<Node> nodes = new HashSet<Node> { ((NegationSign)((NegationSign)n).ReturnChildNode()).ReturnChildNode() };
                        props.UnionWith(nodes);
                        leftNode = new STElement(props, ActiveVariables, rule);
                        SimplifyChild(leftNode);
                        return true;
                    }
                    else continue;
                }
            }
            return false;
        }

        private bool ApplyAlfaRules()
        {
            string rule = "Alfa rule";
            foreach (Node n in propositions)
            {
                if (n is ConjunctionSign)
                {
                    HashSet<Node> props = new HashSet<Node>(propositions);
                    props.Remove(n);
                    HashSet<Node> nodes = new HashSet<Node> { ((ConjunctionSign)n).ReturnLeftNode(), ((ConjunctionSign)n).ReturnRightNode() };
                    props.UnionWith(nodes);
                    leftNode = new STElement(props, ActiveVariables, rule);
                    SimplifyChild(leftNode);
                    return true;
                }
                else if (n is BiImplicationSign)
                {
                    HashSet<Node> props = new HashSet<Node>(propositions);
                    props.Remove(n);
                    HashSet<Node> nodes = new HashSet<Node> {
                        new ImplicationSign(((BiImplicationSign)n).ReturnLeftNode(), ((BiImplicationSign)n).ReturnRightNode()),
                        new ImplicationSign(((BiImplicationSign)n).ReturnRightNode(), ((BiImplicationSign)n).ReturnLeftNode()),
                    };
                    props.UnionWith(nodes);
                    leftNode = new STElement(props, ActiveVariables, rule);
                    SimplifyChild(leftNode);
                    return true;
                }
                else if (n is NegationSign)
                {
                    if (((NegationSign)n).ReturnChildNode() is DisjunctionSign)
                    {
                        HashSet<Node> props = new HashSet<Node>(propositions);
                        props.Remove(n);
                        DisjunctionSign disjunctionSign = (DisjunctionSign)((NegationSign)n).ReturnChildNode();
                        HashSet<Node> nodes = new HashSet<Node> { new NegationSign(disjunctionSign.ReturnLeftNode()),
                                new NegationSign(disjunctionSign.ReturnRightNode()) };
                        props.UnionWith(nodes);
                        leftNode = new STElement(props, ActiveVariables, rule);
                        SimplifyChild(leftNode);
                        return true;
                    }
                    else if (((NegationSign)n).ReturnChildNode() is ImplicationSign)
                    {
                        HashSet<Node> props = new HashSet<Node>(propositions);
                        props.Remove(n);
                        ImplicationSign implicationSign = (ImplicationSign)((NegationSign)n).ReturnChildNode();
                        HashSet<Node> nodes = new HashSet<Node> { implicationSign.ReturnLeftNode(),
                                new NegationSign(implicationSign.ReturnRightNode()) };
                        props.UnionWith(nodes);
                        leftNode = new STElement(props, ActiveVariables, rule);
                        SimplifyChild(leftNode);
                        return true;
                    }
                    else continue;
                }
                else continue;
            }
            return false;
        }

        private bool ApplyBetaRules()
        {
            string rule = "Beta rule";
            foreach (Node n in propositions)
            {
                if (n is NegationSign && ((NegationSign)n).ReturnChildNode() is ConjunctionSign)
                {
                    HashSet<Node> props = new HashSet<Node>(propositions);
                    props.Remove(n);
                    HashSet<Node> propsb = new HashSet<Node>(props);
                    ConjunctionSign negationSignChild = (ConjunctionSign)((NegationSign)n).ReturnChildNode();
                    HashSet<Node> nodes = new HashSet<Node> { new NegationSign(negationSignChild.ReturnLeftNode()) };
                    HashSet<Node> nodeb = new HashSet<Node> { new NegationSign(negationSignChild.ReturnRightNode()) };
                    props.UnionWith(nodes);
                    propsb.UnionWith(nodeb);
                    leftNode = new STElement(props, ActiveVariables, rule);
                    rightNode = new STElement(propsb, ActiveVariables, rule);
                    SimplifyChilds(leftNode, rightNode);
                    return true;
                }
                else if (n is NegationSign && ((NegationSign)n).ReturnChildNode() is NANDSign)
                {
                    HashSet<Node> props = new HashSet<Node>(propositions);
                    props.Remove(n);
                    HashSet<Node> propsb = new HashSet<Node>(props);
                    NANDSign NANDSign = (NANDSign)((NegationSign)n).ReturnChildNode();
                    HashSet<Node> nodes = new HashSet<Node> { NANDSign.ReturnLeftNode() };
                    HashSet<Node> nodeb = new HashSet<Node> { NANDSign.ReturnRightNode() };
                    props.UnionWith(nodes);
                    propsb.UnionWith(nodeb);
                    leftNode = new STElement(props, ActiveVariables, rule);
                    rightNode = new STElement(propsb, ActiveVariables, rule);
                    SimplifyChilds(leftNode, rightNode);
                    return true;
                }
                else if (n is NANDSign)
                {
                    HashSet<Node> props = new HashSet<Node>(propositions);
                    props.Remove(n);
                    HashSet<Node> propsb = new HashSet<Node>(props);
                    NANDSign NANDSign = (NANDSign)n;
                    HashSet<Node> nodes = new HashSet<Node> { new NegationSign(NANDSign.ReturnLeftNode()) };
                    HashSet<Node> nodeb = new HashSet<Node> { new NegationSign(NANDSign.ReturnRightNode()) };
                    props.UnionWith(nodes);
                    propsb.UnionWith(nodeb);
                    leftNode = new STElement(props, ActiveVariables, rule);
                    rightNode = new STElement(propsb, ActiveVariables, rule);
                    SimplifyChilds(leftNode, rightNode);
                    return true;
                }
                else if (n is DisjunctionSign)
                {
                    HashSet<Node> props = new HashSet<Node>(propositions);
                    props.Remove(n);
                    HashSet<Node> propsb = new HashSet<Node>(props);
                    HashSet<Node> nodes = new HashSet<Node> { ((DisjunctionSign)n).ReturnLeftNode() };
                    HashSet<Node> nodeb = new HashSet<Node> { ((DisjunctionSign)n).ReturnRightNode() };
                    props.UnionWith(nodes);
                    propsb.UnionWith(nodeb);
                    leftNode = new STElement(props, ActiveVariables, rule);
                    rightNode = new STElement(propsb, ActiveVariables, rule);
                    SimplifyChilds(leftNode, rightNode);
                    return true;
                }
                else if (n is ImplicationSign)
                {
                    HashSet<Node> props = new HashSet<Node>(propositions);
                    props.Remove(n);
                    HashSet<Node> propsb = new HashSet<Node>(props);
                    HashSet<Node> nodes = new HashSet<Node> { new NegationSign(((ImplicationSign)n).ReturnLeftNode()) };
                    HashSet<Node> nodeb = new HashSet<Node> { ((ImplicationSign)n).ReturnRightNode() };
                    props.UnionWith(nodes);
                    propsb.UnionWith(nodeb);
                    leftNode = new STElement(props, ActiveVariables, rule);
                    rightNode = new STElement(propsb, ActiveVariables, rule);
                    SimplifyChilds(leftNode, rightNode);
                    return true;
                }
                else if (n is NegationSign && ((NegationSign)n).ReturnChildNode() is BiImplicationSign)
                {
                    BiImplicationSign biImplicationSign = (BiImplicationSign)((NegationSign)n).ReturnChildNode();
                    HashSet<Node> props = new HashSet<Node>(propositions);
                    props.Remove(n);
                    HashSet<Node> propsb = new HashSet<Node>(props);
                    HashSet<Node> nodes = new HashSet<Node> { new NegationSign(new ImplicationSign(
                        biImplicationSign.ReturnLeftNode(), biImplicationSign.ReturnRightNode()))
                    };
                    HashSet<Node> nodeb = new HashSet<Node> { new NegationSign(new ImplicationSign(
                        biImplicationSign.ReturnRightNode(), biImplicationSign.ReturnLeftNode()))
                    };
                    props.UnionWith(nodes);
                    propsb.UnionWith(nodeb);
                    leftNode = new STElement(props, ActiveVariables, rule);
                    rightNode = new STElement(propsb, ActiveVariables, rule);
                    SimplifyChilds(leftNode, rightNode);
                    return true;
                }
                else continue;
            }
            return false;
        }

        private bool ApplyDeltaRules()
        {
            string rule = "Delta rule";
            foreach (Node n in propositions)
            {
                if (n is ExistentialQuantifier)
                {
                    HashSet<Node> props = new HashSet<Node>(propositions);
                    props.Remove(n);
                    //change variable
                    List<char> newVariables = AddNewVariable();
                    try
                    {
                        ExistentialQuantifier quantifier = (ExistentialQuantifier)n.Copy();
                        quantifier.ReplaceObjectVariable(quantifier.Variable, newVariables[newVariables.Count - 1]);
                        HashSet<Node> nodes = new HashSet<Node> { quantifier.Proposition };
                        props.UnionWith(nodes);
                        leftNode = new STElement(props, newVariables, rule);
                        SimplifyChild(leftNode);
                        return true;
                    }
                    catch (Exception ex) { DirectMessage.ShowError(ex.Message); }
                }
                else if (n is NegationSign && ((NegationSign)n).ReturnChildNode() is UniversalQuantifier)
                {
                    HashSet<Node> props = new HashSet<Node>(propositions);
                    props.Remove(n);
                    //change variable
                    List<char> newVariables = AddNewVariable();
                    try
                    {
                        UniversalQuantifier quantifier = (UniversalQuantifier)((NegationSign)n).ReturnChildNode().Copy();
                        quantifier.ReplaceObjectVariable(quantifier.Variable, newVariables[newVariables.Count - 1]);
                        HashSet<Node> nodes = new HashSet<Node> { new NegationSign(quantifier.Proposition) };
                        props.UnionWith(nodes);
                        leftNode = new STElement(props, newVariables, rule);
                        SimplifyChild(leftNode);
                        return true;
                    }
                    catch (Exception ex) { DirectMessage.ShowError(ex.Message); }
                }
                else continue;
            }
            return false;
        }

        private bool ApplyGammaRules()
        {
            string rule = "Gamma rule";
            HashSet<Node> nodes = new HashSet<Node>();
            foreach (Node n in propositions)
            {
                if (n is UniversalQuantifier)
                {
                    UniversalQuantifier quantifier = (UniversalQuantifier)n;
                    //add predicates for existing variables
                    foreach (char var in ActiveVariables)
                    {
                        try
                        {
                            UniversalQuantifier newQuantifier = (UniversalQuantifier)quantifier.Copy().ReplaceObjectVariableNewNode(quantifier.Variable, var);
                            if (quantifier != null) nodes.Add(newQuantifier.Proposition);
                        }
                        catch (Exception ex) { DirectMessage.ShowError(ex.Message); }
                    }
                }
                else if (n is NegationSign && ((NegationSign)n).ReturnChildNode() is ExistentialQuantifier)
                {
                    ExistentialQuantifier quantifier = (ExistentialQuantifier)((NegationSign)n).ReturnChildNode();
                    //add predicates for existing variables
                    foreach (char var in ActiveVariables)
                    {
                        try
                        {
                            ExistentialQuantifier newQuantifier = (ExistentialQuantifier)quantifier.Copy().ReplaceObjectVariableNewNode(quantifier.Variable, var);
                            if (quantifier != null) nodes.Add(new NegationSign(newQuantifier.Proposition));
                        }
                        catch (Exception ex) { DirectMessage.ShowError(ex.Message); }
                    }
                }
                else continue;
            }
            if (nodes.Count > 0 && !nodes.IsSubsetOf(propositions))
            {
                nodes.UnionWith(propositions);
                leftNode = new STElement(nodes, ActiveVariables, rule);
                SimplifyChild(leftNode);
                return true;
            }
            return false;
        }

        private void SimplifyChild(STElement left)
        {
            if (!leftNode.ExistsContradiction()) leftNode.Simplify();
        }

        private void SimplifyChilds(STElement left, STElement right)
        {
            if (!leftNode.ExistsContradiction()) leftNode.Simplify();
            if (!rightNode.ExistsContradiction()) rightNode.Simplify();
        }

        private List<char> AddNewVariable()
        {
            if (ActiveVariables.Count != 0)
            {
                List<char> temp = new List<char>(ActiveVariables);
                char oldLetter = ActiveVariables[ActiveVariables.Count - 1];
                temp.Add(++oldLetter);
                return temp;
            }
            return new List<char>() { 'a' };
        }
    }
}

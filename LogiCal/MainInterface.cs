using System;
using System.Data;
using System.Windows.Forms;

namespace LogiCal
{
    public partial class MainInterface : Form
    {
        private Parser parser;
        private Node n;
        private GraphForm graphForm;
        private ContextMenu cm;
        private STBinaryTreeDrawer STBinaryTreeDrawer;
        public MainInterface()
        {
            InitializeComponent();
            parser = new Parser();
            tbInfix.Click += TextBoxOnClick;
            tbPrefix.Click += TextBoxOnClick;
            tbVariables.Click += TextBoxOnClick;
            tbHexHash.Click += TextBoxOnClick;
            tbDNFPrefix.Click += TextBoxOnClick;
            tbSimplifiedDNFPrefix.Click += TextBoxOnClick;
            tbNANDPrefix.Click += TextBoxOnClick;

            //Adding context menu for parsing
            cm = new ContextMenu();
            tbPrefix.ContextMenu = tbDNFPrefix.ContextMenu = tbSimplifiedDNFPrefix.ContextMenu = tbNANDPrefix.ContextMenu = cm;
            cm.MenuItems.Add("Parse", new EventHandler(btnParse_Click));
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            try
            {
                if (sender is MenuItem)
                {
                    string prop = ((ContextMenu)((MenuItem)sender).Parent).SourceControl.Text;
                    tbInput.Text = prop;
                    n = parser.ParseExpression(prop);
                }
                else n = parser.ParseExpression(tbInput.Text);
                if (n != null)
                {
                    lbInfo.Items.Clear();
                    tbPrefix.Text = n.ToPrefixString();
                    tbInfix.Text = n.ToString();
                    GenerateVariableString();
                    if (IsProposition()) ShowTruthTable();
                    ShowST();
                }
            }
            catch (Exception ex)
            {
                DirectMessage.ShowError(ex.Message);
            }
        }

        private void ShowST()
        {
            ST st = new ST(n);
            if (st.IsTautology)
            {
                lblIsTautology.Text = "Tautology";
                lblIsTautology.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblIsTautology.Text = "Not a tautology";
                lblIsTautology.ForeColor = System.Drawing.Color.Red;
            }
            STBinaryTreeDrawer = new STBinaryTreeDrawer(st);
        }

        private void GenerateVariableString()
        {
            string vars = "";
            foreach (char c in parser.Variables)
            {
                vars += c;
                if (c != parser.Variables[parser.Variables.Length - 1]) vars += ", ";
            }
            tbVariables.Text = vars;
        }

        private void btnShowGraph_Click(object sender, EventArgs e)
        {
            if (n != null)
            {
                FormCollection fc = Application.OpenForms;
                foreach (Form frm in fc)
                {
                    if (frm is GraphForm)
                    {
                        graphForm = (GraphForm)frm;
                        graphForm.Focus();
                    }
                }
                if (graphForm != null)
                {
                    graphForm.Close();
                }
                graphForm = new GraphForm(n);
                graphForm.Show();
            }
        }

        private void ShowTruthTable()
        {
            TruthTable tt = new TruthTable(parser.Variables, n);
            lbTruthTable.Items.Clear();
            foreach (string row in tt.RowsString)
            {
                lbTruthTable.Items.Add(row);
            }
            tbBinHash.Text = tt.BinHashValue;
            tbHexHash.Text = tt.HexHashValue;

            lbInfo.Items.Add("Normal hex: " + tt.HexHashValue);
            Node nandifiedExpression = tt.Proposition.Nandify();
            TruthTable nandifiedTruthTable = new TruthTable(parser.Variables, nandifiedExpression);
            lbInfo.Items.Add("Nandified hex: " + nandifiedTruthTable.HexHashValue);

            tbNANDPrefix.Text = nandifiedExpression.ToPrefixString();
            tbNANDInfix.Text = nandifiedExpression.ToString();
            ShowSimplifiedTruthTable(tt);
            ShowTruthTableDNF(tt, tt.Simplified);
        }

        private void ShowSimplifiedTruthTable(TruthTable tt)
        {
            lbSimplifiedTruthTable.Items.Clear();
            foreach (string row in tt.Simplified.RowsString)
            {
                lbSimplifiedTruthTable.Items.Add(row);
            }
            tbBinHashSimplified.Text = tt.Simplified.BinHashValue;
            tbHexHashSimplified.Text = tt.Simplified.HexHashValue;

            TruthTable simplifiedNandifiedTruthTable = new TruthTable(parser.Variables, tt.Simplified.Proposition.Nandify());
            lbInfo.Items.Add("NAND simplified hex: " + simplifiedNandifiedTruthTable.HexHashValue);
        }

        private void ShowTruthTableDNF(TruthTable original, TruthTable simplified)
        {
            Node originalDNF = original.CreateDNF();
            if (originalDNF != null)
            {
                tbDNFPrefix.Text = originalDNF.ToPrefixString();
                tbDNFInfix.Text = originalDNF.ToString();

                TruthTable dnfTruthTable = new TruthTable(parser.Variables, originalDNF);
                lbInfo.Items.Add("Normal DNF hex: " + dnfTruthTable.HexHashValue);
            }
            Node simplifiedDNF = simplified.CreateDNF();
            if (simplifiedDNF != null)
            {
                tbSimplifiedDNFPrefix.Text = simplifiedDNF.ToPrefixString();
                tbSimplifiedDNFInfix.Text = simplifiedDNF.ToString();

                TruthTable dnfSimplifiedTruthTable = new TruthTable(parser.Variables, simplifiedDNF);
                lbInfo.Items.Add("Simplified DNF hex: " + dnfSimplifiedTruthTable.HexHashValue);
            }
        }

        private void TextBoxOnClick(object sender, EventArgs eventArgs)
        {
            var textBox = (TextBox)sender;
            textBox.SelectAll();
            textBox.Focus();
        }

        private void btnShowST_Click(object sender, EventArgs e)
        {
            if (STBinaryTreeDrawer != null) STBinaryTreeDrawer.GenerateBinaryTreeGraph("st-binary-tree");
        }

        private bool IsProposition()
        {
            if (parser.IsProposition)
            {
                lblIsProposition.Text = "Proposition";
                return true;
            }
            else
            {
                lblIsProposition.Text = "Predicate logic";
                lbTruthTable.Items.Clear();
                lbSimplifiedTruthTable.Items.Clear();
                tbBinHash.Text = tbBinHashSimplified.Text = tbDNFInfix.Text = tbDNFPrefix.Text = tbSimplifiedDNFInfix.Text = tbSimplifiedDNFPrefix.Text
                    = tbHexHash.Text = tbHexHashSimplified.Text = tbNANDInfix.Text = tbNANDPrefix.Text = "";
                return false;
            }
        }
    }
}

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
        public MainInterface()
        {
            InitializeComponent();
            parser = new Parser();
            tbInfix.Click += TextBoxOnClick;
            tbVariables.Click += TextBoxOnClick;
            tbHexHash.Click += TextBoxOnClick;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                n = parser.ParseExpression(tbInput.Text);
                tbInfix.Text = n.ToString();
                GenerateVariableString();
                ShowTruthTable();
            }
            catch (Exception ex)
            {
                DirectMessage.ShowError(ex.Message);
            }
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
            tbHexHash.Text = tt.HashValue;
            ShowSimplifiedTruthTable(tt);
        }

        private void ShowSimplifiedTruthTable(TruthTable tt)
        {
            lbSimplifiedTruthTable.Items.Clear();
            foreach (string row in tt.Simplified.RowsString)
            {
                lbSimplifiedTruthTable.Items.Add(row);
            }
            tbHexHashSimplified.Text = tt.Simplified.HashValue;
        }

        private void TextBoxOnClick(object sender, EventArgs eventArgs)
        {
            var textBox = (TextBox)sender;
            textBox.SelectAll();
            textBox.Focus();
        }
    }
}

namespace LogiCal
{
    partial class MainInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tbVariables = new System.Windows.Forms.TextBox();
            this.tbInfix = new System.Windows.Forms.TextBox();
            this.lblVariables = new System.Windows.Forms.Label();
            this.lblInfix = new System.Windows.Forms.Label();
            this.btnShowGraph = new System.Windows.Forms.Button();
            this.lbTruthTable = new System.Windows.Forms.ListBox();
            this.tbHexHash = new System.Windows.Forms.TextBox();
            this.lblHexHash = new System.Windows.Forms.Label();
            this.lbSimplifiedTruthTable = new System.Windows.Forms.ListBox();
            this.lblHexHashSimplified = new System.Windows.Forms.Label();
            this.tbHexHashSimplified = new System.Windows.Forms.TextBox();
            this.lblTruthTable = new System.Windows.Forms.Label();
            this.lblSimplifiedTruthTable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.Location = new System.Drawing.Point(12, 12);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(614, 20);
            this.tbInput.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.Location = new System.Drawing.Point(632, 10);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tbVariables
            // 
            this.tbVariables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVariables.BackColor = System.Drawing.SystemColors.Window;
            this.tbVariables.Location = new System.Drawing.Point(73, 74);
            this.tbVariables.Name = "tbVariables";
            this.tbVariables.ReadOnly = true;
            this.tbVariables.Size = new System.Drawing.Size(715, 20);
            this.tbVariables.TabIndex = 3;
            // 
            // tbInfix
            // 
            this.tbInfix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInfix.BackColor = System.Drawing.SystemColors.Window;
            this.tbInfix.Location = new System.Drawing.Point(73, 43);
            this.tbInfix.Name = "tbInfix";
            this.tbInfix.ReadOnly = true;
            this.tbInfix.Size = new System.Drawing.Size(715, 20);
            this.tbInfix.TabIndex = 4;
            // 
            // lblVariables
            // 
            this.lblVariables.AutoSize = true;
            this.lblVariables.Location = new System.Drawing.Point(12, 77);
            this.lblVariables.Name = "lblVariables";
            this.lblVariables.Size = new System.Drawing.Size(53, 13);
            this.lblVariables.TabIndex = 5;
            this.lblVariables.Text = "Variables:";
            // 
            // lblInfix
            // 
            this.lblInfix.AutoSize = true;
            this.lblInfix.Location = new System.Drawing.Point(12, 46);
            this.lblInfix.Name = "lblInfix";
            this.lblInfix.Size = new System.Drawing.Size(29, 13);
            this.lblInfix.TabIndex = 6;
            this.lblInfix.Text = "Infix:";
            // 
            // btnShowGraph
            // 
            this.btnShowGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowGraph.Location = new System.Drawing.Point(713, 10);
            this.btnShowGraph.Name = "btnShowGraph";
            this.btnShowGraph.Size = new System.Drawing.Size(75, 23);
            this.btnShowGraph.TabIndex = 7;
            this.btnShowGraph.Text = "Graph";
            this.btnShowGraph.UseVisualStyleBackColor = true;
            this.btnShowGraph.Click += new System.EventHandler(this.btnShowGraph_Click);
            // 
            // lbTruthTable
            // 
            this.lbTruthTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTruthTable.FormattingEnabled = true;
            this.lbTruthTable.HorizontalScrollbar = true;
            this.lbTruthTable.Location = new System.Drawing.Point(461, 125);
            this.lbTruthTable.Name = "lbTruthTable";
            this.lbTruthTable.Size = new System.Drawing.Size(156, 303);
            this.lbTruthTable.TabIndex = 8;
            // 
            // tbHexHash
            // 
            this.tbHexHash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHexHash.BackColor = System.Drawing.SystemColors.Window;
            this.tbHexHash.Location = new System.Drawing.Point(519, 440);
            this.tbHexHash.Name = "tbHexHash";
            this.tbHexHash.ReadOnly = true;
            this.tbHexHash.Size = new System.Drawing.Size(98, 20);
            this.tbHexHash.TabIndex = 9;
            // 
            // lblHexHash
            // 
            this.lblHexHash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHexHash.AutoSize = true;
            this.lblHexHash.Location = new System.Drawing.Point(458, 443);
            this.lblHexHash.Name = "lblHexHash";
            this.lblHexHash.Size = new System.Drawing.Size(55, 13);
            this.lblHexHash.TabIndex = 10;
            this.lblHexHash.Text = "Hex hash:";
            // 
            // lbSimplifiedTruthTable
            // 
            this.lbSimplifiedTruthTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSimplifiedTruthTable.FormattingEnabled = true;
            this.lbSimplifiedTruthTable.Location = new System.Drawing.Point(632, 125);
            this.lbSimplifiedTruthTable.Name = "lbSimplifiedTruthTable";
            this.lbSimplifiedTruthTable.Size = new System.Drawing.Size(156, 303);
            this.lbSimplifiedTruthTable.TabIndex = 11;
            // 
            // lblHexHashSimplified
            // 
            this.lblHexHashSimplified.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHexHashSimplified.AutoSize = true;
            this.lblHexHashSimplified.Location = new System.Drawing.Point(629, 443);
            this.lblHexHashSimplified.Name = "lblHexHashSimplified";
            this.lblHexHashSimplified.Size = new System.Drawing.Size(55, 13);
            this.lblHexHashSimplified.TabIndex = 13;
            this.lblHexHashSimplified.Text = "Hex hash:";
            // 
            // tbHexHashSimplified
            // 
            this.tbHexHashSimplified.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHexHashSimplified.BackColor = System.Drawing.SystemColors.Window;
            this.tbHexHashSimplified.Location = new System.Drawing.Point(690, 440);
            this.tbHexHashSimplified.Name = "tbHexHashSimplified";
            this.tbHexHashSimplified.ReadOnly = true;
            this.tbHexHashSimplified.Size = new System.Drawing.Size(98, 20);
            this.tbHexHashSimplified.TabIndex = 12;
            // 
            // lblTruthTable
            // 
            this.lblTruthTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTruthTable.AutoSize = true;
            this.lblTruthTable.Location = new System.Drawing.Point(458, 109);
            this.lblTruthTable.Name = "lblTruthTable";
            this.lblTruthTable.Size = new System.Drawing.Size(61, 13);
            this.lblTruthTable.TabIndex = 14;
            this.lblTruthTable.Text = "Truth table:";
            // 
            // lblSimplifiedTruthTable
            // 
            this.lblSimplifiedTruthTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSimplifiedTruthTable.AutoSize = true;
            this.lblSimplifiedTruthTable.Location = new System.Drawing.Point(629, 109);
            this.lblSimplifiedTruthTable.Name = "lblSimplifiedTruthTable";
            this.lblSimplifiedTruthTable.Size = new System.Drawing.Size(104, 13);
            this.lblSimplifiedTruthTable.TabIndex = 15;
            this.lblSimplifiedTruthTable.Text = "Simplified truth table:";
            // 
            // MainInterface
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.lblSimplifiedTruthTable);
            this.Controls.Add(this.lblTruthTable);
            this.Controls.Add(this.lblHexHashSimplified);
            this.Controls.Add(this.tbHexHashSimplified);
            this.Controls.Add(this.lbSimplifiedTruthTable);
            this.Controls.Add(this.lblHexHash);
            this.Controls.Add(this.tbHexHash);
            this.Controls.Add(this.lbTruthTable);
            this.Controls.Add(this.btnShowGraph);
            this.Controls.Add(this.lblInfix);
            this.Controls.Add(this.lblVariables);
            this.Controls.Add(this.tbInfix);
            this.Controls.Add(this.tbVariables);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbInput);
            this.Name = "MainInterface";
            this.Text = "LogiCal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tbVariables;
        private System.Windows.Forms.TextBox tbInfix;
        private System.Windows.Forms.Label lblVariables;
        private System.Windows.Forms.Label lblInfix;
        private System.Windows.Forms.Button btnShowGraph;
        private System.Windows.Forms.ListBox lbTruthTable;
        private System.Windows.Forms.TextBox tbHexHash;
        private System.Windows.Forms.Label lblHexHash;
        private System.Windows.Forms.ListBox lbSimplifiedTruthTable;
        private System.Windows.Forms.Label lblHexHashSimplified;
        private System.Windows.Forms.TextBox tbHexHashSimplified;
        private System.Windows.Forms.Label lblTruthTable;
        private System.Windows.Forms.Label lblSimplifiedTruthTable;
    }
}


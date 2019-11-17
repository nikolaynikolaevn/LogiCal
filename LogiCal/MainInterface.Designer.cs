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
            this.btnParse = new System.Windows.Forms.Button();
            this.tbVariables = new System.Windows.Forms.TextBox();
            this.lblVariables = new System.Windows.Forms.Label();
            this.btnShowGraph = new System.Windows.Forms.Button();
            this.lbTruthTable = new System.Windows.Forms.ListBox();
            this.tbHexHash = new System.Windows.Forms.TextBox();
            this.lblHexHash = new System.Windows.Forms.Label();
            this.lbSimplifiedTruthTable = new System.Windows.Forms.ListBox();
            this.lblHexHashSimplified = new System.Windows.Forms.Label();
            this.tbHexHashSimplified = new System.Windows.Forms.TextBox();
            this.lblTruthTable = new System.Windows.Forms.Label();
            this.lblSimplifiedTruthTable = new System.Windows.Forms.Label();
            this.lblDNFPrefix = new System.Windows.Forms.Label();
            this.tbDNFPrefix = new System.Windows.Forms.TextBox();
            this.lblSimplifiedDNFPrefix = new System.Windows.Forms.Label();
            this.tbSimplifiedDNFPrefix = new System.Windows.Forms.TextBox();
            this.lblNANDPrefix = new System.Windows.Forms.Label();
            this.tbNANDPrefix = new System.Windows.Forms.TextBox();
            this.lblBinHashSimplified = new System.Windows.Forms.Label();
            this.tbBinHashSimplified = new System.Windows.Forms.TextBox();
            this.lblBinHash = new System.Windows.Forms.Label();
            this.tbBinHash = new System.Windows.Forms.TextBox();
            this.lblPrefix = new System.Windows.Forms.Label();
            this.tbPrefix = new System.Windows.Forms.TextBox();
            this.tbInfix = new System.Windows.Forms.TextBox();
            this.lblInfix = new System.Windows.Forms.Label();
            this.lblSimplifiedDNFInfix = new System.Windows.Forms.Label();
            this.tbSimplifiedDNFInfix = new System.Windows.Forms.TextBox();
            this.lblDNFInfix = new System.Windows.Forms.Label();
            this.tbDNFInfix = new System.Windows.Forms.TextBox();
            this.lblNANDInfix = new System.Windows.Forms.Label();
            this.tbNANDInfix = new System.Windows.Forms.TextBox();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.lblIsTautology = new System.Windows.Forms.Label();
            this.btnShowST = new System.Windows.Forms.Button();
            this.lblIsProposition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.Location = new System.Drawing.Point(12, 12);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(696, 20);
            this.tbInput.TabIndex = 1;
            // 
            // btnParse
            // 
            this.btnParse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParse.Location = new System.Drawing.Point(714, 10);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(75, 23);
            this.btnParse.TabIndex = 2;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // tbVariables
            // 
            this.tbVariables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVariables.BackColor = System.Drawing.SystemColors.Window;
            this.tbVariables.Location = new System.Drawing.Point(80, 42);
            this.tbVariables.Name = "tbVariables";
            this.tbVariables.ReadOnly = true;
            this.tbVariables.Size = new System.Drawing.Size(317, 20);
            this.tbVariables.TabIndex = 3;
            // 
            // lblVariables
            // 
            this.lblVariables.AutoSize = true;
            this.lblVariables.Location = new System.Drawing.Point(9, 45);
            this.lblVariables.Name = "lblVariables";
            this.lblVariables.Size = new System.Drawing.Size(53, 13);
            this.lblVariables.TabIndex = 5;
            this.lblVariables.Text = "Variables:";
            // 
            // btnShowGraph
            // 
            this.btnShowGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowGraph.Location = new System.Drawing.Point(714, 40);
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
            this.lbTruthTable.Location = new System.Drawing.Point(12, 196);
            this.lbTruthTable.Name = "lbTruthTable";
            this.lbTruthTable.Size = new System.Drawing.Size(310, 303);
            this.lbTruthTable.TabIndex = 8;
            // 
            // tbHexHash
            // 
            this.tbHexHash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHexHash.BackColor = System.Drawing.SystemColors.Window;
            this.tbHexHash.Location = new System.Drawing.Point(80, 540);
            this.tbHexHash.Name = "tbHexHash";
            this.tbHexHash.ReadOnly = true;
            this.tbHexHash.Size = new System.Drawing.Size(242, 20);
            this.tbHexHash.TabIndex = 9;
            // 
            // lblHexHash
            // 
            this.lblHexHash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHexHash.AutoSize = true;
            this.lblHexHash.Location = new System.Drawing.Point(9, 543);
            this.lblHexHash.Name = "lblHexHash";
            this.lblHexHash.Size = new System.Drawing.Size(55, 13);
            this.lblHexHash.TabIndex = 10;
            this.lblHexHash.Text = "Hex hash:";
            // 
            // lbSimplifiedTruthTable
            // 
            this.lbSimplifiedTruthTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSimplifiedTruthTable.FormattingEnabled = true;
            this.lbSimplifiedTruthTable.HorizontalScrollbar = true;
            this.lbSimplifiedTruthTable.Location = new System.Drawing.Point(331, 196);
            this.lbSimplifiedTruthTable.Name = "lbSimplifiedTruthTable";
            this.lbSimplifiedTruthTable.Size = new System.Drawing.Size(310, 303);
            this.lbSimplifiedTruthTable.TabIndex = 11;
            // 
            // lblHexHashSimplified
            // 
            this.lblHexHashSimplified.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHexHashSimplified.AutoSize = true;
            this.lblHexHashSimplified.Location = new System.Drawing.Point(328, 543);
            this.lblHexHashSimplified.Name = "lblHexHashSimplified";
            this.lblHexHashSimplified.Size = new System.Drawing.Size(55, 13);
            this.lblHexHashSimplified.TabIndex = 13;
            this.lblHexHashSimplified.Text = "Hex hash:";
            // 
            // tbHexHashSimplified
            // 
            this.tbHexHashSimplified.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHexHashSimplified.BackColor = System.Drawing.SystemColors.Window;
            this.tbHexHashSimplified.Location = new System.Drawing.Point(398, 540);
            this.tbHexHashSimplified.Name = "tbHexHashSimplified";
            this.tbHexHashSimplified.ReadOnly = true;
            this.tbHexHashSimplified.Size = new System.Drawing.Size(243, 20);
            this.tbHexHashSimplified.TabIndex = 12;
            // 
            // lblTruthTable
            // 
            this.lblTruthTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTruthTable.AutoSize = true;
            this.lblTruthTable.Location = new System.Drawing.Point(9, 180);
            this.lblTruthTable.Name = "lblTruthTable";
            this.lblTruthTable.Size = new System.Drawing.Size(61, 13);
            this.lblTruthTable.TabIndex = 14;
            this.lblTruthTable.Text = "Truth table:";
            // 
            // lblSimplifiedTruthTable
            // 
            this.lblSimplifiedTruthTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSimplifiedTruthTable.AutoSize = true;
            this.lblSimplifiedTruthTable.Location = new System.Drawing.Point(328, 180);
            this.lblSimplifiedTruthTable.Name = "lblSimplifiedTruthTable";
            this.lblSimplifiedTruthTable.Size = new System.Drawing.Size(104, 13);
            this.lblSimplifiedTruthTable.TabIndex = 15;
            this.lblSimplifiedTruthTable.Text = "Simplified truth table:";
            // 
            // lblDNFPrefix
            // 
            this.lblDNFPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDNFPrefix.AutoSize = true;
            this.lblDNFPrefix.Location = new System.Drawing.Point(9, 573);
            this.lblDNFPrefix.Name = "lblDNFPrefix";
            this.lblDNFPrefix.Size = new System.Drawing.Size(61, 13);
            this.lblDNFPrefix.TabIndex = 21;
            this.lblDNFPrefix.Text = "DNF Prefix:";
            // 
            // tbDNFPrefix
            // 
            this.tbDNFPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDNFPrefix.BackColor = System.Drawing.SystemColors.Window;
            this.tbDNFPrefix.Location = new System.Drawing.Point(80, 570);
            this.tbDNFPrefix.Name = "tbDNFPrefix";
            this.tbDNFPrefix.ReadOnly = true;
            this.tbDNFPrefix.Size = new System.Drawing.Size(242, 20);
            this.tbDNFPrefix.TabIndex = 20;
            // 
            // lblSimplifiedDNFPrefix
            // 
            this.lblSimplifiedDNFPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSimplifiedDNFPrefix.AutoSize = true;
            this.lblSimplifiedDNFPrefix.Location = new System.Drawing.Point(328, 573);
            this.lblSimplifiedDNFPrefix.Name = "lblSimplifiedDNFPrefix";
            this.lblSimplifiedDNFPrefix.Size = new System.Drawing.Size(61, 13);
            this.lblSimplifiedDNFPrefix.TabIndex = 23;
            this.lblSimplifiedDNFPrefix.Text = "DNF Prefix:";
            // 
            // tbSimplifiedDNFPrefix
            // 
            this.tbSimplifiedDNFPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSimplifiedDNFPrefix.BackColor = System.Drawing.SystemColors.Window;
            this.tbSimplifiedDNFPrefix.Location = new System.Drawing.Point(398, 570);
            this.tbSimplifiedDNFPrefix.Name = "tbSimplifiedDNFPrefix";
            this.tbSimplifiedDNFPrefix.ReadOnly = true;
            this.tbSimplifiedDNFPrefix.Size = new System.Drawing.Size(243, 20);
            this.tbSimplifiedDNFPrefix.TabIndex = 22;
            // 
            // lblNANDPrefix
            // 
            this.lblNANDPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNANDPrefix.AutoSize = true;
            this.lblNANDPrefix.Location = new System.Drawing.Point(9, 123);
            this.lblNANDPrefix.Name = "lblNANDPrefix";
            this.lblNANDPrefix.Size = new System.Drawing.Size(70, 13);
            this.lblNANDPrefix.TabIndex = 25;
            this.lblNANDPrefix.Text = "NAND Prefix:";
            // 
            // tbNANDPrefix
            // 
            this.tbNANDPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNANDPrefix.BackColor = System.Drawing.SystemColors.Window;
            this.tbNANDPrefix.Location = new System.Drawing.Point(80, 120);
            this.tbNANDPrefix.Name = "tbNANDPrefix";
            this.tbNANDPrefix.ReadOnly = true;
            this.tbNANDPrefix.Size = new System.Drawing.Size(709, 20);
            this.tbNANDPrefix.TabIndex = 24;
            // 
            // lblBinHashSimplified
            // 
            this.lblBinHashSimplified.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBinHashSimplified.AutoSize = true;
            this.lblBinHashSimplified.Location = new System.Drawing.Point(328, 519);
            this.lblBinHashSimplified.Name = "lblBinHashSimplified";
            this.lblBinHashSimplified.Size = new System.Drawing.Size(65, 13);
            this.lblBinHashSimplified.TabIndex = 31;
            this.lblBinHashSimplified.Text = "Binary hash:";
            // 
            // tbBinHashSimplified
            // 
            this.tbBinHashSimplified.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBinHashSimplified.BackColor = System.Drawing.SystemColors.Window;
            this.tbBinHashSimplified.Location = new System.Drawing.Point(398, 516);
            this.tbBinHashSimplified.Name = "tbBinHashSimplified";
            this.tbBinHashSimplified.ReadOnly = true;
            this.tbBinHashSimplified.Size = new System.Drawing.Size(243, 20);
            this.tbBinHashSimplified.TabIndex = 30;
            // 
            // lblBinHash
            // 
            this.lblBinHash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBinHash.AutoSize = true;
            this.lblBinHash.Location = new System.Drawing.Point(9, 519);
            this.lblBinHash.Name = "lblBinHash";
            this.lblBinHash.Size = new System.Drawing.Size(65, 13);
            this.lblBinHash.TabIndex = 29;
            this.lblBinHash.Text = "Binary hash:";
            // 
            // tbBinHash
            // 
            this.tbBinHash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBinHash.BackColor = System.Drawing.SystemColors.Window;
            this.tbBinHash.Location = new System.Drawing.Point(80, 516);
            this.tbBinHash.Name = "tbBinHash";
            this.tbBinHash.ReadOnly = true;
            this.tbBinHash.Size = new System.Drawing.Size(242, 20);
            this.tbBinHash.TabIndex = 28;
            // 
            // lblPrefix
            // 
            this.lblPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Location = new System.Drawing.Point(9, 71);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(36, 13);
            this.lblPrefix.TabIndex = 33;
            this.lblPrefix.Text = "Prefix:";
            // 
            // tbPrefix
            // 
            this.tbPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPrefix.BackColor = System.Drawing.SystemColors.Window;
            this.tbPrefix.Location = new System.Drawing.Point(80, 68);
            this.tbPrefix.Name = "tbPrefix";
            this.tbPrefix.ReadOnly = true;
            this.tbPrefix.Size = new System.Drawing.Size(709, 20);
            this.tbPrefix.TabIndex = 32;
            // 
            // tbInfix
            // 
            this.tbInfix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInfix.BackColor = System.Drawing.SystemColors.Window;
            this.tbInfix.Location = new System.Drawing.Point(80, 93);
            this.tbInfix.Name = "tbInfix";
            this.tbInfix.ReadOnly = true;
            this.tbInfix.Size = new System.Drawing.Size(709, 20);
            this.tbInfix.TabIndex = 4;
            // 
            // lblInfix
            // 
            this.lblInfix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfix.AutoSize = true;
            this.lblInfix.Location = new System.Drawing.Point(9, 96);
            this.lblInfix.Name = "lblInfix";
            this.lblInfix.Size = new System.Drawing.Size(29, 13);
            this.lblInfix.TabIndex = 6;
            this.lblInfix.Text = "Infix:";
            // 
            // lblSimplifiedDNFInfix
            // 
            this.lblSimplifiedDNFInfix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSimplifiedDNFInfix.AutoSize = true;
            this.lblSimplifiedDNFInfix.Location = new System.Drawing.Point(328, 597);
            this.lblSimplifiedDNFInfix.Name = "lblSimplifiedDNFInfix";
            this.lblSimplifiedDNFInfix.Size = new System.Drawing.Size(54, 13);
            this.lblSimplifiedDNFInfix.TabIndex = 37;
            this.lblSimplifiedDNFInfix.Text = "DNF Infix:";
            // 
            // tbSimplifiedDNFInfix
            // 
            this.tbSimplifiedDNFInfix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSimplifiedDNFInfix.BackColor = System.Drawing.SystemColors.Window;
            this.tbSimplifiedDNFInfix.Location = new System.Drawing.Point(398, 594);
            this.tbSimplifiedDNFInfix.Name = "tbSimplifiedDNFInfix";
            this.tbSimplifiedDNFInfix.ReadOnly = true;
            this.tbSimplifiedDNFInfix.Size = new System.Drawing.Size(243, 20);
            this.tbSimplifiedDNFInfix.TabIndex = 36;
            // 
            // lblDNFInfix
            // 
            this.lblDNFInfix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDNFInfix.AutoSize = true;
            this.lblDNFInfix.Location = new System.Drawing.Point(9, 597);
            this.lblDNFInfix.Name = "lblDNFInfix";
            this.lblDNFInfix.Size = new System.Drawing.Size(54, 13);
            this.lblDNFInfix.TabIndex = 35;
            this.lblDNFInfix.Text = "DNF Infix:";
            // 
            // tbDNFInfix
            // 
            this.tbDNFInfix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDNFInfix.BackColor = System.Drawing.SystemColors.Window;
            this.tbDNFInfix.Location = new System.Drawing.Point(80, 594);
            this.tbDNFInfix.Name = "tbDNFInfix";
            this.tbDNFInfix.ReadOnly = true;
            this.tbDNFInfix.Size = new System.Drawing.Size(242, 20);
            this.tbDNFInfix.TabIndex = 34;
            // 
            // lblNANDInfix
            // 
            this.lblNANDInfix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNANDInfix.AutoSize = true;
            this.lblNANDInfix.Location = new System.Drawing.Point(9, 149);
            this.lblNANDInfix.Name = "lblNANDInfix";
            this.lblNANDInfix.Size = new System.Drawing.Size(63, 13);
            this.lblNANDInfix.TabIndex = 39;
            this.lblNANDInfix.Text = "NAND Infix:";
            // 
            // tbNANDInfix
            // 
            this.tbNANDInfix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNANDInfix.BackColor = System.Drawing.SystemColors.Window;
            this.tbNANDInfix.Location = new System.Drawing.Point(80, 146);
            this.tbNANDInfix.Name = "tbNANDInfix";
            this.tbNANDInfix.ReadOnly = true;
            this.tbNANDInfix.Size = new System.Drawing.Size(709, 20);
            this.tbNANDInfix.TabIndex = 38;
            // 
            // lbInfo
            // 
            this.lbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.Location = new System.Drawing.Point(657, 196);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(132, 420);
            this.lbInfo.TabIndex = 40;
            // 
            // lblIsTautology
            // 
            this.lblIsTautology.AutoSize = true;
            this.lblIsTautology.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIsTautology.Location = new System.Drawing.Point(493, 45);
            this.lblIsTautology.Name = "lblIsTautology";
            this.lblIsTautology.Size = new System.Drawing.Size(0, 13);
            this.lblIsTautology.TabIndex = 41;
            // 
            // btnShowST
            // 
            this.btnShowST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowST.Location = new System.Drawing.Point(604, 40);
            this.btnShowST.Name = "btnShowST";
            this.btnShowST.Size = new System.Drawing.Size(104, 23);
            this.btnShowST.TabIndex = 42;
            this.btnShowST.Text = "Semantic Tableau";
            this.btnShowST.UseVisualStyleBackColor = true;
            this.btnShowST.Click += new System.EventHandler(this.btnShowST_Click);
            // 
            // lblIsProposition
            // 
            this.lblIsProposition.AutoSize = true;
            this.lblIsProposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIsProposition.Location = new System.Drawing.Point(403, 45);
            this.lblIsProposition.Name = "lblIsProposition";
            this.lblIsProposition.Size = new System.Drawing.Size(0, 13);
            this.lblIsProposition.TabIndex = 43;
            // 
            // MainInterface
            // 
            this.AcceptButton = this.btnParse;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 631);
            this.Controls.Add(this.lblIsProposition);
            this.Controls.Add(this.btnShowST);
            this.Controls.Add(this.lblIsTautology);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.lblNANDInfix);
            this.Controls.Add(this.tbNANDInfix);
            this.Controls.Add(this.lblSimplifiedDNFInfix);
            this.Controls.Add(this.tbSimplifiedDNFInfix);
            this.Controls.Add(this.lblDNFInfix);
            this.Controls.Add(this.tbDNFInfix);
            this.Controls.Add(this.lblPrefix);
            this.Controls.Add(this.tbPrefix);
            this.Controls.Add(this.lblBinHashSimplified);
            this.Controls.Add(this.tbBinHashSimplified);
            this.Controls.Add(this.lblBinHash);
            this.Controls.Add(this.tbBinHash);
            this.Controls.Add(this.lblNANDPrefix);
            this.Controls.Add(this.tbNANDPrefix);
            this.Controls.Add(this.lblSimplifiedDNFPrefix);
            this.Controls.Add(this.tbSimplifiedDNFPrefix);
            this.Controls.Add(this.lblDNFPrefix);
            this.Controls.Add(this.tbDNFPrefix);
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
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.tbInput);
            this.Name = "MainInterface";
            this.Text = "LogiCal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.TextBox tbVariables;
        private System.Windows.Forms.Label lblVariables;
        private System.Windows.Forms.Button btnShowGraph;
        private System.Windows.Forms.ListBox lbTruthTable;
        private System.Windows.Forms.TextBox tbHexHash;
        private System.Windows.Forms.Label lblHexHash;
        private System.Windows.Forms.ListBox lbSimplifiedTruthTable;
        private System.Windows.Forms.Label lblHexHashSimplified;
        private System.Windows.Forms.TextBox tbHexHashSimplified;
        private System.Windows.Forms.Label lblTruthTable;
        private System.Windows.Forms.Label lblSimplifiedTruthTable;
        private System.Windows.Forms.Label lblDNFPrefix;
        private System.Windows.Forms.TextBox tbDNFPrefix;
        private System.Windows.Forms.Label lblSimplifiedDNFPrefix;
        private System.Windows.Forms.TextBox tbSimplifiedDNFPrefix;
        private System.Windows.Forms.Label lblNANDPrefix;
        private System.Windows.Forms.TextBox tbNANDPrefix;
        private System.Windows.Forms.Label lblBinHashSimplified;
        private System.Windows.Forms.TextBox tbBinHashSimplified;
        private System.Windows.Forms.Label lblBinHash;
        private System.Windows.Forms.TextBox tbBinHash;
        private System.Windows.Forms.Label lblPrefix;
        private System.Windows.Forms.TextBox tbPrefix;
        private System.Windows.Forms.TextBox tbInfix;
        private System.Windows.Forms.Label lblInfix;
        private System.Windows.Forms.Label lblSimplifiedDNFInfix;
        private System.Windows.Forms.TextBox tbSimplifiedDNFInfix;
        private System.Windows.Forms.Label lblDNFInfix;
        private System.Windows.Forms.TextBox tbDNFInfix;
        private System.Windows.Forms.Label lblNANDInfix;
        private System.Windows.Forms.TextBox tbNANDInfix;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.Label lblIsTautology;
        private System.Windows.Forms.Button btnShowST;
        private System.Windows.Forms.Label lblIsProposition;
    }
}


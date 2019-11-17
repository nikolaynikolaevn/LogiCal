namespace LogiCal
{
    partial class GraphForm
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
            this.pictureBoxBinaryTree = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBinaryTree)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBinaryTree
            // 
            this.pictureBoxBinaryTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBinaryTree.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxBinaryTree.Name = "pictureBoxBinaryTree";
            this.pictureBoxBinaryTree.Size = new System.Drawing.Size(388, 299);
            this.pictureBoxBinaryTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBinaryTree.TabIndex = 0;
            this.pictureBoxBinaryTree.TabStop = false;
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 323);
            this.Controls.Add(this.pictureBoxBinaryTree);
            this.Name = "GraphForm";
            this.Text = "Graph";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBinaryTree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBinaryTree;
    }
}
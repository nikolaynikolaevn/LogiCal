using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogiCal
{
    internal partial class GraphForm : Form
    {
        private Node root;
        private BinaryTreeDrawer binaryTreeDrawer;
        internal GraphForm(Node root)
        {
            InitializeComponent();
            this.root = root;
            binaryTreeDrawer = new BinaryTreeDrawer(root);
            pictureBoxBinaryTree.ImageLocation = binaryTreeDrawer.GenerateBinaryTreeGraph("binary-tree");

            ContextMenu cm = new ContextMenu();
            pictureBoxBinaryTree.ContextMenu = cm;
            cm.MenuItems.Add("Export", new EventHandler(ExportToPNG));
        }

        public void ExportToPNG(object sender, System.EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Images| *.png";
                sfd.DefaultExt = "png";
                sfd.FileName = "binary-tree-graph_" + PathValidator.ValidatePath(root.ToString());
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bitmap = new Bitmap(pictureBoxBinaryTree.ClientSize.Width, pictureBoxBinaryTree.ClientSize.Height);
                    pictureBoxBinaryTree.DrawToBitmap(bitmap, pictureBoxBinaryTree.ClientRectangle);
                    bitmap.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
        }
    }
}

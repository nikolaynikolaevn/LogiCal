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
        Node root;
        BinaryTreeDrawer binaryTreeDrawer;
        internal GraphForm(Node root)
        {
            InitializeComponent();
            this.root = root;
            GenerateImage(root, "binary-tree");

            ContextMenu cm = new ContextMenu();
            pictureBoxBinaryTree.ContextMenu = cm;
            cm.MenuItems.Add("Export", new EventHandler(ExportToPNG));
        }

        private void GenerateImage(Node n, string name)
        {
            binaryTreeDrawer = new BinaryTreeDrawer(n);
            pictureBoxBinaryTree.ImageLocation = binaryTreeDrawer.GenerateBinaryTreeGraph(name);
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

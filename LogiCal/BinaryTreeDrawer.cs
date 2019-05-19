using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace LogiCal
{
    sealed class BinaryTreeDrawer
    {
        Node startNode;
        public delegate void GenerateCompleted();
        public event GenerateCompleted OnGenerate;
        public BinaryTreeDrawer(Node startNode)
        {
            this.startNode = startNode;
        }
        public string GenerateBinaryTreeGraph(string name)
        {
            string imageFileName = name + ".png";
            string configFileName = name + ".dot";
            GenerateBinaryTreeConfigFile(configFileName);
            Process dot = new Process();
            dot.StartInfo.FileName = "dot.exe";
            dot.StartInfo.Arguments = "-Tpng -o" + imageFileName + " " + configFileName;
            dot.Start();
            dot.WaitForExit();
            OnGenerate?.Invoke();
            return imageFileName;

        }
        private void GenerateBinaryTreeConfigFile(string fileName)
        {
            FileStream fs;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);

                sw.WriteLine("graph binaryTree {");
                sw.WriteLine("   node [ fontname = \"Arial\" ]");
                sw.WriteLine(startNode.GenerateBinaryTree());
                sw.WriteLine("}");
            }
            catch (IOException)
            {
                MessageBox.Show("Error creating binary tree config file.");
            }
            finally
            {
                if (sw != null) sw.Close();
            }
        }
    }
}

using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace LogiCal
{
    sealed class STBinaryTreeDrawer
    {
        private ST st;
        public delegate void GenerateCompleted();
        public event GenerateCompleted OnGenerate;
        public STBinaryTreeDrawer(ST st)
        {
            this.st = st;
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
            Process.Start(imageFileName);
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
                sw.WriteLine("   node [ fontname = \"Arial\" shape=box ]");
                sw.WriteLine(st.Root.GenerateBinaryTree());
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

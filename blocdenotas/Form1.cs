using blocdenotas.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace blocdenotas
{
    public partial class Form1 : Form 
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(directory);
            treeView1.Nodes.Add(ReadFiles(directoryInfo));
            
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
            FormNew xd = new FormNew();
            xd.Show();
            Hide();
        }
        //public string directory =  @"C:\\Users\\\JADPA23\\Desktop";
        public string directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)); /*"xd"*/
        public TreeNode ReadFiles(DirectoryInfo directoryInfo)
        {

            TreeNode treeNode = new TreeNode(directoryInfo.Name);
            foreach (var item in directoryInfo.GetDirectories())
            {
                treeNode.Nodes.Add(ReadFiles(item));
            }
            foreach (var item in directoryInfo.GetFiles())
            {
                treeNode.Nodes.Add(new TreeNode(item.Name));
            }
            return treeNode;
        }

       public string DirectoryOpen = string.Empty;
        public string DirectoryName = string.Empty;
    private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Documento de texto| *.txt";
            openFileDialog1.Title = "Abrir...";
            openFileDialog1.FileName = "Sin tulo 1";

            FormNew frmrich = new FormNew();
            Form1 ayuda = new Form1();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string strfilename = openFileDialog1.FileName;
                string filetext = File.ReadAllText(strfilename);
                DirectoryName = openFileDialog1.SafeFileName;
                //StreamReader leer = new StreamReader(openFileDialog1.FileName);
                frmrich.richTextBox1.Text = filetext;
                DirectoryOpen = strfilename;
                DirectoryName = filetext;
                Hide();
                frmrich.Show();
            }

            
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
        
            FormNew xdxd = new FormNew();
            string directoryxd = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), treeView1.SelectedNode.FullPath);

            StreamReader owo = new StreamReader(directoryxd);
            xdxd.richTextBox1.Text = owo.ReadToEnd();
            xdxd.Show();
            Hide();
        }

        private void EXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

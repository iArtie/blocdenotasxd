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
            
        }
        string directory = @"C:\\Users\\BitZ\\Desktop";

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


    private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Documento de texto| *.txt";
            openFileDialog1.Title = "Abrir...";
            openFileDialog1.FileName = "Sin tulo 1";
         
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string strfilename = openFileDialog1.FileName;
                string filetext = File.ReadAllText(strfilename);
                FormNew frmrich = new FormNew();
                //StreamReader leer = new StreamReader(openFileDialog1.FileName);
                frmrich.richTextBox1.Text = filetext;
                    frmrich.Show();
              
                    //leer.Close();

                }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
        
            FormNew xdxd = new FormNew();
            string directoryxd = "C:\\Users\\BitZ\\" + treeView1.SelectedNode.FullPath;

            StreamReader owo = new StreamReader(directoryxd);
            xdxd.richTextBox1.Text = owo.ReadToEnd();
            xdxd.Show();
           
        }

        private void EXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

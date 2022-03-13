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

namespace blocdenotas.Forms
{
    public partial class FormNew : Form 
    {
        string directory = @"C:\\Users\\BitZ\\Desktop";
        Form1 qwq = new Form1();
        string Files = Application.StartupPath + @"\Contenedor";
        string Archive = @"ArchivoTexto.txt";
        public FormNew()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Documento de Texto| *.txt";
            saveFileDialog1.Title = "Sin titulo";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //string Ubicacion = Files + Archive;
                
                StreamWriter guardado = new StreamWriter(saveFileDialog1.FileName);
                foreach (object linea in richTextBox1.Lines)
                {
                    guardado.WriteLine(linea);
                }
                guardado.Close();
            }
            DirectoryInfo directoryInfo = new DirectoryInfo(directory);
            qwq.treeView1.Refresh();
            qwq.Show();
            Close();
        }
    }
}

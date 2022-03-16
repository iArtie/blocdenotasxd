using Infraestructura.Repository;
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


        IRepository uwu = new IRepository();
        Form1 qwq = new Form1();
        public FormNew()
        {
            InitializeComponent();
        }
        
        
        private void Button1_Click(object sender, EventArgs e)
        {
            
            saveFileDialog1.Filter = "Documento de Texto| *.txt";
            saveFileDialog1.Title = "Sin titulo";
            qwq.Owner = this;
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
            DirectoryInfo directoryInfo = new DirectoryInfo(uwu.directory);

            qwq.Show();
            Hide();
        }
        
        
        private void FormNew_Load(object sender, EventArgs e)
        {
            
        }
        
        private void FormNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Si cierra esta ventana perdera sus datos \n ¿Esta seguro que desea salir?", "",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Cancel)
            {
                e.Cancel = true;
                 
            }
            if(res == DialogResult.OK)
            {


                qwq.Show();
            }
            
           
            //if (changes == true) {
            //    DialogResult res = MessageBox.Show("Si cierra esta ventana perdera sus datos \n ¿Esta seguro que desea salir?","",
            //        MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            //    if (res == DialogResult.Cancel) {
            //        e.Cancel = true;
            //    }
            //}
        }
        
        private void FormNew_FormClosed(object sender, FormClosedEventArgs e)
        {
            //DialogResult res = MessageBox.Show("Si cierra esta ventana perdera sus datos \n ¿Esta seguro que desea salir?", "",
            //       MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //if (res == DialogResult.Cancel)
            //{
            //    Show();
                
            //}
            //if (res == DialogResult.OK) {
            //    qwq.Show();
            //    Close();
            //}
        }
        
        private void Button2_Click(object sender, EventArgs e)
        {
            StreamWriter guardadoxd = new StreamWriter(uwu.directory);
            foreach (object linea in richTextBox1.Lines)
            {
                guardadoxd.WriteLine(linea);
            }
            guardadoxd.Close();
            Hide();
            qwq.Show();
            //File.WriteAllText(qwq.openFileDialog1.FileName , richTextBox1.Text);
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//PROFESOR NO SE ME CIERRA EL PROGRAMA ME QUIERO TIRAR DE UN PUENTE AYUDA
//Ayuda esto no es un meme
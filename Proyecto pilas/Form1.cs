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

namespace Proyecto_pilas
{
    public partial class Directoio : Form
    {
        public Directoio()
        {
            InitializeComponent();
        }
        private Stack<string> Dir = new Stack<string>();
        private string convertToDir()
        {
            string a = "";
            foreach(string i in Dir)
            {
                a += i + "\\";
            }
            return a;
        }
        private void checkDirectory()
        {
            Dir.Push(txtFolder.Text);
            if (!Directory.Exists(convertToDir())){
                MessageBox.Show("El directorio no existe",convertToDir());
                if(MessageBox.Show("Desea Crear el directorio", "Crear", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Dir.Pop();
                    txtFolder.Text = "";
                }
                else
                {
                    Directory.CreateDirectory(convertToDir());
                }
                
            }
            else
            {
                lbDir.Items.Add(txtFolder.Text);
                txtFolder.Text = "";
            }

        }
        private void Directoio_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtFolder.Text == " ")
            {
                MessageBox.Show("El campo de texto esta vacio");
            }
            else
            {
                checkDirectory();
            }

        }
    }
}

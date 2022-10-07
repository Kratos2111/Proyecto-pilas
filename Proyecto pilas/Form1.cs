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
        private Stack<String> Dir = new Stack<String>();
        private string convertToDir()
        {
            string a = "";
            foreach(string i in Dir)
            {
                a = i + "\\";
            }
            return a;
        }
        private void checkDirectory()
        {
            Dir.Push(txtFolder.Text);
            if (!Directory.Exists(convertToDir())){
                Dir.Pop();
                MessageBox.Show("El directorio no existe");
                txtFolder.Text = "";
            }
            else
            {
                lbDir.Items.Add(Convert.ToString(txtFolder.Text));
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

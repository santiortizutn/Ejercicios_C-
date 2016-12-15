using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string aux;
            aux = this.txtNombre.Text;
            MessageBox.Show("Tu nombre es: " + aux);
        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.lblNombre.Text = "Magia ";
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            // this.btnAprobarMateria.Visible = false;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.btnAprobarMateria.Visible = true;
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            this.btnAprobarMateria.Visible = false;
        }
    }
}

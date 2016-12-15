using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteFacturacion
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

        private void txtPrecio1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            float aux;
            float aux2;
            float aux3;
            aux = float.Parse(this.txtPrecio1.Text);
            aux2 = float.Parse(this.txtPrecio2.Text);
            aux3 = float.Parse(this.txtPrecio3.Text);
            float resultado = aux + aux2 + aux3;
            MessageBox.Show("La suma da: " + resultado);

        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            float aux;
            float aux2;
            float aux3;
            aux = float.Parse(this.txtPrecio1.Text);
            aux2 = float.Parse(this.txtPrecio2.Text);
            aux3 = float.Parse(this.txtPrecio3.Text);
            float resultado = aux + aux2 + aux3;
            float promedio = resultado / 3;
            MessageBox.Show("El promedio es: " + promedio);
        }

        private void btnPrecioFinal_Click(object sender, EventArgs e)
        {
            float aux;
            float aux2;
            float aux3;
            aux = float.Parse(this.txtPrecio1.Text);
            aux2 = float.Parse(this.txtPrecio2.Text);
            aux3 = float.Parse(this.txtPrecio3.Text);
            float resultado = aux + aux2 + aux3;
            float iva = (resultado*21)/100;
            float precioFinal = resultado + iva;

            MessageBox.Show("El precio final es: " + precioFinal);
        }
    }
}

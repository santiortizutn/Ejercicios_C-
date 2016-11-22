using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Form3
{
    public partial class Form1 : Form
    {
        List<Thread> _hilos;
        int _contador;

        public Form1()
        {
            
            InitializeComponent();
            this._hilos = new List<Thread>();
            this._contador = 0;
            this.btnPausar.Click += new EventHandler(this.PausarPelotita);
            this.btnDestruir.Click += new EventHandler(this.destruirPelotita);
            this.btnReanuadar.Click += new EventHandler(this.ReanudarPelotita);
            this.comboBox1.SelectedItem = "Rojo";

            this.btnPausar.Enabled = false;
            this.btnReanuadar.Enabled = false;
            this.btnDestruir.Enabled = false;

        }

        public void PausarPelotita(object sender, EventArgs e)
        {
            try
            {
                this._hilos[this._contador - 1].Suspend();
                this._contador--;
            }
            catch (Exception)
            { }
                             
        }

        public void destruirPelotita(object sender, EventArgs e)
        {
            this._hilos[this._contador - 1].Abort();
            this._hilos.RemoveAt(this._contador - 1);
            this._contador--;

            Graphics g = this.pictureBox1.CreateGraphics();
            g.Clear(this.pictureBox1.BackColor);

            this.lblNumeroPelotitas.Text = this._contador.ToString();

        }

        public void ReanudarPelotita(object sender, EventArgs e)
        {
            this._hilos[this._contador].Resume();
            this._contador++;
            
        }

        private void btn_CRear_Click(object sender, EventArgs e)
        {

            Pelotita_Con_Thread.Pelotita nuevaPelotita = new Pelotita_Con_Thread.Pelotita(this.pictureBox1);


            nuevaPelotita.Color = this.comboBox1.SelectedItem.ToString();
            Thread _nuevoHilo = new Thread(nuevaPelotita.DoWork);

            this._hilos.Add(_nuevoHilo);
            _nuevoHilo.Start();
            this._contador++;

            this.btnPausar.Enabled = true;
            this.btnReanuadar.Enabled = true;
            this.btnDestruir.Enabled = true;

            this.lblNumeroPelotitas.Text = this._contador.ToString();
           // this.btn_CRear.Hide();
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            
                    
        }

        private void btnDestruir_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

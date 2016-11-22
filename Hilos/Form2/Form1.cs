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

namespace Form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Pelotita_Con_Thread.Pelotita nuevaPelotita = new Pelotita_Con_Thread.Pelotita(this.pictureBox1);
            Thread nuevoHilo = new Thread(nuevaPelotita.DoWork);
            nuevoHilo.Start();
        }
    }
}

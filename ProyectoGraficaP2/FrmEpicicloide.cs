using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGraficaP2
{
    public partial class FrmEpicicloide : Form
    {
        private CEpicicloide objEpicicloide = new CEpicicloide();
        public FrmEpicicloide()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            objEpicicloide.ReadData(txtRMayor, txtRMenor,txtVueltas);
            objEpicicloide.DrawEpicicloid(picCanvas);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuPrin mp = new MenuPrin();
            this.Hide();
            mp.Show();
        }

        private void FrmEpicicloide_Load(object sender, EventArgs e)
        {
            objEpicicloide.initializer(txtRMayor,txtRMenor,txtVueltas,picCanvas);
        }
    }
}

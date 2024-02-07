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
    public partial class FrmCicloide : Form
    {
        public CCicloide objCicloide = new CCicloide();
        public FrmCicloide()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grbAccion_Enter(object sender, EventArgs e)
        {

        }

        private void FrmCicloide_Load(object sender, EventArgs e)
        {
            objCicloide.initializer(txtRadio,txtSaltos,picCanvas);
        }

        private void btnGraficarA_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            objCicloide.ReadData(txtRadio,txtSaltos);
            objCicloide.DrawCicloidAni(picCanvas);
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            objCicloide.ReadData(txtRadio, txtSaltos);
            objCicloide.DrawCicloid(picCanvas);
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
    }
}

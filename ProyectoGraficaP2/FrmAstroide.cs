using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoGraficaP2
{
    public partial class FrmAstroide : Form
    {
        public CAstroide objAstroide = new CAstroide();
        public FrmAstroide()
        {
            InitializeComponent();          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            objAstroide.ReadData(txtTamanio);
            objAstroide.DrawAstroideAndAxesAni(picCanvas);
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

        private void FrmAstroide_Load(object sender, EventArgs e)
        {
            objAstroide.initializer(txtTamanio, picCanvas);
        }

        private void grbAccionAstroide_Enter(object sender, EventArgs e)
        {

        }

        private void btnGraficar_Click_1(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            objAstroide.ReadData(txtTamanio);
            objAstroide.DrawAstroideAndAxes(picCanvas);
        }
    }
}

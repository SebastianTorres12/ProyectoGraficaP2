using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoGraficaP2
{
    public partial class frmRosa : Form
    {
        private CRosa objRosa = new CRosa();
        public frmRosa()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPetalos_Click(object sender, EventArgs e)
        {

        }

        private void grbAccionRosa_Enter(object sender, EventArgs e)
        {

        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            objRosa.ReadData(txtTamanio, txtNPetalos);
            objRosa.DrawRosa(picCanvas);
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

        private void txtNPetalos_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRosa_Load(object sender, EventArgs e)
        {
            objRosa.initializer(txtTamanio, txtNPetalos, picCanvas);
        }

        private void btnGraficarA_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            objRosa.ReadData(txtTamanio, txtNPetalos);
            objRosa.DrawRosaAni(picCanvas);
        }
    }
}

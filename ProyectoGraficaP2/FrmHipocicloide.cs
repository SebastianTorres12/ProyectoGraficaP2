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
    public partial class FrmHipocicloide : Form
    {
        CHipocicloide objHipocicloide = new CHipocicloide();
        public FrmHipocicloide()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmHipocicloide_Load(object sender, EventArgs e)
        {
            objHipocicloide.initializer(txtRMayor,txtRMenor,txtVueltas,picCanvas);

        }

        private void btnGraficarAni_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            objHipocicloide.ReadData(txtRMayor,txtRMenor,txtVueltas);
            objHipocicloide.DrawAnimatedHipocicloid(picCanvas);
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

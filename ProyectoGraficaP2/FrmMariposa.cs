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
    public partial class FrmMariposa : Form
    {
        CMariposa objmariposa = new CMariposa();
        public FrmMariposa()
        {
            InitializeComponent();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            objmariposa.DrawButterflyCurve(picCanvas);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuPrin mp = new MenuPrin();
            this.Hide();
            mp.Show();
        }

        private void FrmMariposa_Load(object sender, EventArgs e)
        {
            objmariposa.initializer(picCanvas);
        }
    }
}

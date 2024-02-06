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
    public partial class MenuPrin : Form
    {
        public MenuPrin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hasta Pronto");
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmRosa rosa = new frmRosa();
            this.Hide();   
            rosa.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmEpicicloide epicicloide = new FrmEpicicloide();
            this.Hide();
            epicicloide.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAstroide astroide = new FrmAstroide();
            this.Hide();
            astroide.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmMariposa mariposa = new FrmMariposa();
            this.Hide();
            mariposa.Show();
        }

        private void MenuPrin_Load(object sender, EventArgs e)
        {

        }
    }
}

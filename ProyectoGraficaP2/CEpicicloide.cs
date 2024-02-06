using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGraficaP2
{
    public class CEpicicloide
    {
        private Graphics mGraph;
        private Pen aPen, cPen;
        PointF center;
        private float rMayor;
        private float rMenor;
        private int vueltas;
        private const float SF = 5;

        public void initializer(TextBox txtRMayor, TextBox txtRMenor, TextBox txtVueltas, PictureBox picCanvas)
        {
            rMayor = 0.0f;
            rMenor = 0.0f;
            vueltas = 0;

            txtRMayor.Text = "";
            txtRMenor.Text = "";
            txtVueltas.Text = "";
            mGraph = picCanvas.CreateGraphics();
            aPen = new Pen(Color.Black, 2);
            cPen = new Pen(Color.Red, 2);
        }

        public void ReadData(TextBox txtRMayor, TextBox txtRMenor, TextBox txtVueltas)
        {
            try
            {
                rMayor = float.Parse(txtRMayor.Text) * SF;
                rMenor = float.Parse(txtRMenor.Text) * SF;
                vueltas = int.Parse(txtVueltas.Text) * 2;

            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void calculateCenter(PictureBox picCanvas)
        {
            center.X = (picCanvas.Width) / 2;
            center.Y = (picCanvas.Height) / 2;
        }

        public void DrawEpicicloid(PictureBox picCanvas)
        {

            calculateCenter(picCanvas);

            // Dibujar el eje x
            mGraph.DrawLine(aPen, 0, center.Y, picCanvas.Width, center.Y);

            // Dibujar el eje y
            mGraph.DrawLine(aPen, center.X, 0, center.X, picCanvas.Height);

            // Dibujar el círculo grande
            mGraph.DrawEllipse(cPen, (int)(picCanvas.Width / 2 - rMayor), (int)(picCanvas.Height / 2 - rMayor), (int)(2 * rMayor), (int)(2 * rMayor));

            double k = rMayor / rMenor;

            for (double alpha = 0.001; alpha <= vueltas * Math.PI; alpha += 0.001) // Ajusta el límite superior para completar múltiples vueltas
            {
                double y = (rMayor + rMenor) * Math.Sin(alpha) - rMenor * Math.Sin((1 + k) * alpha);
                double x = (rMayor + rMenor) * Math.Cos(alpha) - rMenor * Math.Cos((1 + k) * alpha);

                int screenX = (int)(picCanvas.Width / 2 + x);
                int screenY = (int)(picCanvas.Height / 2 - y);

                mGraph.FillEllipse(Brushes.Indigo, screenX - 2, screenY - 2, 4, 4);
            } 
        }
    }
}

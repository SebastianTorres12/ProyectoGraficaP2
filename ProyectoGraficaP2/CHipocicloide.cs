using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGraficaP2
{
    internal class CHipocicloide
    {
        private Graphics mGraph;
        private Pen pPen, cPen, mPen;
        private int vueltas;
        private double r1;
        private double r2;
        private const int SF = 5;

        public void initializer(TextBox txtR1, TextBox txtR2, TextBox txtVueltas, PictureBox picCanvas)
        {
            r1 = 0;
            r2 = 0;
            vueltas = 0;

            txtR1.Text = "";
            txtR2.Text = "";
            txtVueltas.Text = "";
            mGraph = picCanvas.CreateGraphics();
            pPen = new Pen(Color.Black, 3);
            mPen = new Pen(Color.Indigo, 3);
            cPen = new Pen(Color.Red, 3);
        }

        public void ReadData(TextBox txtR1, TextBox txtR2, TextBox txtVueltas)
        {
            try
            {
                r1 = double.Parse(txtR1.Text) * SF;
                r2 = double.Parse(txtR2.Text) * SF;
                vueltas = int.Parse(txtVueltas.Text) * 2;
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }


        public void DrawAnimatedHipocicloid(PictureBox picCanvas)
        {
            // Centro de la ventana
            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;

            // Dibujar el eje x
            mGraph.DrawLine(pPen, 0, centerY, picCanvas.Width, centerY);

            // Dibujar el eje y
            mGraph.DrawLine(pPen, centerX, 0, centerX, picCanvas.Height);

            // Dibujar la circunferencia generatriz
            mGraph.DrawEllipse(cPen, (int)(centerX - r1), (int)(centerY - r1), (int)(2 * r1), (int)(2 * r1));

            // Parámetros de la hipocicloide
            double alpha = 0.01; // Ángulo de variación
            double beta = r1 / r2 * alpha;

            // Inicializar el pincel para dibujar
            SolidBrush ellipseBrush = new SolidBrush(Color.Indigo);

            for (int i = 0; i <= (int)(vueltas * Math.PI / 0.01); i++)
            {
                double t = i * 0.01;
                double x = (r1 - r2) * Math.Cos(t) + r2 * Math.Cos((1 - r1 / r2) * t);
                double y = (r1 - r2) * Math.Sin(t) + r2 * Math.Sin((1 - r1 / r2) * t);

                // Transformar las coordenadas a la ventana
                int pixelX = centerX + (int)x;
                int pixelY = centerY - (int)y; // Negativo para invertir el eje y

                // Dibujar la hipocicloide hasta el punto actual
                mGraph.FillEllipse(ellipseBrush, pixelX - 2, pixelY - 2, 4, 4);
            }
        }
    }
}

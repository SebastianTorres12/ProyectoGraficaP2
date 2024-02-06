using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProyectoGraficaP2
{
    public class CRosa
    {
        private Graphics mGraph;
        private Pen mPen, pPen;
        PointF center;
        private float tamanio;
        private float npetalos;
        private const float SF = 10;

        public void initializer(TextBox txtTamanio, TextBox txtNPetalos, PictureBox picCanvas)
        {
            tamanio = 0.0f;
            npetalos = 0.0f;
            txtTamanio.Text = "";
            txtNPetalos.Text = "";
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Indigo, 3);
            pPen = new Pen(Color.Black, 3);
            Point[] points = new Point[360];
        }

        public void ReadData(TextBox txtTamanio, TextBox txtNPetalos)
        {
            try
            {
                tamanio = float.Parse(txtTamanio.Text) * SF;

                // Obtener el número de pétalos
                int numPetalos = int.Parse(txtNPetalos.Text);

                // Ajustar npetalos en función de si el número de pétalos es par o impar
                npetalos = numPetalos % 2 == 0 ? numPetalos / 2.0f : numPetalos;
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

        public void DrawRosa(PictureBox picCanvas)
        {

            calculateCenter(picCanvas);
            Point[] points = new Point[360];

            // Dibujar el eje x
            mGraph.DrawLine(pPen, 0, center.Y, picCanvas.Width, center.Y);

            // Dibujar el eje y
            mGraph.DrawLine(pPen, center.X, 0, center.X, picCanvas.Height);

            // Calcular los puntos de la rosa de cuatro pétalos
            for (int t = 0; t < 360; t++)
            {
                double angle = Math.PI * t / 180.0;
                int x = (int)(tamanio * Math.Cos(npetalos * angle) * Math.Cos(angle));
                int y = (int)(tamanio * Math.Cos(npetalos * angle) * Math.Sin(angle));

                // Ajustar el origen al centro del PictureBox
                x += (int)center.X;
                y += (int)center.Y;

                points[t] = new Point(x, y);
            }

            // Dibujar la rosa de cuatro pétalos
            mGraph.DrawLines(mPen, points);
        }
    }
}

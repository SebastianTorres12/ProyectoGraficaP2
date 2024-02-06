using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGraficaP2
{
    public class CMariposa
    {
        private Graphics mGraph;
        private Pen aPen, mPen;
        private const float SF = 50;

        public void initializer(PictureBox picCanvas)
        {    
            mGraph = picCanvas.CreateGraphics();
            aPen = new Pen(Color.Black, 2);
            mPen = new Pen(Color.Indigo, 1);
        }

        public void DrawButterflyCurve(PictureBox picCanvas)
        {
            double t;
            PointF[] points = new PointF[10000];  // Crea un arreglo de puntos para almacenar los puntos de la curva.

            // Calcula el centro del formulario
            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;

            // Dibujar el eje x
            mGraph.DrawLine(aPen, 0, centerY, picCanvas.Width, centerY);

            // Dibujar el eje y
            mGraph.DrawLine(aPen, centerX, 0, centerX, picCanvas.Height);

            for (int i = 0; i < points.Length; i++)
            {
                t = i * 0.01;
                // Calcula las coordenadas x e y de acuerdo con las ecuaciones paramétricas de la curva mariposa.
                double x = Math.Sin(t) * (Math.Exp(Math.Cos(t)) - 2 * Math.Cos(4 * t) - Math.Pow(Math.Sin(t / 12), 5));
                double y = Math.Cos(t) * (Math.Exp(Math.Cos(t)) - 2 * Math.Cos(4 * t) - Math.Pow(Math.Sin(t / 12), 5));

                // Convierte las coordenadas a píxeles en el formulario, escalando por un factor de 50 y utilizando el centro del formulario como referencia.
                int pixelX = (int)(centerX + x * SF);
                int pixelY = (int)(centerY - y * SF);

                // Almacena el punto en el arreglo de puntos.
                points[i] = new PointF(pixelX, pixelY);
            }
           
                // Dibuja la curva utilizando la pluma definida por el objeto Pen.
                mGraph.DrawCurve(mPen, points);
            
        }


    }
}

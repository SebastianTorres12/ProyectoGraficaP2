using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGraficaP2
{
    public class CCicloide
    {
        private Graphics mGraph;
        private Pen pPen, cPen;       
        private int saltos;
        private int radio;
        private const int SF = 5;
        private List<Point> cicloidPoints = new List<Point>();

        public void initializer(TextBox txtRadio, TextBox txtSaltos, PictureBox picCanvas)
        {
            radio = 0;
            saltos = 0;
            txtSaltos.Text = "";
            txtRadio.Text = "";
            mGraph = picCanvas.CreateGraphics();      
            pPen = new Pen(Color.Black, 3);
            cPen = new Pen(Color.Red, 3);

        }

        public void ReadData(TextBox txtRadio, TextBox txtSaltos)
        {
            try
            {
                radio = int.Parse(txtRadio.Text) * SF;
                saltos = int.Parse(txtSaltos.Text) * 2;
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void DrawCicloidAni(PictureBox picCanvas)
        {     
            double tMax = saltos * Math.PI; // Ajusta el rango para mostrar aproximadamente 3 arcos

            // Dibujar ejes coordenados en el primer cuadrante
            mGraph.DrawLine(pPen, 0, picCanvas.Height / 2, picCanvas.Width -10, picCanvas.Height / 2); // Eje X
            mGraph.DrawLine(pPen, 10, picCanvas.Height / 2, 10, -picCanvas.Height); // Eje Y

            // Dibujar la cicloide
            for (double t = 0; t <= tMax; t += 0.01)
            {
                double x = radio * (t - Math.Sin(t));
                double y = radio * (1 - Math.Cos(t));

                // Escalar y ajustar al centro del formulario
                int pixelX = (int)(x) + 10;
                int pixelY = picCanvas.Height / 2 - (int)(y); // Ajustar la coordenada y para que sea negativa

                // Dibujar el punto en la posición calculada
                mGraph.FillEllipse(Brushes.Red, pixelX, pixelY, 2, 2);
            }
        }

        public void DrawCicloid(PictureBox picCanvas)
        {
            double tMax = saltos * Math.PI; // Ajusta el rango para mostrar aproximadamente 3 arcos

            // Dibujar ejes coordenados en el primer cuadrante      
            mGraph.DrawLine(pPen, 0, picCanvas.Height / 2, picCanvas.Width - 10, picCanvas.Height / 2); // Eje X
            mGraph.DrawLine(pPen, 10, picCanvas.Height / 2, 10, -picCanvas.Height); // Eje Y

            cicloidPoints.Clear(); // Limpiar la lista antes de empezar
            cicloidPoints.Add(new Point(0, picCanvas.Height / 2)); // Punto inicial

            for (double t = 0; t <= tMax; t += 0.01)
            {
                double x = radio * (t - Math.Sin(t));
                double y = radio * (1 - Math.Cos(t));

                // Escalar y ajustar al centro del formulario
                int pixelX = (int)(x) + 10;
                int pixelY = picCanvas.Height / 2 - (int)(y); // Ajustar la coordenada y para que sea negativa

                // Almacenar el punto en la lista
                cicloidPoints.Add(new Point(pixelX, pixelY));
            }

            // Dibujar todas las líneas de una vez
            mGraph.DrawLines(cPen, cicloidPoints.ToArray());
        }
    }
}

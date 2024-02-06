using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;



namespace ProyectoGraficaP2
{
    public class CAstroide
    {
        private Graphics mGraph;
        private Pen mPen, pPen, cPen;
        PointF center;
        private float tamanio;
        private const float SF = 5;

        public void initializer(TextBox txtTamanio, PictureBox picCanvas)
        {
            tamanio = 0.0f;     
            txtTamanio.Text = "";
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Indigo, 3);
            pPen = new Pen(Color.Black, 3);
            cPen = new Pen(Color.Red, 3);

        }

        public void ReadData(TextBox txtTamanio)
        {
            try
            {
                tamanio = float.Parse(txtTamanio.Text) * SF;
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void DrawAstroideAndAxes(PictureBox picCanvas)
        {
            calculateCenter(picCanvas);
            DrawAxes();  // Dibujar ejes
            DrawAstroide();  // Dibujar astroide
        }

        private void DrawAstroide()
        {
            // Definir el parámetro 't'
            double dt = 0.01;

            for (double t = 0; t <= 2 * Math.PI; t += dt)
            {
                double x = tamanio * Math.Pow(Math.Cos(t), 3);
                double y = tamanio * Math.Pow(Math.Sin(t), 3);

                // Escalar y trasladar para que el astroide se ajuste al PictureBox
                int scaledX = (int)(x + center.X);
                int scaledY = (int)(y + center.Y);

                // Dibujar la astroide
                mGraph.FillEllipse(Brushes.Indigo, scaledX - 1, scaledY - 1, 4, 4);
            }

            // Dibujar el círculo que contiene la astroide
            mGraph.DrawEllipse(cPen, center.X - tamanio, center.Y - tamanio, 2 * tamanio, 2 * tamanio);
        }

        private void DrawAxes()
        {       
            // Dibujar el eje x
            mGraph.DrawLine(pPen, 0, center.Y, center.X * 2, center.Y);

            // Dibujar el eje y
            mGraph.DrawLine(pPen, center.X, 0, center.X, center.Y * 2);
        }

        public void calculateCenter(PictureBox picCanvas)
        {
            center.X = picCanvas.Width / 2;
            center.Y = picCanvas.Height / 2;
        }


    }
}

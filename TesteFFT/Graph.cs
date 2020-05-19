using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TesteFFT
{
    public class Graph
    {
        private Graphics graphics;
        private List<double> values;
        private List<Point> pontos;
        private Panel panel;

        public Graph(Panel panel, List<double> v)
        {
            this.panel = panel;
            graphics = panel.CreateGraphics();
            pontos = new List<Point>();
            values = v;
        }

        public void MontaGrafico()
        {
            DrawLine(new Point(panel.Location.X, 10), new Point(panel.Location.X, panel.Size.Height - 10));
            DrawLine(new Point(panel.Location.X, panel.Size.Height / 2), new Point(panel.Size.Width - 10, panel.Size.Height / 2));
        }

        public void Plota(bool ligaPontos = true)
        {
            if (values.Count < 1)
                return;

            var max_value = values.Max();
            var min_value = values.Min();

            double escala;
            if (Math.Abs(min_value) > Math.Abs(max_value))
                escala = min_value;
            else
                escala = max_value;

            var inc = panel.Size.Width / values.Count;
            var y_max = panel.Size.Height / (escala * 2);

            for (int i = 0; i < values.Count; i++)
            {
                pontos.Add(new Point(panel.Location.X + (i * inc), Convert.ToInt32((y_max * values[i]) + panel.Size.Height / 2)));
                DrawPoint(pontos[i].X, pontos[i].Y);
            }


            if (ligaPontos)
            {
                for (int i = 0; i < values.Count - 1; i++)
                {
                    DrawLine(pontos[i], pontos[i + 1]);
                }
            }
        }

        private void DrawPoint(int x, int y)
        {
            Pen p = new Pen(Color.Black);
            SolidBrush sb = new SolidBrush(Color.Black);
            graphics.DrawEllipse(p, x - 2, y - 2, 5, 5);
            graphics.FillEllipse(sb, x - 2, y - 2, 5, 5);
        }

        private void DrawLine(Point p1, Point p2)
        {
            Pen p = new Pen(Color.Black);
            graphics.DrawLine(p, p1, p2);
        }
    }
}

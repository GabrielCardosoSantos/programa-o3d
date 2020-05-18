using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteFFT
{

    public partial class Form1 : Form
    {
        Graph graphOriginal;
        Graph graphDCT;
        Graph graphIDCT;
        Graph graphFFT;
        Graph graphIFFT;

        List<short> values_short;
        List<double> values;

        public Form1()
        {
            InitializeComponent();
            values_short = LerArq();
            values = ConvertToDouble(values_short);
            graphOriginal = new Graph(pnlOriginal, values);
            graphDCT = new Graph(pnlDCT, DCT(values));
            graphFFT = new Graph(pnlFFT, FFT(values));
            graphIDCT = new Graph(pnlIDCT, IDCT(DCT(values)));
            graphIFFT = new Graph(pnlInverseFFT, IFFT(FFT(values)));
        }

        public List<double> ConvertToDouble(List<short> values)
        {
            List<double> vs = new List<double>();
            foreach(var v in values)
                vs.Add(Convert.ToDouble(v));
            
            return vs;
        }

        private List<double> IFFT(List<double> values)
        {
            List<double> valores = new List<double>();
            return valores;
        }

        private List<double> FFT(List<double> values)
        {
            List<double> valores = new List<double>();

            return valores;
        }

        private List<double> IDCT(List<double> values)
        {
            List<double> valores = new List<double>();
            int n = values.Count;
            for (int i = 0; i < n; ++i)
            {
                double soma = 0.0;
                double s;
                for (int k = 0; k < n; ++k)
                {
                    if (k == 0)
                        s = Math.Sqrt(0.5);
                    else
                        s = 1.0;
                    soma += s * values[k] * Math.Cos(Math.PI * (i + 0.5) * k / n);
                }
                var v = soma * Math.Sqrt(2f / values.Count);
                valores.Add(v);
            }

            return valores;
        }

        private List<double> DCT(List<double> values)
        {
            List<double> valores = new List<double>();
            
            for (int i = 0; i < values.Count; ++i)
            {
                double s, n, sum = 0f;

                if (i == 0) 
                    s = Math.Sqrt(0.5);
                else 
                    s = 1.0;

                for (int j = 0; j < values.Count; ++j)
                    sum += s * values[j] * Math.Cos(Math.PI * (j + 0.5) * i / values.Count);

                n = sum * Math.Sqrt(2f / values.Count);

                valores.Add(n);
            }

            return valores;
        }


        public List<short> LerArq()
        {
            var reader = File.Open("samples.dct", FileMode.Open);
            List<short> values = new List<short>();

            using (var binaryStream = new BinaryReader(reader))
            {
                uint value = binaryStream.ReadUInt32();

                for (int i = 0; i < value; i++)
                    values.Add(binaryStream.ReadInt16());
            }

            return values;
        }

        private void pnlOriginal_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            graphOriginal.MontaGrafico();
            graphOriginal.Plota(true);
        }

        private void pnlDCT_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            graphDCT.MontaGrafico();
            graphDCT.Plota(false);
        }

        private void pnlIDCT_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            graphIDCT.MontaGrafico();
            graphIDCT.Plota(true);
        }

        private void pnlFFT_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            graphFFT.MontaGrafico();
            graphFFT.Plota();
        }

        private void pnlInverseFFT_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            graphIFFT.MontaGrafico();
            graphIFFT.Plota();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
        }
    }


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
            DrawLine(new Point(panel.Location.X, 10), new Point(panel.Location.X, panel.Size.Height -10));
            DrawLine(new Point(panel.Location.X, panel.Size.Height / 2), new Point(panel.Size.Width - 10, panel.Size.Height/2));
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

            for(int i = 0; i < values.Count; i++)
            {
                pontos.Add(new Point(panel.Location.X + (i * inc), Convert.ToInt32((y_max * values[i]) + panel.Size.Height / 2)));
                DrawPoint(pontos[i].X, pontos[i].Y);
            }


            if (ligaPontos)
            {
                for(int i = 0; i < values.Count - 1; i++)
                {
                    DrawLine(pontos[i], pontos[i+1]);
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

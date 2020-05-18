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
                    if (k == 0) s = Math.Sqrt(0.5);
                    else s = 1.0;
                    soma += s * Math.Cos(Math.PI * (i + 0.5) * k / n);
                }

                valores.Add(soma);
            }

            return valores;
        }

        private List<double> DCT(List<double> values)
        {
            List<double> valores = new List<double>();
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
            graphOriginal.Plota(0, 0);
        }

        private void pnlDCT_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            graphDCT.MontaGrafico();
            graphDCT.Plota(0, 0);
        }

        private void pnlIDCT_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            graphIDCT.MontaGrafico();
            graphIDCT.Plota(0, 0);
        }

        private void pnlFFT_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            graphFFT.MontaGrafico();
            graphFFT.Plota(0, 0);
        }

        private void pnlInverseFFT_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            graphIFFT.MontaGrafico();
            graphIFFT.Plota(0, 0);
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
        private Panel panel;

        public Graph(Panel panel, List<double> v)
        {
            this.panel = panel;
            graphics = panel.CreateGraphics();
            values = v;
        }

        public void MontaGrafico()
        {
            DrawLine(new Point(panel.Location.X, 10), new Point(panel.Location.X, panel.Size.Height -10));
            DrawLine(new Point(panel.Location.X, panel.Size.Height / 2), new Point(panel.Size.Width - 10, panel.Size.Height/2));
        }

        public void Plota(int posX, int posY)
        {
            //if (values.Count < 1)
            //    return;

            //var max_value = values.Max();
            //var min_value = values.Min();

            var panel_X = panel.Location.X;
            var panel_Y = panel.Location.Y;

            
            DrawPoint(panel_X + posX, panel_Y + posY);
        }

        private void DrawPoint(int x, int y)
        {
            Pen p = new Pen(Color.Black);
            SolidBrush sb = new SolidBrush(Color.Black);
            graphics.DrawEllipse(p, x, y, 5, 5);
            graphics.FillEllipse(sb, x, y, 5, 5);
        }

        private void DrawLine(Point p1, Point p2)
        {
            Pen p = new Pen(Color.Black);
            graphics.DrawLine(p, p1, p2);
        }
    }
}

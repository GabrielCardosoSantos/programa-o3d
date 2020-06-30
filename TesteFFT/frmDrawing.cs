using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteFFT
{
    public partial class frmDrawing : Form
    {
        public codingTrain train;
        public Algorithms alg;
        public Graphics graphics;

        float time = 0f;
        List<Tuple<float, float, float, float, float>> x_dft;
        List<Tuple<float, float, float, float, float>> y_dft;
        public frmDrawing()
        {
            InitializeComponent();
            graphics = pnlDrawing.CreateGraphics();
            train = new codingTrain();
            alg = new Algorithms();

            List<double> x = new List<double>();
            List<double> y = new List<double>();
            train.tuples.ForEach(n => {
                x.Add(n.X);
                y.Add(n.Y);                
            });

            x_dft = alg.dft_epycicles(x);
            y_dft = alg.dft_epycicles(y);
        }

        private void pnlDrawing_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            var vx = epiCycles(pnlDrawing.Width / 2 + 100, 100, 0, x_dft);
            graphics.Clear(Color.White);
            var vy = epiCycles(100, pnlDrawing.Height / 2 + 100, Convert.ToSingle(Math.PI/2), y_dft);
            var v = new Vector2(vx.X, vy.Y);

            Pen pen = new Pen(Color.Black);
            graphics.DrawLine(pen, vx.X, vx.Y, v.X, v.Y);
            graphics.DrawLine(pen, vy.X, vy.Y, v.X, v.Y);
        }




        public Vector2 epiCycles(double x, double y, float rotation, List<Tuple<float, float, float, float, float>> fourier)
        {
            for (int i = 0; i < fourier.Count; i++)
            {
                double prevx = x;
                double prevy = y;
                float freq = fourier[i].Item3;
                float radius = fourier[i].Item4;
                float phase = fourier[i].Item5;
                x += radius * Math.Cos(freq * time + phase + rotation);
                y += radius * Math.Sin(freq * time + phase + rotation);

                Pen pen = new Pen(Color.Black);
                graphics.DrawEllipse(pen, 255f, 100f, Convert.ToSingle(prevx) + radius * 2, Convert.ToSingle(prevy) + radius * 2);
                graphics.DrawLine(pen, Convert.ToSingle(prevx), Convert.ToSingle(prevy), Convert.ToSingle(x), Convert.ToSingle(y));
            }
            return new Vector2(Convert.ToSingle(x), Convert.ToSingle(y));
        }
    }
}

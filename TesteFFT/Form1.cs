using System;
using System.Collections.Generic;
using System.IO;
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
            var algorithms = new Algorithms();
            graphOriginal = new Graph(pnlOriginal, values);
            graphDCT = new Graph(pnlDCT, algorithms.DCT(values));
            graphFFT = new Graph(pnlFFT, algorithms.DFT(values));
            graphIDCT = new Graph(pnlIDCT, algorithms.IDCT(algorithms.DCT(values)));
            graphIFFT = new Graph(pnlInverseFFT, algorithms.IDFT(algorithms.DFT(values)));
        }

        public List<double> ConvertToDouble(List<short> values)
        {
            List<double> vs = new List<double>();
            foreach(var v in values)
                vs.Add(Convert.ToDouble(v));
            
            return vs;
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
            GraphFunc(graphOriginal);
        }

        private void pnlDCT_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphFunc(graphDCT);
        }

        private void pnlIDCT_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphFunc(graphIDCT);
        }

        private void pnlFFT_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphFunc(graphFFT);
        }

        private void pnlInverseFFT_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphFunc(graphIFFT);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void GraphFunc(Graph graph, bool lines = true)
        {
            graph.MontaGrafico();
            graph.Plota(lines);
        }
    }

}

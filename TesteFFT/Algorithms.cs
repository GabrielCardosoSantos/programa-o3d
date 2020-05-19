using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteFFT
{
    public class Algorithms
    {
        public List<double> IFFT(List<double> values)
        {
            List<double> valores = new List<double>();
            return valores;
        }

        public List<double> FFT(List<double> values)
        {
            List<double> valores = new List<double>();

            return valores;
        }

        public List<double> IDCT(List<double> values)
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

        public List<double> DCT(List<double> values)
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


    }
}

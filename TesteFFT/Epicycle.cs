using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteFFT
{
    public class Epicycle
    {
        public double re;
        public double im;
        public double freq;
        public double amp;
        public double phase;

        public Epicycle(float re, float im, float freq, float amp, float phase)
        {
            this.re = re;
            this.im = im;
            this.freq = freq;
            this.amp = amp;
            this.phase = phase;
        }
    }
}

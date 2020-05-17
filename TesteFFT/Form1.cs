﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteFFT
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        public Form1()
        {
            InitializeComponent();
            graphics = pnlDrawing.CreateGraphics();
        }


        private void btnDCT_Click(object sender, EventArgs e)
        {
            
        }


        public void DrawPoint(float x, float y)
        {
            Pen p = new Pen(Color.Black);
            SolidBrush sb = new SolidBrush(Color.Black);
            graphics.DrawEllipse(p, x, y, 10, 10);
            graphics.FillEllipse(sb, x, y, 10, 10);
        }



    }
}

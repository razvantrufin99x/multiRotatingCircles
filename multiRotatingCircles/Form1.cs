using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace multiRotatingCircles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        Pen pen0 = new Pen(Color.Black,1);
        Pen pen2 = new Pen(Color.Red, 1);
        Pen pen1 = new Pen(Color.Silver, 1);
        float rad = (float)(180 / Math.PI);
        int cux = 350;
        int cuy = 350;

        bool eprim(int x)
        {
            bool esteprim = true;

            /*
            int d = 0;

            while (d <= (int)Math.Sqrt(x) && esteprim == true)
            {
                if (x % d == 0) { esteprim = false; }
                else if (d == 2) { d = d + 1; }
                else { d = d + 2; }
            }
            */

            for (int i = 2; i < (int)Math.Sqrt(x); i+=1)
            {
                if (x % i == 0) { esteprim = false; }
            }

            return esteprim;

        
        }

        void drawCircle()
        {

            float px, py, cx, cy;
            cx = (float)Math.Cos(0 / rad) * (200 + 0) + cux;
            cy = (float)Math.Sin(0 / rad) * (200 + 0) + cuy;
            px = cx;
            py = cy;
            int p = 0;
            this.Width = 10000;
            this.Height = 10000;
            

                for (float j = 0; j < 360; j += 1.0f)
                {
                    for (float i = 0; i < 360; i += 1.0f)
                    {
                        p++;
                        if (eprim(p) != true)
                        {
                            px = cx;
                            py = cy;
                            cx = (float)Math.Cos(i / rad) * (200 + j) + cux;
                            cy = (float)Math.Sin(i / rad) * (200 + j) + cuy;
                           // g.DrawLine(pen1, cx, cy, px, py);
                            //g.DrawRectangle(pen0, cx, cy, 1, 1);
                            //textBox1.Text += "\r\n";
                            //textBox1.Text += p.ToString();

                        }
                        if (eprim(p) == true)
                        {
                            px = cx;
                            py = cy;
                            cx = (float)Math.Cos(i / rad) * (200 + j) + cux;
                            cy = (float)Math.Sin(i / rad) * (200 + j) + cuy;
                           // g.DrawLine(pen1, cx, cy, px, py);
                            g.DrawRectangle(pen2, cx, cy, 1, 1);
                            //textBox2.Text += "\r\n";
                            //textBox2.Text += p.ToString();
                        }
                    }
                   
               }


        }


        private void Form1_Load(object sender, EventArgs e)
        {

            g = CreateGraphics();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            drawCircle();
           //timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            
            //drawCircle();
            //g.ScaleTransform(-1.0f, -1.0f);
            //g.RotateTransform(-0.250f);
            //g.TranslateTransform(-1.0f, -1.0f);
            
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppАк
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;

        private void Form1_Load(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
        }


        private void PrintTriangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            g.DrawLine(new Pen(Color.Red), x1, y1, x2, y2);
            g.DrawLine(new Pen(Color.Red), x2, y2, x3, y3);
            g.DrawLine(new Pen(Color.Red), x3, y3, x1, y1);
        }

        private void F(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            PrintTriangle(x1, y1, x2, y2, x3, y3);
            int xn1 = (x1 + x2) / 2;
            int yn1 = (y1 + y2) / 2;

            int xn2 = (x2 + x3) / 2;
            int yn2 = (y2 + y3) / 2;

            int xn3 = (x3 + x1) / 2;
            int yn3 = (y3 + y1) / 2;

            if (Math.Abs(x1 - x2) > 1)
            {
                F(x1, y1, xn1, yn1, xn3, yn3);
                F(x2, y2, xn2, yn2, xn1, yn1);
                F(x3, y3, xn2, yn2, xn3, yn3);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F(20, 580, 580,580, 280,95);

           
        }
    }
}

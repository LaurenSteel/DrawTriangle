using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DrawTriangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
            Pen pen = new Pen(Color.Red, 10);
            DrawTriangle(pen, 20, 100, 303, 58, 40, 250);
        }
            public void DrawTriangle(Pen pen, int y1, int x1, int y2, int x2, int y3, int x3 )
            {
            Graphics g = this.CreateGraphics();
            g.DrawLine(pen, y1, x1, y2, x2);
            g.DrawLine(pen, y2, x2, y3, x3); 
            g.DrawLine(pen, y3, x3, y1, x1);
        }
    }
}

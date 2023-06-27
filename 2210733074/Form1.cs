using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2210733074
{
    public partial class Form1 : Form
    {
        int X1, Y1, X2, Y2;
        string cizimturu;
        bool ilk;

        public Form1()
        {
            InitializeComponent();
        }

        private void çizgileriSilToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(Color.White, 100);
                Point nokta1 = new Point(X1, Y1);
                Point nokta2 = new Point(e.X, e.Y);
                g.DrawLine(p, nokta1, nokta2);
                X1 = e.X;
                Y1 = e.Y;
            }
        }

        private void dikdörtgenÇizToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            cizimturu = "dikdortgen";
            ilk = false;

            if (e.Button == MouseButtons.Left)
            {
                if (cizimturu == null)
                {
                    Graphics g = this.CreateGraphics();
                    Pen p = new Pen(Color.Blue, 5);
                    Point nokta1 = new Point(X1, Y1);
                    Point nokta2 = new Point(e.X, e.Y);
                    g.DrawLine(p, nokta1, nokta2);
                    X1 = e.X;
                    Y1 = e.Y;
                }
            }
        }

        
   
        private void dikdörtgenÇizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cizimturu = "dikdortgen";
            ilk = false;
        }
    }
}

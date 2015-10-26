using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Drawingshapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            //Brush Class
            /*
            SolidBrush sb = new SolidBrush(Color.Blue);
            Graphics g = panel1.CreateGraphics();
            g.FillRectangle(sb,20,20,50,50);
            g.FillEllipse(sb, 70, 70, 50, 50);
            g.FillPie(sb, 20, 100, 40, 40, 30, 270);
            Point[] pts = {new Point(0,15),new Point(0,0),new Point(15,0)};
            g.FillPolygon(sb, pts);
             */

            //Pen Class
            /*
            Pen pen = new Pen(Color.Red, 2);
            Graphics g = panel1.CreateGraphics();
            g.DrawRectangle(pen, 20, 20, 50, 50);
            g.DrawEllipse(pen, 75, 75, 50, 50);
            Point[] pts = {new Point(100,20),new Point(125,75),new Point(150,20)};
            g.DrawPolygon(pen, pts);
            g.DrawArc(pen,70,100,70,70,0,180);
            g.DrawBezier(pen, new Point(20, 120), new Point(50, 175), new Point(25, 150), new Point(30, 175));
            g.DrawLine(pen, new Point(130, 130), new Point(230, 30));
             */
 
            //Draw String Text
            /*
            SolidBrush sb = new SolidBrush(Color.Blue);
            Graphics g = panel1.CreateGraphics();
            FontFamily ff = new FontFamily("Courier New");//Arial
            System.Drawing.Font font = new System.Drawing.Font(ff,50,FontStyle.Italic);
            g.DrawString("Ani",font,sb,new Point(20,20));
             */ 

            //Linear Gradient Brush
            /*
            LinearGradientBrush lgb = new LinearGradientBrush(new Point(20, 20), new Point(20, 70),Color.Red,Color.Yellow);
            Graphics g = panel1.CreateGraphics();
            g.FillRectangle(lgb,20,20,50,50);
            LinearGradientBrush lgb2 = new LinearGradientBrush(new Point(20, 20), new Point(70, 70), Color.Red, Color.Yellow);
            g.FillEllipse(lgb2, 75, 75, 50, 50);
            */

            //Multiple colors in a Linear Gradient Brush
            /*
            LinearGradientBrush lgb = new LinearGradientBrush(new Point(20, 20), new Point(70, 70), Color.Black, Color.White);
            Graphics g = panel1.CreateGraphics();
            ColorBlend cb = new ColorBlend();
            cb.Colors = new Color[] { Color.Violet, Color.Green, Color.Yellow,Color.Orange };
            cb.Positions = new float[] { 0, .33F, .66F, 1F };
            lgb.InterpolationColors = cb;
            g.FillRectangle(lgb, 20, 20, 50, 50);
             */
 
            //Path Gradient Brush

            GraphicsPath gp = new GraphicsPath();
            //gp.AddEllipse(20, 20, 50, 50);

            //gp.AddRectangle(new Rectangle(20,20,50,50));

            //Point[] pts = { new Point(20, 20), new Point(20, 70), new Point(70, 20) }; //Triangle
            //Point[] pts = { new Point(20, 20), new Point(20, 70), new Point(70, 20), new Point(70, 70) }; //Bow >< shape
            Point[] pts = { new Point(20, 20), new Point(20, 70), new Point(70, 70), new Point(70, 20) }; //Rectangle
            gp.AddPolygon(pts);

            //gp.AddEllipse(20, 20, 50, 50);

            PathGradientBrush pgb = new PathGradientBrush(gp);
            pgb.CenterColor = Color.Red;
            pgb.SurroundColors = new Color[] { Color.Yellow};
            Graphics g = panel1.CreateGraphics();

            //g.FillEllipse(pgb,20, 20, 50, 50);
            //g.FillRectangle(pgb, 20, 20, 50, 50);
            g.FillPolygon(pgb, pts);
        }
    }
}

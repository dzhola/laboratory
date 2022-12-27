using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace graphics
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
        private void zirka()
        {
            Brush zirka = new SolidBrush(Color.Blue);
            Brush kontyr = new HatchBrush(HatchStyle.LightUpwardDiagonal, Color.Black, Color.Orange);
            Pen pen1 = new Pen(kontyr, 7);
            int n = 6;
            double R = 25, r = 75;
            double alpha = 0;
            double x0 = 400, y0 = 250;
            Graphics picture = pictureBox1.CreateGraphics();
            PointF[] points = new PointF[2 * n + 1];
            double a = alpha, da = Math.PI / n, l;
            for (int k = 0; k < 2 * n + 1; k++)
            {
                l = k % 2 == 0 ? r : R;
                points[k] = new PointF((float)(x0 + l * Math.Cos(a)), (float)(y0 + l * Math.Sin(a)));
                a += da;
            }
            picture.FillClosedCurve(zirka, points);
            picture.FillPolygon(new System.Drawing.SolidBrush(Color.Aqua), points);
            picture.DrawPolygon(pen1, points);

        }
        private void kvitka()
        {
            Graphics picture = pictureBox1.CreateGraphics();
            SolidBrush my = new SolidBrush(Color.Blue);
            picture.TranslateTransform(290.0F, 190.0F);
            picture.RotateTransform(30.0F);
            picture.FillEllipse(my, 195, -315, 160, 73);
        }
        private void kvitka2()
        {
            Graphics picture = pictureBox1.CreateGraphics();
            SolidBrush my = new SolidBrush(Color.Blue);
            picture.TranslateTransform(255.0F, 355.0F);
            picture.RotateTransform(-30.0F);
            picture.FillEllipse(my, 415, -60, 160, 73);
        }
        private void button1_Click(object sender, EventArgs e)
		{
            Graphics picture = pictureBox1.CreateGraphics();
            picture.Clear(Color.Bisque);

            zirka();
            Brush rect = new SolidBrush(Color.Olive); 
            picture.FillRectangle(rect, 20, 20, 220, 120);

            Pen pen = new Pen(Color.DarkRed, 3);
            Brush ellip = new SolidBrush(Color.Pink);
            picture.FillEllipse(ellip, 30, 160, 200, 90);
            picture.DrawEllipse(pen, 30, 160, 200, 90);

            Pen pen2 = new Pen(Color.Gray, 3);
            Brush kolo = new SolidBrush(Color.Plum);
            picture.FillEllipse(kolo, 290, 40, 90, 90);
            picture.DrawEllipse(pen2, 290, 40, 90, 90);

            Brush kvadrats = new HatchBrush(HatchStyle.LargeCheckerBoard, Color.Black, Color.White);
            Rectangle krug = new Rectangle(430, 25, 120, 120);
            picture.FillEllipse(kvadrats, krug);

            SolidBrush my = new SolidBrush(Color.Blue);
            Brush kryg = new SolidBrush(Color.Yellow);
            picture.FillEllipse(my, 640, 10, 68, 150);
            kvitka();
            kvitka2();
            picture.FillEllipse(kryg, 640, 55, 60, 60);

            Pen pen3 = new Pen(Color.Chocolate, 5);
            Brush rect2 = new SolidBrush(Color.LightGray);
            Brush rect3 = new SolidBrush(Color.Silver);
            picture.FillRectangle(rect3, 540, 198, 250, 150);
            picture.DrawRectangle(pen3, 540, 198, 250, 150);
            picture.FillPolygon(rect2, new Point[]
            {
               new Point(545, 197),   new Point(665, 270),
                  new Point(784, 197)
            });
            picture.DrawPolygon(pen3, new Point[]
            {
               new Point(545, 197),   new Point(665, 270),
                  new Point(784, 197)
            });

            HatchBrush brush4 = new HatchBrush(HatchStyle.WideDownwardDiagonal, Color.Coral, Color.Ivory);
            HatchBrush brush5 = new HatchBrush(HatchStyle.DiagonalCross, Color.PeachPuff, Color.Ivory);
            picture.FillRectangle(brush4, 25, 280, 200, 120);
            picture.FillPolygon(brush5, new Point[]
            {
               new Point(25, 280),   new Point(225, 280),
                  new Point(125, 345)
            });

            Pen pen4 = new Pen(Color.Black, 2);
            Brush home = new SolidBrush(Color.DarkCyan);
            Brush rectonhome = new SolidBrush(Color.Brown);
            picture.FillRectangle(home, 270, 410, 90, 90);
            picture.DrawRectangle(pen4, 270, 410, 90, 90);
            picture.FillPolygon(rectonhome, new Point[]
            {
            new Point(240, 410),    new Point(390, 410),
            new Point(315, 280)
            });
            picture.DrawPolygon(pen4, new Point[]
            {
            new Point(240, 410),    new Point(390, 410),
            new Point(315, 280)
            });

            HatchBrush brush2 = new HatchBrush(HatchStyle.DottedGrid, Color.Red, Color.Aquamarine);
            HatchBrush brush3 = new HatchBrush(HatchStyle.ZigZag, Color.Red, Color.Aquamarine);
            picture.FillRectangle(brush2, 635, 430, 70, 70);
            picture.FillPolygon(brush3, new Point[]
            {
               new Point(610, 430),   new Point(725, 430),
                  new Point(665, 355)
            }); 
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}

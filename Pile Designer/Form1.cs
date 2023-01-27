using Pile_Designer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pile_Designer
{
    public partial class Form1 : Form
    {
        List<Pile> piles = new List<Pile>();
        List<Beam> beams = new List<Beam>();

        public Form1()
        {
            InitializeComponent();
        }

        private void pilesChanged(object sender, EventArgs e)
        {
            piles.Clear();
            for (int i = 0; i < pileGCode.Lines.Length; i++)
            {                
                var line = pileGCode.Lines[i];
                if (line.Contains(","))
                {
                    piles.Add(new Pile(int.Parse(line.Split(',')[0]), int.Parse(line.Split(',')[1])));
                }   
            }
            // update beams
            beamsChanged(sender, e);
            // draw new
            draw();
        }

        private void beamsChanged(object sender, EventArgs e)
        {
            beams.Clear();
            for (int i = 0; i < beamGCode.Lines.Length; i++)
            {
                var line = beamGCode.Lines[i];
                if (line.Contains(","))
                {
                    int p1 = int.Parse(line.Split(',')[0]) - 1;
                    int p2 = int.Parse(line.Split(',')[1]) - 1;
                    // create beam and update span
                    Beam b = new Beam(p1, p2, float.Parse(line.Split(',')[2]));
                    Point point1 = piles[p2].getPoint();
                    Point point2 = piles[p1].getPoint();
                    b.span = getDistance(point1, point2);
                    b.calcBM();
                    Console.WriteLine(b.BM);
                    beams.Add(b);
                }
            }
            draw();
        }

        private float getDistance(Point point1, Point point2)
        {
            float dx = point1.X - point2.X;
            float dy = point1.Y - point2.Y;
            return (float)Math.Sqrt(dx * dx + dy * dy);
        }

        private void pileButton_Clicked(object sender, EventArgs e)
        {
            pileGCode.AppendText(pileX.Text + "," + pileY.Text + Environment.NewLine);
            pilesChanged(sender, e);
        }

        private void beamButton_Clicked(object sender, EventArgs e)
        {
            beamGCode.AppendText(pile1.Text + "," + pile2.Text + "," + W.Text + Environment.NewLine);
            beamsChanged(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private Point midPoint(Point a, Point b)
        {
            return new Point((a.X + b.X) / 2, (a.Y + b.Y) / 2);
        }

        private void draw()
        {
            Pen whitePen = new Pen(Color.White, 2);
            using (var bmp = new System.Drawing.Bitmap(400, 400))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    // Create font and brush.
                    Font font = new Font("Arial", 12);
                    SolidBrush whiteBrush = new SolidBrush(Color.White);

                    // draw piles and label
                    var i = 1;
                    foreach (Pile p in piles)
                    {                   
                        // circle
                        Rectangle rect = new Rectangle(p.x, p.y, 10, 10);
                        g.FillEllipse(new SolidBrush(Color.Red), rect);

                        // label
                        g.DrawString("P" + i.ToString(), font, whiteBrush, p.x + 5, p.y + 5);
                        i++;
                    }
                    i = 1;
                    // draw beams and label
                    foreach (Beam b in beams)
                    {
                        Point point1 = new Point(piles[b.p1].x + 5, piles[b.p1].y + 5);
                        Point point2 = new Point(piles[b.p2].x + 5, piles[b.p2].y + 5);
                        g.DrawLine(whitePen, point1, point2);

                        g.DrawString("B" + i.ToString(), font, whiteBrush, midPoint(point1, point2));
                        i++;
                    }                    
                }
                var memStream = new MemoryStream();
                bmp.Save(memStream, ImageFormat.Jpeg);
                pictureBox1.Image = Image.FromStream(memStream);
            }
        }

        private void updateOutput()
        {

        }
    }
}

using Pile_Designer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
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
            pilesChanged();
            beamsChanged();
        }

        private void pilesChanged(object sender = null, EventArgs e = null)
        {
            piles.Clear();
            int j = 0;
            for (int i = 0; i < pileGCode.Lines.Length; i++)
            {                
                var line = pileGCode.Lines[i];
                if (line.Contains(","))
                {
                    j++;
                    string name = "P" + j;
                    piles.Add(new Pile(int.Parse(line.Split(',')[0]), int.Parse(line.Split(',')[1]), name));
                }   
            }
            // update beams
            beamsChanged(sender, e);
            // update pile reactions
            setReactions();
            // draw and output
            draw();
            updateOutput();
        }

        private void beamsChanged(object sender = null, EventArgs e = null)
        {
            beams.Clear();
            int j = 0;
            for (int i = 0; i < beamGCode.Lines.Length; i++)
            {
                var line = beamGCode.Lines[i];
                if (line.Contains(","))
                {
                    j++;
                    int p1 = int.Parse(line.Split(',')[0]) - 1;
                    int p2 = int.Parse(line.Split(',')[1]) - 1;
                    // create beam
                    string name = "B" + j;
                    Beam b = new Beam(p1, p2, float.Parse(line.Split(',')[2]), name);
                    Point point1 = piles[p2].getPoint();
                    Point point2 = piles[p1].getPoint();

                    // update beam span and distance
                    b.span = getDistance(point1, point2);
                    b.calcBM();

                    // add to list
                    beams.Add(b);
                }
            }
            // update pile reactions
            setReactions();
            // draw and output
            draw();
            updateOutput();
        }

        private void setReactions()
        {
            // set all back to 0
            foreach(Pile p in piles)
            {
                p.reaction = 0;
            }
            foreach(Beam b in beams)
            {
                piles[b.p1].reaction += b.R;
                piles[b.p2].reaction += b.R;
            }
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
                    foreach (Pile p in piles)
                    {                   
                        // circle
                        Rectangle rect = new Rectangle(p.x, p.y, 10, 10);
                        g.FillEllipse(new SolidBrush(Color.Red), rect);

                        // label
                        g.DrawString(p.name, font, whiteBrush, p.x + 5, p.y + 5);
                    }
                    // draw beams and label
                    foreach (Beam b in beams)
                    {
                        Point point1 = new Point(piles[b.p1].x + 5, piles[b.p1].y + 5);
                        Point point2 = new Point(piles[b.p2].x + 5, piles[b.p2].y + 5);
                        g.DrawLine(whitePen, point1, point2);

                        g.DrawString(b.name, font, whiteBrush, midPoint(point1, point2));
                    }                    
                }
                var memStream = new MemoryStream();
                bmp.Save(memStream, ImageFormat.Jpeg);
                pictureBox1.Image = Image.FromStream(memStream);
            }
        }

        private void updateOutput()
        {
            output.Clear();

            // create fonts
            Font font = new Font("Arial", 10);
            Font bold = new Font("Arial", 10, FontStyle.Bold);

            //Piles
            output.SelectionFont = bold;
            output.AppendText("Piles:\n");
            foreach (Pile p in piles)
            {
                output.SelectionFont = bold;
                output.AppendText(p.name + "\n");

                output.SelectionFont = font;
                output.AppendText(  "reaction =" + p.reaction + "kN\n" +
                                    "capacity =" + p.capacity + "kN\n");
            }
            output.AppendText("\n");

            //Beams
            output.SelectionFont = bold;
            output.AppendText("Beams:\n");
            foreach (Beam b in beams)
            {
                output.SelectionFont = bold;
                output.AppendText(b.name + "\n");

                output.SelectionFont = font;
                output.AppendText(  "span =" + b.span + "m\n" +
                                    "W =" + b.W + "kN\n" +
                                    "R =" + b.R + "kN\n" +
                                    "BM =" + b.BM + "kNm\n");
            }
            output.AppendText("\n");
        }

    }
}

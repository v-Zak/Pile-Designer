using Pile_Designer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        List<LineLoad> lineLoads = new List<LineLoad>();
        int scale = 1;

        public Form1()
        {
            InitializeComponent();
            updateAll();
        }

        private void updateAll(object sender = null, EventArgs e = null)
        {
            updatelineLoads();
            updatePiles();
            updateBeams();

            setReactions();

            draw();
            updateOutput();
        }

        private void updatePiles(object sender = null, EventArgs e = null)
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
           
        }

        private void updateBeams(object sender = null, EventArgs e = null)
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
                    int ll = int.Parse(line.Split(',')[2]) - 1;
                    // create beam
                    string name = "B" + j;
                    Beam b = new Beam(p1, p2, ll , name);
                    Point point1 = piles[p2].getPoint();
                    Point point2 = piles[p1].getPoint();

                    // update beam span, W and BM
                    b.span = getDistance(point1, point2);
                    b.W = b.span * lineLoads[b.ll].w;
                    b.R = b.W / 2;
                    b.calcBM();

                    // add to list
                    beams.Add(b);
                }
            }
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

        private void updatelineLoads(object sender = null, EventArgs e = null)
        {
            lineLoads.Clear();
            for (int i = 0; i < lineLoadGCode.Lines.Length; i++)
            {            
                string line = lineLoadGCode.Lines[i];
                if (!string.IsNullOrEmpty(line))
                {
                    float load = float.Parse(line);
                    LineLoad ll = new LineLoad("L" + (i + 1), load);
                    lineLoads.Add(ll);
                }
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
            updatePiles(sender, e);
        }

        private void beamButton_Clicked(object sender, EventArgs e)
        {
            beamGCode.AppendText(pile1.Text + "," + pile2.Text + "," + ll.Text + Environment.NewLine);
            updateBeams(sender, e);
        }
        private void lineLoadButton_Clicked(object sender, EventArgs e)
        {
            lineLoadGCode.AppendText(lineLoad.Text + Environment.NewLine);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private Point getMidPoint(Point a, Point b)
        {
            return new Point((a.X + b.X) / 2, (a.Y + b.Y) / 2);
        }

        private void draw()
        {
            // calc scale
            int minX = 0, minY = 0;
            int maxX = 5, maxY = 5;
            foreach ( Pile p in piles)
            {
               minX = Math.Min(minX, p.x);
               minY = Math.Min(minY, p.y);

               maxX = Math.Max(maxX, p.x);
               maxY = Math.Max(maxY, p.y);
            }
            int dX = maxX - minX;
            int dY = maxY - minY;
            int d = Math.Max(dX, dY); // difference between furthest points
            float baseScale = 375;
            scale = (int)((baseScale / d) * float.Parse(userScale.Text));
            Console.WriteLine(scale.ToString());

            Pen whitePen = new Pen(Color.White, 2);
            using (var bmp = new System.Drawing.Bitmap(400, 400))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    // Create font and brush.
                    Font font = new Font("Arial", 10);
                    SolidBrush whiteBrush = new SolidBrush(Color.White);

                    // draw piles and label
                    foreach (Pile p in piles)
                    {                   
                        // circle
                        Rectangle rect = new Rectangle(p.x * scale, p.y * scale, 10, 10);
                        g.FillEllipse(new SolidBrush(Color.Red), rect);

                        // label
                        g.DrawString(p.name, font, whiteBrush, p.x * scale + 8, p.y * scale + 8);
                    }
                    // draw beams and label
                    foreach (Beam b in beams)
                    {
                        Point point1 = new Point(piles[b.p1].x * scale + 5, piles[b.p1].y * scale + 5);
                        Point point2 = new Point(piles[b.p2].x * scale + 5, piles[b.p2].y * scale + 5);
                        g.DrawLine(whitePen, point1, point2);
                        Point midPoint = getMidPoint(point1, point2);
                        Point midPointText = Point.Add(midPoint, new Size(0, 3));
                        g.DrawString(b.name, font, whiteBrush, midPointText);
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

            //Line Loads
            output.SelectionFont = bold;
            output.AppendText("Line Loads:\n");
            foreach (LineLoad ll in lineLoads)
            {
                output.SelectionFont = bold;
                output.AppendText(ll.name + "\n");

                output.SelectionFont = font;
                output.AppendText("w =" + ll.w + "kN/m\n");
            }
            output.AppendText("\n");

            //Piles
            output.SelectionFont = bold;
            output.AppendText("Piles:\n");
            foreach (Pile p in piles)
            {
                output.SelectionFont = bold;
                output.AppendText(p.name + "\n");

                output.SelectionFont = font;
                output.AppendText(  "Reaction =" + p.reaction + "kN\n" +
                                    "Capacity =" + p.capacity + "kN\n");
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
                output.AppendText(  "w =" + lineLoads[b.ll].w + "kN/m\n" +
                                    "Span =" + b.span + "m\n" +
                                    "W =" + b.W + "kN\n" +
                                    "R =" + b.R + "kN\n" +
                                    "BM =" + b.BM + "kNm\n");
            }
            output.AppendText("\n");
        }

        private void pileGCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void scaleChanged(object sender, EventArgs e)
        {
            draw();
        }
    }
}

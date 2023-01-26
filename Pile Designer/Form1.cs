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
                    Pile p1 = piles[int.Parse(line.Split(',')[0])];
                    Pile p2 = piles[int.Parse(line.Split(',')[1])];
                    Beam b = new Beam(p1, p2, float.Parse(line.Split(',')[2]));
                    beams.Add(b);
                }
            }
            draw();
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

        private void draw()
        {
            Pen whitePen = new Pen(Color.White, 2);
            using (var bmp = new System.Drawing.Bitmap(400, 400))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    // Do your drawing here
                    // draw piles
                    foreach (Pile p in piles)
                    {
                            Rectangle rect = new Rectangle(p.x, p.y, 10, 10);
                            g.FillEllipse(new SolidBrush(Color.Red), rect);                        
                    }
                    // draw beams
                    foreach (Beam b in beams)
                    {
                        Point point1 = new Point(b.p1.x + 5, b.p1.y + 5);
                        Point point2 = new Point(b.p2.x + 5, b.p2.y + 5);
                        g.DrawLine(whitePen, point1, point2);
                    }
                    
                }

                var memStream = new MemoryStream();
                bmp.Save(memStream, ImageFormat.Jpeg);
                pictureBox1.Image = Image.FromStream(memStream);
            }
        }
    }
}

/*private void draw()
{
    var lastCoords = "";
    Pen whitePen = new Pen(Color.White, 2);
    using (var bmp = new System.Drawing.Bitmap(400, 400))
    {
        using (Graphics g = Graphics.FromImage(bmp))
        {
            // Do your drawing here
            foreach (Pile p in piles)
            {

                if (coordinatea.Contains(","))
                {

                    var coordinate = coordinatea.Replace(Environment.NewLine, "");
                    Rectangle rect = new Rectangle(int.Parse(coordinate.Split(',')[0]) - 5, int.Parse(coordinate.Split(',')[1]) - 5, 10, 10);
                    g.FillEllipse(new SolidBrush(Color.Red), rect);
                    if (lastCoords.Contains(","))
                    {
                        Point point1 = new Point(int.Parse(lastCoords.Split(',')[0]), int.Parse(lastCoords.Split(',')[1]));
                        Point point2 = new Point(int.Parse(coordinate.Split(',')[0]), int.Parse(coordinate.Split(',')[1]));
                        g.DrawLine(whitePen, point1, point2);
                    }
                    lastCoords = coordinate;
                }
            }
        }

        var memStream = new MemoryStream();
        bmp.Save(memStream, ImageFormat.Jpeg);
        pictureBox1.Image = Image.FromStream(memStream);
    }
}*/
using Microsoft.Office.Interop.Word;
using Pile_Designer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Font = System.Drawing.Font;
using Point = System.Drawing.Point;
using Rectangle = System.Drawing.Rectangle;
using DataTable = System.Data.DataTable;
using word = Microsoft.Office.Interop.Word;
using static System.Windows.Forms.LinkLabel;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms.VisualStyles;

namespace Pile_Designer
{

    public partial class Form1 : Form
    {
        List<Pile> piles = new List<Pile>();
        List<Beam> beams = new List<Beam>();
        List<LineLoad> lineLoads = new List<LineLoad>();
        int scale = 1;

        DataTable pilesGcode = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }       

        private void pile_reactions_update()
        {
            // set all back to 0
            foreach (Pile p in piles)
            {
               p.reaction = p.reaction * 0;
            }
            foreach (Beam b in beams)
            {
                // piles sls only
                piles[b.p1].reaction += b.R.sls;
                piles[b.p2].reaction += b.R.sls;
            }
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
            foreach (Pile p in piles)
            {
                minX = Math.Min(minX, (int)p.x);
                minY = Math.Min(minY, (int)p.y);

                maxX = Math.Max(maxX, (int)p.x);
                maxY = Math.Max(maxY, (int)p.y);
            }
            int dX = maxX - minX;
            int dY = maxY - minY;
            int d = Math.Max(dX, dY); // difference between furthest points
            float baseScale = 375;
            scale = (int)((baseScale / d) * float.Parse(userScale.Text));

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
                        Rectangle rect = new Rectangle((int)p.x * scale, (int)p.y * scale, 10, 10);
                        g.FillEllipse(new SolidBrush(Color.Red), rect);

                        // label
                        g.DrawString(p.name, font, whiteBrush, (int)p.x * scale + 8, (int)p.y * scale + 8);
                    }
                    // draw beams and label
                    foreach (Beam b in beams)
                    {
                        Point point1 = new Point((int)piles[b.p1].x * scale + 5, (int)piles[b.p1].y * scale + 5);
                        Point point2 = new Point((int)piles[b.p2].x * scale + 5, (int)piles[b.p2].y * scale + 5);
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
            int printDecimalPoints = 2;

            output.Clear();

            // create fonts
            Font font = new Font("Arial", 10);
            Font subHeading = new Font("Arial", 10, FontStyle.Bold);
            Font heading = new Font("Arial", 12, FontStyle.Bold);

            //Line Loads
            output.SelectionFont = heading;
            output.AppendText("Line Loads:\n");
            foreach (LineLoad ll in lineLoads)
            {
                output.SelectionFont = subHeading;
                output.AppendText(ll.name + "\n");

                output.SelectionFont = font;
                output.AppendText("w = " + ll.w + "\n");
            }

            //Piles
            output.SelectionFont = heading;
            output.AppendText("Piles:\n");
            foreach (Pile p in piles)
            {
                output.SelectionFont = subHeading;
                output.AppendText(p.name + "\n");

                output.SelectionFont = font;
                output.AppendText("Reaction = " + p.reaction + "kN (SLS)\n" + // piles sls only
                                    "Capacity = " + p.capacity + "kN (SLS)\n\n"); 
            }

            //Beams
            output.SelectionFont = heading;
            output.AppendText("Beams:\n");
            foreach (Beam b in beams)
            {
                output.SelectionFont = subHeading;
                output.AppendText(b.name + "\n");

                output.SelectionFont = font;
                output.AppendText("w =" + lineLoads[b.ll].w + "\n" +
                                    "Span = " + Math.Round(b.span, printDecimalPoints) + "m\n" +
                                    "W = " + b.W + "\n" +
                                    "R = " + b.R + "\n" +
                                    "BM = " + b.BM + "kNm (ULS)\n"); // bm uls only
            }
        }

        private void scaleChanged(object sender, EventArgs e)
        {
            draw();
        }

        private void saveButton_Clicked(object sender, EventArgs e)
        {
            string filePath = getFilePath("zak");

            // save all design data to a file within the data folder
            saveToFile(dataGridViewPiles, filePath);
        }
        private void loadButton_Clicked(object sender, EventArgs e)
        {
            string filePath = getFilePath("zak");
            loadFromFile(dataGridViewPiles, filePath);

            // use the new dataGrids to update all classes 
            update_all();
        }

        private string getFilePath(string extension)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = $"{extension} files (*.{extension})|*.{extension}|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    Exception exception = new Exception("Can't get file!");                    
                } 
                //Get the path of specified file
                return openFileDialog.FileName;
            }
        }
        // Save datagridview in binary to a file within the local directory
        private void saveToFile(DataGridView dgv, string path)
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                bw.Write(dgv.Columns.Count);
                bw.Write(dgv.Rows.Count);
                foreach (DataGridViewRow dgvR in dgv.Rows)
                {
                    for (int j = 0; j < dgv.Columns.Count; ++j)
                    {
                        object val = dgvR.Cells[j].Value;
                        if (val == null)
                        {
                            bw.Write(false);
                            bw.Write(false);
                        }
                        else
                        {
                            bw.Write(true);
                            bw.Write(val.ToString());
                        }
                    }
                }
            }
        }

        // update data contents of data grid view from file
        private void loadFromFile(DataGridView dgv, string path)
        {
            // parse the file
            using (BinaryReader bw = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                int n = bw.ReadInt32();
                int m = bw.ReadInt32();
                for (int i = 0; i < m; ++i)
                {
                    dgv.Rows.Add();
                    for (int j = 0; j < n; ++j)
                    {
                        if (bw.ReadBoolean())
                        {
                            dgv.Rows[i].Cells[j].Value = bw.ReadString();
                        }
                        else bw.ReadBoolean();
                    }
                }
            }
        }

        private void exportButton_Clicked(object sender, EventArgs e)
        {
            // open Microsoft Word  
            Microsoft.Office.Interop.Word.Application app = new word.Application();
            app.Visible = true;

            // save the contents of output text box to an rtf file
            object path = AppDomain.CurrentDomain.BaseDirectory + @"\Pile CalcPad.rtf";
            output.SaveFile((string)path);

            // open the rtf file inside of Microsoft Word  
            object typeMissing = Type.Missing;
            object trueIndicator = true;
            var doc = app.Documents.Open(ref path);

            // add the image to the file
            word.Range docRange = doc.Range(0,0);
            var image = pictureBox1.Image;

            Clipboard.SetImage(image);
            docRange.Paste();
            docRange.InsertBefore("Pile & Ground Beam Calculations\n\n");
            docRange.InsertAfter("\n\n");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// Input ========================
        
        private void pile_update()
        {
            piles.Clear();
            for (int i = 0; i<dataGridViewPiles.Rows.Count - 1; i++)
            {
                float x, y;
                if (float.TryParse(dataGridViewPiles.Rows[i].Cells[0].Value?.ToString(), out x) && float.TryParse(dataGridViewPiles.Rows[i].Cells[1].Value?.ToString(), out y))
                {
                    string name = "P" + (i + 1);
                    piles.Add(new Pile(x, y, name));
                }
            }
        }

        private void beam_update()
        {
            beams.Clear();
            for (int i = 0; i < dataGridViewBeams.Rows.Count - 1; i++)
            {
                string ll = dataGridViewBeams.Rows[i].Cells[2].Value?.ToString();
                int p1, p2;           
                if (int.TryParse(dataGridViewBeams.Rows[i].Cells[0].Value?.ToString(), out p1) 
                    && int.TryParse(dataGridViewBeams.Rows[i].Cells[1].Value?.ToString(), out p2)
                    && !string.IsNullOrEmpty(ll)) // string check is not needed but adds clarity
                {            
                    // decrement to become indexs
                    p1--;
                    p2--;

                    // check indexs are in bounds & line load ref exists
                    if (checkInbounds(p1, piles) 
                        && checkInbounds(p2, piles)
                        && checkKey(ll, lineLoads))
                    {
                        int llIndex = getIndexFromKey(ll, lineLoads);
                        // create beam
                        string name = "B" + (i + 1);
                        Beam b = new Beam(p1, p2, llIndex, name);

                        // pile 1 positions
                        float p1X = piles[p1].x;
                        float p1Y = piles[p1].y;

                        // pile 2 positions
                        float p2X = piles[p2].x;
                        float p2Y = piles[p2].y;

                        // update beam span, W and BM
                        b.span = getDistance(p1X, p1Y, p2X, p2Y);
                        b.W = b.span * lineLoads[b.ll].w;
                        b.R = b.W / 2;

                        // correct units
                        b.W.units = "kN";
                        b.R.units = "kN";
                        b.calcBM();

                        // add to list
                        beams.Add(b);
                    }
                }
            }
        }
        // gets distance between 2 points
        private float getDistance(float p1X, float p1Y, float p2X, float p2Y)
        {
            float dx = p2X - p1X;
            float dy = p2Y - p1Y;
            return (float)Math.Sqrt(dx * dx + dy * dy);
        }

        // check index is valid
        private bool checkInbounds<T>(int index, List<T> list)
        {
            if( 0 <= index && index < list.Count)
                return true;
            else
            return false;
        }

        // check line loads contain a line load with name == refName
        private bool checkKey(string refName, List<LineLoad> list)
        {
            foreach(var o in list)
            {
                if (o.name == refName)
                    return true;                
            }
            return false;
        }

        // returns the index of the object thats name matches refName
        private int getIndexFromKey(string refName, List<LineLoad> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].name == refName)
                    return i;
            }
            return -1;
        }

        private void line_update()
        {
            lineLoads.Clear();
            for (int i = 0; i < dataGridViewLines.Rows.Count - 1; i++)
            {
                string name = dataGridViewLines.Rows[i].Cells[0].Value?.ToString();
                int sls, uls;
                if (        !string.IsNullOrEmpty(name)
                            && int.TryParse(dataGridViewLines.Rows[i].Cells[1].Value?.ToString(), out sls)
                            && int.TryParse(dataGridViewLines.Rows[i].Cells[2].Value?.ToString(), out uls))
                {
                    LineLoad ll = new LineLoad(name, sls, uls);
                    lineLoads.Add(ll);            
                }
            }
        }

        private void update_all(object sender = null, EventArgs e = null)
        {
            // update objects
            line_update();
            pile_update();
            beam_update();

            // calculate pile reactions
            pile_reactions_update();

            // show objects on screen and calcs
            draw();
            updateOutput();
        }
    }    
}


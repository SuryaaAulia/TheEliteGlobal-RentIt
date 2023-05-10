using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentIt.View.RentPage
{
    public partial class rentPageView : Form
    {
        public rentPageView()
        {
            InitializeComponent();
            dragfile.BorderStyle = BorderStyle.None;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void redBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bottomPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void twitter_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 2);
            pen.DashStyle = DashStyle.Dash;

            Rectangle rect = new Rectangle(10, 10, 685, 175);
            e.Graphics.DrawRectangle(pen, rect);

            pen.Dispose();
        }

        private void dragfile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                pictureBox4.Visible = false;
                label10.Visible = false;
            }


            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    string extension = Path.GetExtension(file).ToLower();
                    if (extension == ".jpg" || extension == ".png" || extension == ".pdf"
                        || extension == ".doc" || extension == ".docx" || extension == ".zip")
                    {
                        e.Effect = DragDropEffects.Copy;
                    }
                }
            }
        }

        private void dragfile_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (!dragfile.Items.Contains(Path.GetFileName(file)))
                {
                    dragfile.Items.Add(Path.GetFileName(file));
                }
            }
        }

        private void dragfile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void dragfile_DragLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            label1.Visible = true;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}

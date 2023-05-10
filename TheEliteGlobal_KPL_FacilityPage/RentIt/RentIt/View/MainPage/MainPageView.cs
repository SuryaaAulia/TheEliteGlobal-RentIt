using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentIt
{
    public partial class MainPageView : Form
    {
        private Rectangle orForm;

        private Rectangle orLab1;
        private Rectangle orLab3;
        private Rectangle orLab5;
        private Rectangle orLab4;
        private Rectangle orLab6;
        private Rectangle orBut1;
        private Rectangle orPan1;
        private float orLab1Size;
        private float orPan1Size;
        private float orBut1Size;
        private float orLab3Size;
        private float orLab4Size;
        private float orLab5Size;
        private float orLab6Size;

        private float fontScale = 1.3f;
        private float fontScaleAdd = 1f;
        public MainPageView()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            orForm = new Rectangle(this.Location, this.Size);
            orLab1 = new Rectangle(mainText.Location, mainText.Size);
            orLab3 = new Rectangle(alamat.Location, alamat.Size);
            orLab4 = new Rectangle(SignIn.Location, SignIn.Size);
            orLab5 = new Rectangle(kontak.Location, kontak.Size);
            orBut1 = new Rectangle(SignInBut.Location, SignInBut.Size);
            orLab6 = new Rectangle(loginMssg.Location, loginMssg.Size);
            orPan1 = new Rectangle(panelFasil.Location, panelFasil.Size);
            orLab1Size = mainText.Font.Size;
            orLab3Size = alamat.Font.Size;
            orLab5Size = kontak.Font.Size;
            orLab4Size = SignIn.Font.Size;
            orLab6Size = loginMssg.Font.Size;
            orBut1Size = SignInBut.Font.Size;
            orPan1Size = panelFasil.Font.Size;

            mainText.Parent = backgroundPic;
            alamat.Parent = backgroundPic;
            kontak.Parent = backgroundPic;
            SignIn.Parent = backgroundPic;
            loginMssg.Parent = backgroundPic;

            mainText.BackColor = Color.Transparent;
            alamat.BackColor = Color.Transparent;
            kontak.BackColor = Color.Transparent;
            loginMssg.BackColor = Color.Transparent;
            SignIn.BackColor = Color.Transparent;

        }
        private void ResizeChildrenControl()
        {
            ResizeControl(mainText, orLab1, orLab1Size);
            ResizeControl(alamat, orLab3, orLab3Size);
            ResizeControl(kontak, orLab5, orLab5Size);
            ResizeControl(SignInBut, orBut1, orBut1Size);
            ResizeControl(panelFasil, orPan1, orPan1Size);
            ResizeControl(SignIn, orLab4, orLab4Size);
            ResizeControl(loginMssg, orLab6, orLab6Size);
        }
        private void ResizeControl(Control control, Rectangle orControl, float orFontSize)
        {
            float x = (float)this.ClientRectangle.Width / (float)orForm.Width;
            float y = (float)this.ClientRectangle.Height / (float)orForm.Height;
            float newX;
            float newY;
            float ratio = x;
            if (control != kontak)
            {
                newX = orControl.Location.X * x;
                newY = orControl.Location.Y * y * 1.329f;
            }
            else
            {
                newX = orControl.Location.X * 1.78f;
                newY = orControl.Location.Y * 1.95f;
            }

            control.Location = new Point((int)newX, (int)newY);
            control.Width = (int)(orControl.Width * x);
            control.Height = (int)(orControl.Height * y);

            if (!this.ClientRectangle.Contains(control.Bounds))
            {
                control.Location = orControl.Location;
            }

            if (x >= y)
            {
                ratio = y;
            }
            float newFontSize;
            if (control == alamat || control == kontak || control == SignInBut)
            {
                newFontSize = orFontSize * ratio * fontScaleAdd;
            }
            else
            {
                newFontSize = orFontSize * ratio * fontScale;
            }
            Font newFont = new Font(control.Font.FontFamily, newFontSize, control.Font.Style);
            control.Font = newFont;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginView f2 = new LoginView();
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginView f2 = new LoginView();
            f2.ShowDialog();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            ResizeChildrenControl();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/telkomuniversity");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/telkomuniversity/");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/school/telkom-university/");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/UnivTelkom?s=20");
        }
        private void roundedButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginView f2 = new LoginView();
            f2.Show();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RentIt
{
    public partial class LoginView : Form
    {
        private Rectangle orForm;
        private Rectangle orPan1;

        private Rectangle orLab1;
        private Rectangle orLab2;
        private Rectangle orLab3;
        private Rectangle orLab4;
        private float orSizeLab1;
        private float orSizeLab2;
        private float orSizeLab3;
        private float orSizeLab4;

        private Rectangle orText1;
        private Rectangle orText2;
        private float orSizeText1;
        private float orSizeText2;

        private Rectangle orBut1;
        private float orSizeBut1;

        private Rectangle orPic1;
        private Rectangle orPic2;

        private float fontScale = 1.3f;
        public LoginView()
        {
            InitializeComponent();
        }
        private void ResizeChildrenControl()
        {
            ResizeControl(roundedPanel1, orPan1);
            ResizeControl(user, orLab1, orSizeLab1);
            ResizeControl(Pass, orLab2, orSizeLab2);
            ResizeControl(userInput, orText1, orSizeText1);
            ResizeControl(passInput, orText2, orSizeText2);
            ResizeControl(signIn, orBut1, orSizeBut1);
            ResizeControl(topLogo, orPic1);
            ResizeControl(pictureBox1, orPic2);
            ResizeControl(errorMsgUser, orLab3, orSizeLab3);
            ResizeControl(errorMsgPass, orLab4, orSizeLab4);

        }
        private void ResizeControl(Control control, Rectangle orControl, [Optional] float orFontSize)
        {
            float x = (float)this.ClientRectangle.Width / (float)orForm.Width;
            float y = (float)this.ClientRectangle.Height / (float)orForm.Height;
            float newX;
            float newY;
            float ratio = x;

            newX = orControl.Location.X * x;
            newY = orControl.Location.Y * y;

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
            if (control != roundedPanel1 && control != topLogo && control != pictureBox1)
            {
                newFontSize = orFontSize * ratio * fontScale;
                Font newFont = new Font(control.Font.FontFamily, newFontSize, control.Font.Style);
                control.Font = newFont;
            }
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            orForm = new Rectangle(this.Location, this.Size);
            orPan1 = new Rectangle(roundedPanel1.Location, roundedPanel1.Size);

            orLab1 = new Rectangle(user.Location, user.Size);
            orText1 = new Rectangle(userInput.Location, userInput.Size);
            orText2 = new Rectangle(passInput.Location, passInput.Size);
            orLab2 = new Rectangle(Pass.Location, Pass.Size);
            orLab3 = new Rectangle(errorMsgUser.Location, errorMsgUser.Size);
            orLab4 = new Rectangle(errorMsgPass.Location, errorMsgPass.Size);

            orSizeLab1 = user.Font.Size;
            orSizeLab2 = Pass.Font.Size;
            orSizeLab3 = errorMsgUser.Font.Size;
            orSizeLab4 = errorMsgPass.Font.Size;
            orSizeText2 = passInput.Font.Size;
            orSizeText1 = userInput.Font.Size;

            orBut1 = new Rectangle(signIn.Location, signIn.Size);
            orSizeBut1 = signIn.Font.Size;

            orPic1 = new Rectangle(topLogo.Location, topLogo.Size);
            orPic2 = new Rectangle(pictureBox1.Location, pictureBox1.Size);

        }

        private void LoginView_Resize(object sender, EventArgs e)
        {
            ResizeChildrenControl();
        }

        private void panduan_Click(object sender, EventArgs e)
        {

        }

        private void userInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (userInput.Text == "")
                {
                    userInput.Text = "username@telkomuniversity.ac.id or username@student.telkomuniversity.ac.id";
                }
                userInput.ForeColor = Color.Black;
                errorMsgUser.Visible = false;
            }
            catch {

            }
        }
        private void signIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (userInput.Text == "username@telkomuniversity.ac.id or username@student.telkomuniversity.ac.id" || !userInput.Text.Contains("@"))
                {
                    throw new Exception("Enter a valid email address, phone number, or Skype name.");
                }
                if (!userInput.Text.Contains("telkomuniversity.ac.id"))
                {
                    throw new Exception("User input is not a valid Telkom University email address.");
                }

            }
            catch (Exception ex)
            {
                errorMsgUser.Text = ex.Message;
                errorMsgUser.Visible = true;
            }
            

        }

        private void passInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (passInput.Text == "")
                {
                    passInput.Text = "Password";
                }
                passInput.ForeColor = Color.Black;
                passInput.PasswordChar = '*';
                errorMsgPass.Visible = false;
            }
            catch
            {

            }
        }

        private void errorMsgUser_Click(object sender, EventArgs e)
        {

        }

        private void errorMsgPass_Click(object sender, EventArgs e)
        {

        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void topLogo_Click(object sender, EventArgs e)
        {

        }
    }
}

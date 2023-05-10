namespace RentIt
{
    partial class LoginView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.redBox = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roundedPanel1 = new RoundedPanel();
            this.errorMsgPass = new System.Windows.Forms.Label();
            this.errorMsgUser = new System.Windows.Forms.Label();
            this.signIn = new System.Windows.Forms.Button();
            this.passInput = new System.Windows.Forms.TextBox();
            this.userInput = new System.Windows.Forms.TextBox();
            this.topLogo = new System.Windows.Forms.PictureBox();
            this.Pass = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panduan = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // redBox
            // 
            this.redBox.BackColor = System.Drawing.Color.DarkRed;
            this.redBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.redBox.Location = new System.Drawing.Point(0, 0);
            this.redBox.Name = "redBox";
            this.redBox.Size = new System.Drawing.Size(1053, 45);
            this.redBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::RentIt.Properties.Resources.babi;
            this.pictureBox1.Location = new System.Drawing.Point(437, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundedPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roundedPanel1.Controls.Add(this.errorMsgPass);
            this.roundedPanel1.Controls.Add(this.errorMsgUser);
            this.roundedPanel1.Controls.Add(this.signIn);
            this.roundedPanel1.Controls.Add(this.passInput);
            this.roundedPanel1.Controls.Add(this.userInput);
            this.roundedPanel1.Controls.Add(this.topLogo);
            this.roundedPanel1.Controls.Add(this.Pass);
            this.roundedPanel1.Controls.Add(this.panel1);
            this.roundedPanel1.Controls.Add(this.user);
            this.roundedPanel1.Location = new System.Drawing.Point(218, 179);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(613, 329);
            this.roundedPanel1.TabIndex = 2;
            this.roundedPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedPanel1_Paint);
            // 
            // errorMsgPass
            // 
            this.errorMsgPass.AutoSize = true;
            this.errorMsgPass.ForeColor = System.Drawing.Color.Red;
            this.errorMsgPass.Location = new System.Drawing.Point(188, 183);
            this.errorMsgPass.Name = "errorMsgPass";
            this.errorMsgPass.Size = new System.Drawing.Size(140, 13);
            this.errorMsgPass.TabIndex = 8;
            this.errorMsgPass.Text = "Please enter your password.";
            this.errorMsgPass.Visible = false;
            this.errorMsgPass.Click += new System.EventHandler(this.errorMsgPass_Click);
            // 
            // errorMsgUser
            // 
            this.errorMsgUser.AutoSize = true;
            this.errorMsgUser.ForeColor = System.Drawing.Color.Red;
            this.errorMsgUser.Location = new System.Drawing.Point(188, 116);
            this.errorMsgUser.Name = "errorMsgUser";
            this.errorMsgUser.Size = new System.Drawing.Size(35, 13);
            this.errorMsgUser.TabIndex = 7;
            this.errorMsgUser.Text = "label1";
            this.errorMsgUser.Visible = false;
            this.errorMsgUser.Click += new System.EventHandler(this.errorMsgUser_Click);
            // 
            // signIn
            // 
            this.signIn.BackColor = System.Drawing.Color.DarkRed;
            this.signIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signIn.Font = new System.Drawing.Font("Open Sans SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signIn.Location = new System.Drawing.Point(411, 197);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(81, 29);
            this.signIn.TabIndex = 6;
            this.signIn.Text = "Sign in";
            this.signIn.UseVisualStyleBackColor = false;
            this.signIn.Click += new System.EventHandler(this.signIn_Click);
            // 
            // passInput
            // 
            this.passInput.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passInput.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.passInput.Location = new System.Drawing.Point(185, 158);
            this.passInput.Name = "passInput";
            this.passInput.Size = new System.Drawing.Size(307, 22);
            this.passInput.TabIndex = 5;
            this.passInput.Text = "Password";
            this.passInput.TextChanged += new System.EventHandler(this.passInput_TextChanged);
            // 
            // userInput
            // 
            this.userInput.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInput.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.userInput.Location = new System.Drawing.Point(185, 90);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(307, 22);
            this.userInput.TabIndex = 4;
            this.userInput.Text = "username@telkomuniversity.ac.id or username@student.telkomuniversity.ac.id";
            this.userInput.TextChanged += new System.EventHandler(this.userInput_TextChanged);
            // 
            // topLogo
            // 
            this.topLogo.Image = global::RentIt.Properties.Resources.logo2;
            this.topLogo.Location = new System.Drawing.Point(117, 15);
            this.topLogo.Name = "topLogo";
            this.topLogo.Size = new System.Drawing.Size(86, 40);
            this.topLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topLogo.TabIndex = 3;
            this.topLogo.TabStop = false;
            this.topLogo.Click += new System.EventHandler(this.topLogo_Click);
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.Location = new System.Drawing.Point(90, 155);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(78, 22);
            this.Pass.TabIndex = 2;
            this.Pass.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.panduan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 90);
            this.panel1.TabIndex = 1;
            // 
            // panduan
            // 
            this.panduan.AutoSize = true;
            this.panduan.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panduan.Location = new System.Drawing.Point(89, 10);
            this.panduan.Name = "panduan";
            this.panduan.Size = new System.Drawing.Size(403, 68);
            this.panduan.TabIndex = 0;
            this.panduan.Text = "Silakan gunakan username@telkomuniversity.ac.id \r\ndan password sesuai iGracias Te" +
    "lkom University untuk TPA/Dosen dan \r\nusername@student.telkomuniversity.ac.id \r\n" +
    "untuk Mahasiswa";
            this.panduan.Click += new System.EventHandler(this.panduan_Click);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(89, 90);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(85, 22);
            this.user.TabIndex = 0;
            this.user.Text = "Username";
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 647);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.redBox);
            this.Name = "LoginView";
            this.Text = "Password";
            this.Load += new System.EventHandler(this.LoginView_Load);
            this.Resize += new System.EventHandler(this.LoginView_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel redBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label panduan;
        private System.Windows.Forms.PictureBox topLogo;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Button signIn;
        private System.Windows.Forms.Label errorMsgPass;
        private System.Windows.Forms.Label errorMsgUser;
    }
}
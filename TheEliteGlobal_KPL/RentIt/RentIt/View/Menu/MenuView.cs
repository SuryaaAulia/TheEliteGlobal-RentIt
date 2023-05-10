using RentIt.CariGedungController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentIt.View.Menu
{
    public partial class MenuView : Form
    {
        public MenuView()
        {
            InitializeComponent();
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Kelas kelas = new Kelas();
            addUserControls(kelas);
        }
        private void addUserControls(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Gedung gedung = new Gedung();
            addUserControls(gedung);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Olahraga guna = new Olahraga();
            addUserControls(guna);
        }
    }
}

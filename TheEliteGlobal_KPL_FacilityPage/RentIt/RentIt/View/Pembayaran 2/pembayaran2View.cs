using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentIt.View.Pembayaran_2
{
    public partial class pembayaran2View : Form
    {
        public pembayaran2View()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {

        }

        private void facility_Click(object sender, EventArgs e)
        {

        }

        private void facebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/telkomuniversity");
        }

        private void instagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/telkomuniversity/");
        }

        private void linkedin_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/school/telkom-university/");
        }

        private void twitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/UnivTelkom?s=20");
        }
    }
}

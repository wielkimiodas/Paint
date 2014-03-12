using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MdsPaint.View
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            Process.Start(linkLabel1.Text);
        }
    }
}
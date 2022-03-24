using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cabio_Win_App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /*
         *با استفاده از این متد پنجره معرفی نامه برنامه باز میشود
         */

        private void AboutCabio_Click(object sender, EventArgs e)
        {   
            AboutCabio about = new AboutCabio();
            //about.MdiParent = this;
            about.Show();

        }
        /*
         * با استفاده از این متد پنجره معرفی نامه و بی ام ای  باز میشود
         */
        private void BmiHelp_Click(object sender, EventArgs e)
        {
            BmiHelp helpForm = new BmiHelp();
            helpForm.Show();
        }
        /*
         * با استفاده از این متد پنجره محاسبه بی ام ای بدن باز میشود
         */
        private void BmiCal_Click(object sender, EventArgs e)
        {
            BMICalForm calForm = new BMICalForm();
            calForm.Show();
        }
    }
}

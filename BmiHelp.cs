using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cabio_Win_App
{
    public partial class BmiHelp : Form
    {
        int no;
        static int total = 8; //تعداد تصاویر راهنما را مشخص میکند 
        Image[] imageList = new Image[total]; //ارایه که تصاویر راهنمای بی ام ای را نگه داری میکند 

        /*
         * در متد سازنده این کلاس تصاویر راهنما در ارایه ای از تصاویر بارگذاری میشود 
         */
        public BmiHelp()

        {
            InitializeComponent();
            imageList[0] = Cabio_Win_App.Properties.Resources._1;
            imageList[1] = Cabio_Win_App.Properties.Resources._2;
            imageList[2] = Cabio_Win_App.Properties.Resources._3;
            imageList[3] = Cabio_Win_App.Properties.Resources._4;
            imageList[4] = Cabio_Win_App.Properties.Resources._5;
            imageList[5] = Cabio_Win_App.Properties.Resources._6;
            imageList[6] = Cabio_Win_App.Properties.Resources._7;
            imageList[7] = Cabio_Win_App.Properties.Resources._8;
        }


        /*
         * این متد در لحظه بارگذاری فرم راهنما باعث نمایش تصویر راهنمای اول میشود 
         */
        private void BmiHelp_Load(object sender, EventArgs e)
        {

            HelpImageBox.BackgroundImage = imageList[0];
            no = 1;
            PageNumber.Text = no + " از " + total;
        }
        /*
         * با استفاده از این متد تصویر راهنمای اول بارگذرای میشود
         */
        private void FirstButton_Click(object sender, EventArgs e)
        {
            HelpImageBox.BackgroundImage = imageList[0];
            no = 1;
            PageNumber.Text = no + " از " + total;
        }
        /*
         * بااستفاده از این متد تصویر راهنمای اخر بارگذاری میشود
         */
        private void LastButton_Click(object sender, EventArgs e)
        {
            HelpImageBox.BackgroundImage = imageList[7];
            no = 8;
            PageNumber.Text = no + " از " + total;
        }
        /*
         * با استفاده از این متد تصویر راهنمای بعدی بارگذاری میشود
         */
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (no < 8)
            {
                no = no + 1;
                HelpImageBox.BackgroundImage = imageList[no - 1];
                PageNumber.Text = no + " از " + total;
            }

        }
        /*
         * با استفاده از این متد تصویر راهنمای قبلی بارگذاری میشود
         */
        private void PreButton_Click(object sender, EventArgs e)
        {
            if (no >= 1)
            {
                no = no - 1;
                HelpImageBox.BackgroundImage = imageList[no];
                PageNumber.Text = (no +1) + " از " + total;
            }
           
        }
        /*
         * از این متد برای بستن پنجره استفاده میشود
         */
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

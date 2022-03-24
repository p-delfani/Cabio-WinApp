using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabio_Win_App
{
    public partial class SplashForm : Form
    {

        Timer timer; //این متغیر به منظور شروع و پایان تایمر پنجره اسپلش میباشد

        public SplashForm()
        {
            InitializeComponent();
        }
         
        /*
         * این متد یکی از توابع اصلی پنچره اسپلش میباشد 
         * که بعد از ظاهر شدن پنجره اسپلش اقدام به تنظیمات اولیه 
         * تایمر و استارت زدن ان میکند 
         */
        private void SplashForm_Shown(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 3000; // مدت زمان نمایش پنجره اسپلش بر حسب میلی ثانیه
            timer.Start();
            timer.Tick += TimerTick_Tick;

        }

        /*
         * این متد متد اصلی ابزار تایمر میباشد که بعد از طی شدن
         * مدت زمان سه ثانیه ای که در متد Shown پنجره اسپلش 
         * اقدام به متوقف کردن تایمر و نمایش پنجره اصلی برنامه میکند 
         */
        private void TimerTick_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            MainForm main = new MainForm(); //کلاس پنجره اصلی برنامه
            main.Show();
            this.Hide();
        }


    }
}

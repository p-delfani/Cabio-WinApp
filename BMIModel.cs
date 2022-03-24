using System;
using System.Collections.Generic;
using System.Text;

namespace Cabio_Win_App
{
    class BMIModel
    {
        public float weight; // این متغیر برای نگه داری وزن کاربر استفاده میشود 
        public float height; // این متغیر برای نگه داری قد کاربر استفاده میشود
        /*
         * این متد برای محاسبه بی ام ای سلامت افراد استفاده میشود  
         */
        public float calculateBMI()
        {
            return weight / (height * height);
        }
        /*
         * این متد به منظور تاییده خروجی عبارت فرمول بی ام ای استفاده میشود 
         */
        public string printBMI()
        {
            float result = this.calculateBMI();
            if (result <= 18.5)
            {
                return "وزن شما کم است";
            }

            else if (result > 18.5 && result <= 24.9)
            {
                return "وزن شما ایده ال است";
            }

            else if (result > 24.9 && result <= 29.9)
            {
                return "شما دارای اضافه وزن هستید";
            }

            else if (result > 29.9)
            {
                return "شما دارای چاقی مفرط هستید";
            }

            else
            {
                return "داده های ورودی معتبر نیست";
            }
        }
    }
}

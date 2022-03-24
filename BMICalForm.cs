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
    public partial class BMICalForm : Form
    {
        public BMICalForm()
        {
            InitializeComponent();
        }
        /*
         * این متد برای ارور دادن به کاربر است هنگامی که عدد قد و ورن خود را یه عدد 
         * غیر طبیعی میزند با این پیغام روبرو میشود مثلا اگر قد را 10000 و وزن را 4000 
         * وارد کند پیغامی مبنی بر صحیح نبودن قد و وزن دربافت خواهد کرد 
         */
        private void calculate_Click(object sender, EventArgs e)
        {

            BMIModel model = new BMIModel();
            try
            {
                model.height = float.Parse(height.Text);
                model.weight = float.Parse(weight.Text);
                result.Text = model.printBMI();
            }
            catch 
            {
                result.Text = "وزن و قد وارد شده صحیح نیست";
            }

        }
        /*
         * این متد برای خروج پنجره میباشد  
         */
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

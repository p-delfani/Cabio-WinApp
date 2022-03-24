
namespace Cabio_Win_App
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BmiHelp = new System.Windows.Forms.Button();
            this.BmiCal = new System.Windows.Forms.Button();
            this.AboutCabio = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.BackgroundImage = global::Cabio_Win_App.Properties.Resources.Man_Background_Box;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.BmiHelp);
            this.panel1.Controls.Add(this.BmiCal);
            this.panel1.Controls.Add(this.AboutCabio);
            this.panel1.Location = new System.Drawing.Point(-3, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 491);
            this.panel1.TabIndex = 0;
            // 
            // BmiHelp
            // 
            this.BmiHelp.Location = new System.Drawing.Point(483, 100);
            this.BmiHelp.Name = "BmiHelp";
            this.BmiHelp.Size = new System.Drawing.Size(202, 56);
            this.BmiHelp.TabIndex = 1;
            this.BmiHelp.Text = "راهنمای BMI";
            this.BmiHelp.UseVisualStyleBackColor = true;
            this.BmiHelp.Click += new System.EventHandler(this.BmiHelp_Click);
            // 
            // BmiCal
            // 
            this.BmiCal.Location = new System.Drawing.Point(483, 207);
            this.BmiCal.Name = "BmiCal";
            this.BmiCal.Size = new System.Drawing.Size(202, 56);
            this.BmiCal.TabIndex = 0;
            this.BmiCal.Text = "محاسبه BMI";
            this.BmiCal.UseVisualStyleBackColor = true;
            this.BmiCal.Click += new System.EventHandler(this.BmiCal_Click);
            // 
            // AboutCabio
            // 
            this.AboutCabio.BackColor = System.Drawing.Color.SandyBrown;
            this.AboutCabio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AboutCabio.Location = new System.Drawing.Point(18, 350);
            this.AboutCabio.Name = "AboutCabio";
            this.AboutCabio.Size = new System.Drawing.Size(93, 34);
            this.AboutCabio.TabIndex = 0;
            this.AboutCabio.Text = "درباره ی کابیو";
            this.AboutCabio.UseVisualStyleBackColor = false;
            this.AboutCabio.Click += new System.EventHandler(this.AboutCabio_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.BackgroundImage = global::Cabio_Win_App.Properties.Resources.Man_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(722, 400);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کابیو";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }




        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AboutCabio;
        private System.Windows.Forms.Button BmiHelp;
        private System.Windows.Forms.Button BmiCal;
    }
}
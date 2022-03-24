
namespace Cabio_Win_App
{
    partial class BmiHelp
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
            this.components = new System.ComponentModel.Container();
            this.HelpImageList = new System.Windows.Forms.ImageList(this.components);
            this.HelpImageBox = new System.Windows.Forms.PictureBox();
            this.FirstButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PreButton = new System.Windows.Forms.Button();
            this.LastButton = new System.Windows.Forms.Button();
            this.PageNumber = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HelpImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HelpImageList
            // 
            this.HelpImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.HelpImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.HelpImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // HelpImageBox
            // 
            this.HelpImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HelpImageBox.Location = new System.Drawing.Point(12, 35);
            this.HelpImageBox.Name = "HelpImageBox";
            this.HelpImageBox.Size = new System.Drawing.Size(578, 287);
            this.HelpImageBox.TabIndex = 0;
            this.HelpImageBox.TabStop = false;
            // 
            // FirstButton
            // 
            this.FirstButton.Location = new System.Drawing.Point(515, 331);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(75, 23);
            this.FirstButton.TabIndex = 1;
            this.FirstButton.Text = "صفحه اول ";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(433, 331);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "بعدی";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PreButton
            // 
            this.PreButton.Location = new System.Drawing.Point(93, 332);
            this.PreButton.Name = "PreButton";
            this.PreButton.Size = new System.Drawing.Size(75, 23);
            this.PreButton.TabIndex = 3;
            this.PreButton.Text = "قبلی";
            this.PreButton.UseVisualStyleBackColor = true;
            this.PreButton.Click += new System.EventHandler(this.PreButton_Click);
            // 
            // LastButton
            // 
            this.LastButton.Location = new System.Drawing.Point(12, 332);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(75, 23);
            this.LastButton.TabIndex = 4;
            this.LastButton.Text = "صفحه اخر";
            this.LastButton.UseVisualStyleBackColor = true;
            this.LastButton.Click += new System.EventHandler(this.LastButton_Click);
            // 
            // PageNumber
            // 
            this.PageNumber.AutoSize = true;
            this.PageNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PageNumber.Location = new System.Drawing.Point(282, 331);
            this.PageNumber.Name = "PageNumber";
            this.PageNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PageNumber.Size = new System.Drawing.Size(39, 21);
            this.PageNumber.TabIndex = 5;
            this.PageNumber.Text = "1از8";
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(560, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(29, 28);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "x";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("0 Titr Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(252, 5);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "راهنمای BMI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.UseWaitCursor = true;
            // 
            // BmiHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(602, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PageNumber);
            this.Controls.Add(this.LastButton);
            this.Controls.Add(this.PreButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.FirstButton);
            this.Controls.Add(this.HelpImageBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BmiHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BmiHelp";
            this.Load += new System.EventHandler(this.BmiHelp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HelpImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList HelpImageList;
        private System.Windows.Forms.PictureBox HelpImageBox;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PreButton;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.Label PageNumber;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
    }
}
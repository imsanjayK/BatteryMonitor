using System.Drawing;
using System.Windows.Forms;

namespace BatteryMonitor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
       

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelStatistic = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelPercent = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelFullLifetime = new System.Windows.Forms.Label();
            this.labelMode = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // timer1
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // progressBar1
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Minimum = 0;
            this.progressBar1.Maximum = 100;
            this.progressBar1.ForeColor = Color.White;
            this.progressBar1.Anchor = AnchorStyles.Bottom;
            this.progressBar1.Style = ProgressBarStyle.Continuous;
            this.progressBar1.Size = new System.Drawing.Size(266, 15);
            this.progressBar1.Location = new System.Drawing.Point(5, 57);

            // label1
            this.labelStatistic.Name = "labelStatistic";
            this.labelStatistic.AutoSize = true;
            this.labelStatistic.BackColor = Color.White;
            this.labelStatistic.Text = "Battery Statistics :";
            this.labelStatistic.Location = new System.Drawing.Point(5, 5);

            // label2
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.AutoSize = true;
            this.labelPercent.BackColor = Color.White;
            this.labelPercent.Anchor = AnchorStyles.Right;
            this.labelPercent.Location = new System.Drawing.Point(182, 5);

            // label3
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = Color.White;
            this.labelStatus.Anchor = AnchorStyles.Left;
            this.labelStatus.Location = new System.Drawing.Point(5, 23);
          

            // label4
            this.labelMode.Name = "labelMode";
            this.labelMode.AutoSize = true;
            this.labelMode.BackColor = Color.White;
            this.labelMode.Anchor = AnchorStyles.Right;
            this.labelMode.Location = new System.Drawing.Point(164, 23);


            // label5
            this.labelTime.Name = "labelTime";
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = Color.White;
            this.labelTime.Anchor = AnchorStyles.Left;
            this.labelTime.Location = new System.Drawing.Point(5, 40);

            // label6 
            this.labelFullLifetime.Name = "labelFullLifetime";
            this.labelFullLifetime.AutoSize = true;
            this.labelFullLifetime.BackColor = Color.White;
            this.labelFullLifetime.Anchor = AnchorStyles.Right;
            this.labelFullLifetime.Location = new System.Drawing.Point(165, 40);

            



            //form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 77);
            this.Name = "Form1";
            this.Text = "[BM] Battery Monitor";
            this.BackColor = Color.WhiteSmoke;
            this.ForeColor = Color.DarkGreen;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelStatistic);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.labelPercent);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelFullLifetime);

            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelStatistic;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelFullLifetime;

    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatteryMonitor
{
    public partial class Form1 : Form
    {
        private PowerStatus power;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.power = SystemInformation.PowerStatus;
            var ChargePercent = Math.Round(power.BatteryLifePercent*100);

            this.progressBar1.Value = int.Parse(ChargePercent.ToString());

            var ChargeStatus = power.BatteryChargeStatus;
            var FullLifetime = power.BatteryFullLifetime / 60;
            var LifeRemaining = power.BatteryLifeRemaining / 60;
            var LineStatus = power.PowerLineStatus;

            this.labelStatus.Text = $"Charge Status: {ChargeStatus.ToString()}";
            this.labelPercent.Text = $"Battery Life: {ChargePercent}%\n";
            this.labelTime.Text = $"Time Remaining: {LifeRemaining} minutes\n";
            this.labelFullLifetime.Text = $"Battery Life: {FullLifetime}\n";
            this.labelMode.Text = $"Power Mode: {LineStatus}\n";

            //Default setting
            this.BackColor = Color.FromArgb(181, 255, 167); // green

            this.labelFullLifetime.Visible = false;
            //this.labelTime.Visible = false;
            switch (ChargeStatus)
            {
                case BatteryChargeStatus.High:
                    this.labelStatus.ForeColor = Color.DarkRed;
                    this.BackColor = Color.FromArgb(181, 255, 167);

                    break;
                case BatteryChargeStatus.High | BatteryChargeStatus.Charging: // > 67% 
                    Console.Beep();
                    this.labelStatus.ForeColor = Color.Red;
                    this.labelFullLifetime.Visible = false;
                    this.labelTime.Visible = false;
                    this.BackColor = Color.Red;
                    if (ChargePercent > 90)
                    {
                        Console.Beep();
                        this.labelStatus.ForeColor = Color.Red;
                    }
                    break;
                case BatteryChargeStatus.Low:
                    this.BackColor = Color.FromArgb(255, 223, 18); //orange
                    this.labelTime.Visible = true;
                    this.labelTime.BackColor = Color.White;
                    if (ChargePercent <= 20)
                    {
                        Console.Beep();
                        this.labelStatus.ForeColor = Color.Red;
                    }
                    break;
                case BatteryChargeStatus.Low | BatteryChargeStatus.Charging:
                    this.labelTime.Visible = false;
                    this.labelStatus.ForeColor = Color.DarkGreen;
                    break;
                case BatteryChargeStatus.Critical:
                    Console.Beep();
                    break;
                case BatteryChargeStatus.Charging:
                    this.labelFullLifetime.Visible = false;
                    this.labelTime.Visible = false;
                    break;
                case BatteryChargeStatus.NoSystemBattery:
                    break;
                case BatteryChargeStatus.Unknown:
                    break;
                default:

                    this.labelStatus.Text = $"Charge Status: Discharging";
                    break;
            }
        }
    }
}

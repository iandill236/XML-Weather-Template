using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            date1.Text = Form1.days[1].date;
            min1.Text = Form1.days[1].tempLow;
            max1.Text = Form1.days[1].tempHigh;

            date2.Text = Form1.days[2].date;
            min2.Text = Form1.days[2].tempLow;
            max2.Text = Form1.days[2].tempHigh;

            date3.Text = Form1.days[3].date;
            min3.Text = Form1.days[3].tempLow;
            max3.Text = Form1.days[3].tempHigh;

            double Condition1 = Convert.ToDouble(Form1.days[1].condition);
            if (Condition1 > 199 && Condition1 < 233)
            {
                iconBox1.Image = Properties.Resources.thunderstormIcon;
            }
            else if (Condition1 > 299 && Condition1 < 322)
            {
                iconBox1.Image = Properties.Resources.rainIcon;
            }
            else if (Condition1 > 499 && Condition1 < 532)
            {
                iconBox1.Image = Properties.Resources.rainIcon;
            }
            else if (Condition1 > 599 && Condition1 < 623)
            {
                iconBox1.Image = Properties.Resources.snowIcon;
            }
            else if (Condition1 > 700 && Condition1 < 742)
            {
                iconBox1.Image = Properties.Resources.mistIcon;
            }
            else if (Condition1 > 750 && Condition1 < 762)
            {
                iconBox1.Image = Properties.Resources.mistIcon;
            }
            else if (Condition1 == 762)
            {
                iconBox1.Image = Properties.Resources.mistIcon;
            }
            else if (Condition1 == 771)
            {
                iconBox1.Image = Properties.Resources.snowIcon;
            }
            else if (Condition1 == 800)
            {
                iconBox1.Image = Properties.Resources.clearicon;
            }
            else if (Condition1 > 800 && Condition1 < 805)
            {
                iconBox1.Image = Properties.Resources.cloudyIcon;
            }

            double Condition2 = Convert.ToDouble(Form1.days[2].condition);
            if (Condition2 > 199 && Condition2 < 233)
            {
                iconBox2.Image = Properties.Resources.thunderstormIcon;
            }
            else if (Condition2 > 299 && Condition2 < 322)
            {
                iconBox2.Image = Properties.Resources.rainIcon;
            }
            else if (Condition2 > 499 && Condition2 < 532)
            {
                iconBox2.Image = Properties.Resources.rainIcon;
            }
            else if (Condition2 > 599 && Condition2 < 623)
            {
                iconBox2.Image = Properties.Resources.snowIcon;
            }
            else if (Condition2 > 700 && Condition2 < 742)
            {
                iconBox2.Image = Properties.Resources.mistIcon;
            }
            else if (Condition2 > 750 && Condition2 < 762)
            {
                iconBox2.Image = Properties.Resources.mistIcon;
            }
            else if (Condition2 == 762)
            {
                iconBox2.Image = Properties.Resources.mistIcon;
            }
            else if (Condition2 == 771)
            {
                iconBox2.Image = Properties.Resources.snowIcon;
            }
            else if (Condition2 == 800)
            {
                iconBox2.Image = Properties.Resources.clearicon;
            }
            else if (Condition2 > 800 && Condition2 < 805)
            {
                iconBox2.Image = Properties.Resources.cloudyIcon;
            }

            double Condition3 = Convert.ToDouble(Form1.days[3].condition);
            if (Condition3 > 199 && Condition3 < 233)
            {
                iconBox3.Image = Properties.Resources.thunderstormIcon;
            }
            else if (Condition3 > 299 && Condition3 < 322)
            {
                iconBox3.Image = Properties.Resources.rainIcon;
            }
            else if (Condition3 > 499 && Condition3 < 532)
            {
                iconBox3.Image = Properties.Resources.rainIcon;
            }
            else if (Condition3 > 599 && Condition3 < 623)
            {
                iconBox3.Image = Properties.Resources.snowIcon;
            }
            else if (Condition3 > 700 && Condition3 < 742)
            {
                iconBox3.Image = Properties.Resources.mistIcon;
            }
            else if (Condition3 > 750 && Condition3 < 762)
            {
                iconBox3.Image = Properties.Resources.mistIcon;
            }
            else if (Condition3 == 762)
            {
                iconBox3.Image = Properties.Resources.mistIcon;
            }
            else if (Condition3 == 771)
            {
                iconBox3.Image = Properties.Resources.snowIcon;
            }
            else if (Condition3 == 800)
            {
                iconBox3.Image = Properties.Resources.clearicon;
            }
            else if (Condition3 > 800 && Condition3 < 805)
            {
                iconBox3.Image = Properties.Resources.cloudyIcon;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void ForecastScreen_Load(object sender, EventArgs e)
        {


            if (CurrentScreen.weatherid > 199 && CurrentScreen.weatherid < 233)
            {
                this.BackgroundImage = Properties.Resources.thunderstormImage;

            }
            else if (CurrentScreen.weatherid > 299 && CurrentScreen.weatherid < 322)
            {
                this.BackgroundImage = Properties.Resources.drizzleImage;

            }
            else if (CurrentScreen.weatherid > 499 && CurrentScreen.weatherid < 532)
            {
                this.BackgroundImage = Properties.Resources.rainImage;


            }
            else if (CurrentScreen.weatherid > 599 && CurrentScreen.weatherid < 623)
            {
                this.BackgroundImage = Properties.Resources.snowImage;
                label3.ForeColor = Color.Black;
                forecastLabel.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                date1.ForeColor = Color.Black;
                maxLabel.ForeColor = Color.Black;
                minLabel.ForeColor = Color.Black;
                max1.ForeColor = Color.Black;
                min1.ForeColor = Color.Black;
                date2.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                max2.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                min2.ForeColor = Color.Black;
                date3.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                max3.ForeColor = Color.Black;
                min3.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
            }
            else if (CurrentScreen.weatherid > 700 && CurrentScreen.weatherid < 742)
            {
                this.BackgroundImage = Properties.Resources.mistImage;

            }
            else if (CurrentScreen.weatherid > 750 && CurrentScreen.weatherid < 762)
            {
                this.BackgroundImage = Properties.Resources.sandImage;
            }
            else if (CurrentScreen.weatherid == 762)
            {
                this.BackgroundImage = Properties.Resources.volcanoImage;
            }
            else if (CurrentScreen.weatherid == 771)
            {
                this.BackgroundImage = Properties.Resources.squallImage;
                label3.ForeColor = Color.Black;
                forecastLabel.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                date1.ForeColor = Color.Black;
                maxLabel.ForeColor = Color.Black;
                minLabel.ForeColor = Color.Black;
                max1.ForeColor = Color.Black;
                min1.ForeColor = Color.Black;
                date2.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                max2.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                min2.ForeColor = Color.Black;
                date3.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                max3.ForeColor = Color.Black;
                min3.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
            }
            else if (CurrentScreen.weatherid == 781)
            {
                this.BackgroundImage = Properties.Resources.tornadoImage;
            }
            else if (CurrentScreen.weatherid == 800)
            {
                this.BackgroundImage = Properties.Resources.clearImage;
            }
            else if (CurrentScreen.weatherid > 800 && CurrentScreen.weatherid < 805)
            {
                this.BackgroundImage = Properties.Resources.cloudyImage;
            }
        }

        private void maxLabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void min1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

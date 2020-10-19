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
    public partial class CurrentScreen : UserControl
    {
        public static int weatherid = Convert.ToInt32(Form1.days[0].condition);
        string date = Form1.days[0].currentTime;


        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;
            tempLabel.Text = $"{Form1.days[0].currentTemp} º C";
            minOutput.Text = $"{Form1.days[0].tempLow} º C";
            maxOutput.Text = $"{Form1.days[0].tempHigh} º C";
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void tempLabel_Click(object sender, EventArgs e)
        {

        }

        private void CurrentScreen_Load(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("hh:mm: tt");
            dateLabel.Text = DateTime.Now.ToString("dddd");
            updateLabel.Text = Form1.days[0].currentTime;

            if (weatherid > 199 && weatherid < 233)
            {
                this.BackgroundImage = Properties.Resources.thunderstormImage;
                
            }
           else if (weatherid > 299 && weatherid < 322)
            {
                this.BackgroundImage = Properties.Resources.drizzleImage;
            }
           else if (weatherid > 499 && weatherid < 532)
            {
                this.BackgroundImage = Properties.Resources.rainImage;
            }
           else if (weatherid > 599 && weatherid < 623)
            {
                this.BackgroundImage = Properties.Resources.snowImage;
                label3.ForeColor = Color.Black;
                forecastLabel.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                cityOutput.ForeColor = Color.Black;
                tempLabel.ForeColor = Color.Black;
                minLabel.ForeColor = Color.Black;
                maxLabel.ForeColor = Color.Black;
                minOutput.ForeColor = Color.Black;
                maxOutput.ForeColor = Color.Black;
            }
           else if (weatherid > 700 && weatherid < 742)
            {
                this.BackgroundImage = Properties.Resources.mistImage;
            }
           else if (weatherid > 750 && weatherid < 762)
            {
                this.BackgroundImage = Properties.Resources.sandImage;
            }
           else if (weatherid == 762)
            {
                this.BackgroundImage = Properties.Resources.volcanoImage;
            }
           else if (weatherid == 771)
            {
                this.BackgroundImage = Properties.Resources.squallImage;
                label3.ForeColor = Color.Black;
                forecastLabel.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                cityOutput.ForeColor = Color.Black;
                tempLabel.ForeColor = Color.Black;
                minLabel.ForeColor = Color.Black;
                maxLabel.ForeColor = Color.Black;
                minOutput.ForeColor = Color.Black;
                maxOutput.ForeColor = Color.Black;
            }
           else if (weatherid == 781)
            {
                this.BackgroundImage = Properties.Resources.tornadoImage;
            }
           else if(weatherid == 800)
            {
                this.BackgroundImage = Properties.Resources.clearImage;
            }
           else if(weatherid > 800 && weatherid < 805)
            {
                this.BackgroundImage = Properties.Resources.cloudyImage;
            }
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void minOutput_Click(object sender, EventArgs e)
        {

        }

        private void minLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

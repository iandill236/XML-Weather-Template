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

        }
    }
}

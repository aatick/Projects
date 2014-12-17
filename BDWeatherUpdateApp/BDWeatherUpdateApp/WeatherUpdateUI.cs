using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDWeatherUpdateApp.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Linq;

namespace BDWeatherUpdateApp
{
    public partial class WeatherUpdateUI : Form
    {
        public WeatherUpdateUI()
        {
            InitializeComponent();
        }
        
        private void WeatherUpdateUI_Load(object sender, EventArgs e)
        {
            var today = DateTime.Now;
            var tomorrow = DateTime.Now.AddDays(1);
            var dayAfterTomorrow = DateTime.Now.AddDays(2);
            cityNamesComboBox.Text = cityNamesComboBox.Items[0].ToString();
            todayLabel.Text = "আজ" + "(" + convertToBanglaNumber(today.Day) + " " + convertMonthToBangla(today.Month) + ", " +
                              convertToBanglaNumber(today.Year) + ")";
            tomorrowLabel.Text = "আগামীকাল" + "(" + convertToBanglaNumber(tomorrow.Day) + " " + convertMonthToBangla(tomorrow.Month) + ", " +
                              convertToBanglaNumber(tomorrow.Year) + ")";
            dayAfterTomorrowLabel.Text = "পরশু" + "(" + convertToBanglaNumber(dayAfterTomorrow.Day) + " " + convertMonthToBangla(dayAfterTomorrow.Month) + ", " +
                              convertToBanglaNumber(dayAfterTomorrow.Year) + ")";
            var timer=new Timer();
            var refreshTimer = new Timer();
            refreshTimer.Interval = 30000;
            refreshTimer.Tick += refreshTimer_Tick;
            timer.Interval = 10;
            timer.Tick += timer_Tick;
            timer.Start();
            fillData("dhaka");
        }

        void refreshTimer_Tick(object sender, EventArgs e)
        {
            refreshData();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            digitalWatchLabel.Text = DateTime.Now.ToLongTimeString();
        }

        public string convertMonthToBangla(int monthNumber)
        {
            switch (monthNumber)
            {
                case 1:
                    return "জানুয়ারি";
                case 2:
                    return "ফেব্রুয়ারি";
                case 3:
                    return "মার্চ";
                case 4:
                    return "এপ্রিল";
                case 5:
                    return "মে";
                case 6:
                    return "জুন";
                case 7:
                    return "জুলাই";
                case 8:
                    return "আগস্ট";
                case 9:
                    return "সেপ্টেম্বর";
                case 10:
                    return "অক্টোবর";
                case 11:
                    return "নভেম্বর";
                default:
                    return "ডিসেম্বর";
            }
        }

        private void fillData(string cityName)
        {
            cityNameLabel.Height = 32;
            mornLabel.Visible =
                dayLabel.Visible =
                    eveLabel.Visible = nightLabel.Visible = maxLabel.Visible = minLabel.Visible = true;
            string url = @"http://api.openweathermap.org/data/2.5/forecast/daily?q="+cityName+@"%2Cbangladesh&mode=json&units=metric&cnt=3";
            WebClient webclient = new WebClient();
            string jsonDataString = string.Empty;
            try
            {
                jsonDataString = webclient.DownloadString(url);
                JsonData jData = new JsonData();
                if (jsonDataString != string.Empty)
                    jData = JsonConvert.DeserializeObject<JsonData>(jsonDataString);
                List[] jLists = new List[3];
                jLists = jData.list;
                int count = 0;
                var today = new Temp();
                var tomorrow = new Temp();
                var dayAfterTomorrow = new Temp();
                foreach (var list in jLists)
                {
                    count++;
                    if (count == 1)
                        today = list.temp;
                    else if (count == 2)
                        tomorrow = list.temp;
                    else
                        dayAfterTomorrow = list.temp;
                }
                todayMornLabel.Text = convertToBanglaNumber(today.morn) + "\u00B0সে.";
                todayDayLabel.Text = convertToBanglaNumber(today.day) + "\u00B0সে.";
                todayEveLabel.Text = convertToBanglaNumber(today.eve) + "\u00B0সে.";
                todayNightLabel.Text = convertToBanglaNumber(today.night) + "\u00B0সে.";
                todayMaxLabel.Text = convertToBanglaNumber(today.max) + "\u00B0সে.";
                todayMinLabel.Text = convertToBanglaNumber(today.min) + "\u00B0সে.";
                tomorrowMornLabel.Text = convertToBanglaNumber(tomorrow.morn) + "\u00B0সে.";
                tomorrowDayLabel.Text = convertToBanglaNumber(tomorrow.day) + "\u00B0সে.";
                tomorrowEveLabel.Text = convertToBanglaNumber(tomorrow.eve) + "\u00B0সে.";
                tomorrowNightLabel.Text = convertToBanglaNumber(tomorrow.night) + "\u00B0সে.";
                tomorrowMaxLabel.Text = convertToBanglaNumber(tomorrow.max) + "\u00B0সে.";
                tomorrowMinLabel.Text = convertToBanglaNumber(tomorrow.min) + "\u00B0সে.";
                dayAfterTomorrowMornLabel.Text = convertToBanglaNumber(dayAfterTomorrow.morn) + "\u00B0সে.";
                dayAfterTomorrowDayLabel.Text = convertToBanglaNumber(dayAfterTomorrow.day) + "\u00B0সে.";
                dayAfterTomorrowEveLabel.Text = convertToBanglaNumber(dayAfterTomorrow.eve) + "\u00B0সে.";
                dayAfterTomorrowNightLabel.Text = convertToBanglaNumber(dayAfterTomorrow.night) + "\u00B0সে.";
                dayAfterTomorrowMaxLabel.Text = convertToBanglaNumber(dayAfterTomorrow.max) + "\u00B0সে.";
                dayAfterTomorrowMinLabel.Text = convertToBanglaNumber(dayAfterTomorrow.min) + "\u00B0সে.";
            }
            catch(WebException ex)
            {
                mornLabel.Visible =
                    dayLabel.Visible =
                        eveLabel.Visible = nightLabel.Visible = maxLabel.Visible = minLabel.Visible = false;
                cityNameLabel.Height = 70;
                cityNameLabel.Text = "আপনার ইন্টারনেট সংযোগে সমস্যা ধরা পড়েছে।\nদয়া করে আপনার ইন্টারনেট সংযোগটি পরীক্ষা করুন। ";
                MessageBox.Show("আপনার ইন্টারনেট সংযোগে সমস্যা ধরা পড়েছে।\nদয়া করে আপনার ইন্টারনেট সংযোগটি পরীক্ষা করুন। ");
            }
            
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        public void refreshData()
        {
            switch (cityNamesComboBox.Text)
            {
                case "ঢাকা":
                    fillData("dhaka");
                    break;
                case "চট্টগ্রাম":
                    fillData("chittagong");
                    break;
                case "খুলনা":
                    fillData("khulna");
                    break;
                case "রাজশাহী":
                    fillData("rajshahi");
                    break;
                case "বরিশাল":
                    fillData("barisal");
                    break;
                case "সিলেট":
                    fillData("sylhet");
                    break;
                case "রংপুর":
                    fillData("rangpur");
                    break;
                case "বগুড়া":
                    fillData("bogra");
                    break;
                case "কুমিল্লা":
                    fillData("comilla");
                    break;
                case "সাতক্ষীরা":
                    fillData("satkhira");
                    break;
            }
        }

        private void cityNamesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityNameLabel.Text = cityNamesComboBox.Text + @" (বাংলাদেশ) শহরের আবহাওয়ার পূর্বাভাস";
            refreshData();
        }

        public string convertToBanglaNumber(float englishNumber)
        {
            string bengaliNumber = string.Empty;
            foreach (char c in englishNumber.ToString())
            {
                switch (c)
                {
                    case '1':
                        bengaliNumber += "১";
                        break;
                    case '2':
                        bengaliNumber += "২";
                        break;
                    case '3':
                        bengaliNumber += "৩";
                        break;
                    case '4':
                        bengaliNumber += "৪";
                        break;
                    case '5':
                        bengaliNumber += "৫";
                        break;
                    case '6':
                        bengaliNumber += "৬";
                        break;
                    case '7':
                        bengaliNumber += "৭";
                        break;
                    case '8':
                        bengaliNumber += "৮";
                        break;
                    case '9':
                        bengaliNumber += "৯";
                        break;
                    case '0':
                        bengaliNumber += "০";
                        break;
                    default:
                        bengaliNumber += c;
                        break;
                }
            }
            return bengaliNumber;
        }
        
    }
}

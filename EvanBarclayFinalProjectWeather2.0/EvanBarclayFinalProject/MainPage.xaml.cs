using System.Net;
using Newtonsoft.Json.Linq;

namespace EvanBarclayFinalProject;

public partial class MainPage : ContentPage
{
    string APIKEY = "88b37a1fe7a504ae34cacbdb8c24027a";
    public MainPage()
    {
        InitializeComponent();
    }
    public static string GetSimpleWindDirection(double degrees)
    {
        string[] cardinals = { "N", "NE", "E", "SE", "S", "SW", "W", "NW" };

        var index = (int)((degrees / 45) + 0.5);

        return cardinals[index % 8];
    }
    public static string GetTimeFromUnix(double unixTime)
    {
        DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds((long)unixTime);
        DateTime dateTime = dateTimeOffset.LocalDateTime;
        return dateTime.ToString("h:mm tt");
    }
    private void BtnShowTemp_Clicked(object sender, EventArgs e)
    {
        if (EntryZipCode.Text != null)
        {
            using (WebClient wc = new WebClient())
            {
                try
                {
                    wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                    string jsontext = wc.DownloadString($"http://api.openweathermap.org/data/2.5/weather?zip={EntryZipCode.Text}&appid={APIKEY}&units=imperial");
                    JObject jo = JObject.Parse(jsontext);
                    JObject main = JObject.Parse(jo["main"].ToString());
                    JObject wind = JObject.Parse(jo["wind"].ToString());
                    JObject sys = JObject.Parse(jo["sys"].ToString());
                    WeatherGV.CityName = jo["name"].ToString();
                    WeatherGV.CurTemp = double.Parse(main["temp"].ToString());
                    WeatherGV.MinTemp = double.Parse(main["temp_min"].ToString());
                    WeatherGV.MaxTemp = double.Parse(main["temp_max"].ToString());
                    WeatherGV.CurHum = double.Parse(main["humidity"].ToString());
                    WeatherGV.CurPres = double.Parse(main["pressure"].ToString());
                    WeatherGV.WindSpeed = double.Parse(wind["speed"].ToString());
                    WeatherGV.WindDir = GetSimpleWindDirection(double.Parse(wind["deg"].ToString()));
                    WeatherGV.WindDirDeg = double.Parse(wind["deg"].ToString());
                    WeatherGV.SunUp = double.Parse(sys["sunrise"].ToString());
                    WeatherGV.SunSet = double.Parse(sys["sunset"].ToString());
                    Navigation.PushAsync(new WeatherPage());
                }
                catch (Exception ex)
                {
                    DisplayAlert("Error", ex.Message, "Close");
                }
            }
        }
        else
        {
            DisplayAlert("Invalid Input", "Please enter a zip code", "Close");
        }
    }
}
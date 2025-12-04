using System.Net;
using Newtonsoft.Json.Linq;


namespace M07ParticipationStart;

public partial class MainPage : ContentPage
{
    string APIKEY = "88b37a1fe7a504ae34cacbdb8c24027a";
    public MainPage()
	{
		InitializeComponent();
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
                    WeatherGV.CityName = jo["name"].ToString();
                    WeatherGV.CurTemp = double.Parse(main["temp"].ToString());
                    WeatherGV.MinTemp = double.Parse(main["temp_min"].ToString());
                    WeatherGV.MaxTemp = double.Parse(main["temp_max"].ToString());
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

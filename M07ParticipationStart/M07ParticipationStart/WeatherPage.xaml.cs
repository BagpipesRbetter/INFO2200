namespace M07ParticipationStart;

public partial class WeatherPage : ContentPage
{
	public WeatherPage()
	{
		InitializeComponent();
        LblCity.Text = WeatherGV.CityName;
        LblCurTemp.Text = $"Current Temp: {WeatherGV.CurTemp}°F";
        LblHighTemp.Text = $"High Temp: {WeatherGV.MaxTemp}°F";
        LblLowTemp.Text = $"Low Temp: {WeatherGV.MinTemp}°F";
    }
}
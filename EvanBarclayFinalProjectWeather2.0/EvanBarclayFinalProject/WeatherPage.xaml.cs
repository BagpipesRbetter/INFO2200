namespace EvanBarclayFinalProject;

public partial class WeatherPage : ContentPage
{
	public WeatherPage()
	{
		InitializeComponent();
        LblCity.Text = WeatherGV.CityName;
        LblCurTemp.Text = $"Current Temp: {WeatherGV.CurTemp}°F";
        LblHighTemp.Text = $"High Temp: {WeatherGV.MaxTemp}°F";
        LblLowTemp.Text = $"Low Temp: {WeatherGV.MinTemp}°F";
        LblWindSpeed.Text = $"Wind Speed: {WeatherGV.WindSpeed} mph";
        LblWindDir.Text = $"Wind Direction: {WeatherGV.WindDir} @ {WeatherGV.WindDirDeg}°";
        LblHumidity.Text = $"Humidity: {WeatherGV.CurHum}%";
        LblPressure.Text = $"Pressure: {WeatherGV.CurPres} hpa";
        LblSunUp.Text = $"Sunrise: {DateTimeOffset.FromUnixTimeSeconds((long)WeatherGV.SunUp).ToLocalTime().ToString("h:mm tt")}";
        LblSunset.Text = $"Sunset: {DateTimeOffset.FromUnixTimeSeconds((long)WeatherGV.SunSet).ToLocalTime().ToString("h:mm tt")}";
    }
}
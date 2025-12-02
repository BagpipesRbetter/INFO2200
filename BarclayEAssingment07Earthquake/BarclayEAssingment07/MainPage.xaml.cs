using System.Net;
using Newtonsoft.Json.Linq;
namespace BarclayEAssingment07;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void BtnFind_Clicked(object sender, EventArgs e)
    {

        if (EnterStartDate.Text != "")
        {
            if (EnterEndDate.Text != "")
            {
                if (EnterEarthquakeSize.Text != "")
                {
                    // implement WebClient class from System.Net
                    using (WebClient wc = new WebClient())
                    {
                        try
                        {
                            wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                            string json = wc.DownloadString($"https://earthquake.usgs.gov/fdsnws/event/1/query?format=geojson&starttime={EnterStartDate.Text}&endtime={EnterEndDate.Text}&minmagnitude={EnterEarthquakeSize.Text}");
                            JObject jo = JObject.Parse(json);
                            JObject main = JObject.Parse(jo["metadata"].ToString());
                            JArray features = JArray.Parse(jo["features"].ToString());
                            JArray eQjArray = new JArray();
                            int count = 0;
                            int.TryParse(main["count"].ToString(), out count);
                            for (int i = 0; i < count; i++)
                            {
                                eQjArray.Add(features[i]);
                            }
                            List<Earthquake> eqList = new List<Earthquake>();
                            int idx = 1;
                            foreach (var eq in eQjArray)
                            {
                                JObject eqJObj = JObject.Parse(eq["properties"].ToString());
                                Earthquake earthquake = new Earthquake()
                                {
                                    EQid = idx,
                                    EQSize = double.Parse(eqJObj["mag"].ToString()),
                                    EQLocation = eqJObj["place"].ToString()
                                };
                                eqList.Add(earthquake);
                            }
                            Random random = new Random();
                            int randeq = random.Next(0, eqList.Count); // it is recommended to begin with 0 to include the first element
                            Earthquake displayEQ = eqList[randeq];
                            lblResults.Text = $"There were {count} earthquakes during this time.\n\n" +
                               $"Details of one of them:\nPlace: {displayEQ.EQLocation}, \nMagnitude: {displayEQ.EQSize}.";
                        }
                        catch (Exception ex)
                        {
                            DisplayAlert("Error", ex.Message, "Close");
                        }
                    }
                }
                else
                {
                    DisplayAlert("Error", "Please enter earthquake size", "Close");
                }
            }
            else
            {
                DisplayAlert("Invalid Input", "Please enter end date", "Close");
            }
        }
        else
        {
            DisplayAlert("Invalid Input", "Please enter start date", "Close");
        }
    }
}
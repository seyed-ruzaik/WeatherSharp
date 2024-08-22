
namespace WeatherApp.Models
{
    public class WeatherData
    {
        public Main Main { get; set; }
        public string Name { get; set; }
    }

    public class Main
    {
        public double Temp { get; set; }
        public double Feels_Like { get; set; }
    }
}

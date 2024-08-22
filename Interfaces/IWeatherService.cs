
namespace WeatherApp.Interfaces
{
    public interface IWeatherService
    {
        Task<WeatherData> GetWeatherAsync(string city);
    }
}

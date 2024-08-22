
using System;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherApp.Interfaces;
using WeatherApp.Services;
using Microsoft.Extensions.DependencyInjection;

namespace WeatherApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddHttpClient()
                .AddTransient<IWeatherService, WeatherService>(provider =>
                {
                    var httpClient = provider.GetRequiredService<IHttpClientFactory>().CreateClient();
                    var apiKey = "your_openweather_api_key";  // Replace with your OpenWeather API key
                    return new WeatherService(httpClient, apiKey);
                })
                .BuildServiceProvider();

            var weatherService = serviceProvider.GetRequiredService<IWeatherService>();

            Console.Write("Enter city name: ");
            var city = Console.ReadLine();

            try
            {
                var weatherData = await weatherService.GetWeatherAsync(city);

                Console.WriteLine($"City: {weatherData.Name}");
                Console.WriteLine($"Temperature: {weatherData.Main.Temp}°C");
                Console.WriteLine($"Feels Like: {weatherData.Main.Feels_Like}°C");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}

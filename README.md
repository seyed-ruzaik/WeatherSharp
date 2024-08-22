
# WeatherApp

This is a simple C# console application that fetches weather information such as temperature and "feels like" temperature using the OpenWeather API. The project is structured following best practices and industry standards, including separation of concerns, dependency injection, and asynchronous programming.

## Project Structure

- **Models**: Contains data models that map to the JSON response from the OpenWeather API.
- **Interfaces**: Contains interfaces that define contracts for the services.
- **Services**: Contains the implementation of the business logic, particularly interacting with the OpenWeather API.
- **Program**: The entry point of the application.

## How to Run

1. **Clone or Download the Repository**: Download the project files or clone the repository.
2. **Add API Key**: Replace `your_openweather_api_key` in `Program.cs` with your actual OpenWeather API key.
3. **Build and Run**: Build the project using your preferred C# development environment (e.g., Visual Studio, Rider) and run the application.

## Dependencies

- **Newtonsoft.Json**: For JSON serialization and deserialization.
- **Microsoft.Extensions.DependencyInjection**: For managing dependency injection.
- **System.Net.Http**: For making HTTP requests.

## Usage

1. Run the application.
2. Enter the name of the city for which you want to fetch the weather information.
3. The application will display the current temperature and "feels like" temperature for the city.

## Example

```
Enter city name: London
City: London
Temperature: 15.0°C
Feels Like: 13.0°C
```

## License

This project is open-source and available under the MIT License.

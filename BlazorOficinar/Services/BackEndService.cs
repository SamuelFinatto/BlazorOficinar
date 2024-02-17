namespace BlazorOficinar.Services
{
    public class BackEndService(HttpClient httpClient)
    {
        public async ValueTask<int> GetCustomersList()
        {
            var count = await httpClient.GetAsync("WeatherForecast/GetWeatherForecast");
            return 1;
        }
    }
}

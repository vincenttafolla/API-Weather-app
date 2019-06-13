using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string apiKey = System.IO.File.ReadAllText("api-key.txt");

            // API Key usage example
            // http://api.openweathermap.org/data/2.5/forecast?id=524901&AAPID={APIKEY}

            string apiCall = "http://api.openweathermap.org/data/2.5/weather?zip=94040,us" + "&APPID=" + apiKey;

            HttpClient httpClient = new HttpClient();
            Task<string> response = httpClient.GetStringAsync(apiCall);
            response.Wait();
            Console.WriteLine(response.Result);
            
        }
    }
}

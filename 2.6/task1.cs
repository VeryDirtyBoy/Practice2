using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program
{
    static async Task Main(string[] args)
    {
        string url = "https://api.openweathermap.org/data/2.5/weather?lat=56.4977&lon=84.9744&appid=80b6bbb076aa77c84b58573deeabb9cc";
        using var client = new HttpClient();
        var array = await client.GetAsync(url);
        string b = await array.Content.ReadAsStringAsync();
        SearchResult c = JsonConvert.DeserializeObject<SearchResult>(b);
        Console.WriteLine($"Погода в Томске: {1.8 * (c.Main.temp - 273)}");
    }
    public class SearchResult
    {
        public Temp Main { get; set; }
    }
    public class Temp
    {
        public double temp { get; set; }
    }
}
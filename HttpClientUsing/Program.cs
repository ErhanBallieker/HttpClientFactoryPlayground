using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientUsing
{
    class Program
    { 
        static async Task Main(string[] args)
        {
            Console.WriteLine("Started");
            for (int i = 0; i < 13; i++)
            {
                using (var httpClient = new HttpClient())
                {
                    var result = await httpClient.GetAsync("https://randomuser.me/api?results=5");
                    Console.WriteLine($"{result.StatusCode} - {result.IsSuccessStatusCode}");
                }
            }

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}

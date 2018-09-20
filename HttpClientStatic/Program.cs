using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientStatic
{
    class Program
    {
        private static HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            Console.WriteLine("Started");

            for (int i = 0; i < 13; i++)
            {
                var result = await client.GetAsync("https://randomuser.me/api?results=5");
                Console.WriteLine($"{result.StatusCode} - {result.IsSuccessStatusCode}");
            }

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}

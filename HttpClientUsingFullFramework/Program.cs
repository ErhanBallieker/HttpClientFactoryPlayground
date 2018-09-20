using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientUsingFullFramework
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Started");

            using (var client = new HttpClient())
            {
                for (int i = 0; i < 13; i++)
                {
                    var result = await client.GetAsync("https://randomuser.me/api?results=5");
                    Console.WriteLine($"{result.StatusCode} - {result.IsSuccessStatusCode}");
                }
            }

            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}

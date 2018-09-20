using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientFactoryTypedClient
{
    public class RandomUserClient : IRandomUserClient
    {
        public RandomUserClient(HttpClient client)
        {
            Client = client;
        }

        public HttpClient Client { get;  }

        public async Task<string> GetStringContentAsync()
        {
            return  await Client.GetStringAsync("?results5");
        }

        public async Task<int> GetStringDataLength()
        {
            var result = await Client.GetStringAsync("?results5");
            return result.Length;
        }
    }

    public interface IRandomUserClient
    {
        Task<int> GetStringDataLength();
    }
}

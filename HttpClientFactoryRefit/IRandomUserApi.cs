using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpClientFactoryRefit
{
    [Headers("Content-Type : application-json")]
    public interface IRandomUserApi
    {
        [Get("/")]
        Task<string> GetUser(string results);
    }
}

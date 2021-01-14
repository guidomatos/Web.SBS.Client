using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.SBS.Utils.RestClient
{
    public interface IRestClient
    {
        Task<T> GetAsync<T>(string path);
        Task<IEnumerable<T>> GetListAsync<T>(string path) where T : class, new();
        Task<T> PostAsync<T>(string path, object obj);
        Task<IEnumerable<T>> PostListAsync<T>(string path, object obj) where T : class, new();

    }
}

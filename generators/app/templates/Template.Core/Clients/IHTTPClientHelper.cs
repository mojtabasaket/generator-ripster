using System.Net.Http;
using System.Threading.Tasks;

namespace Template.Core.Clients
{
    public interface IHTTPClientHelper
    {
        Task<T> DeleteAsync<T>(string url);
        Task<T> GetAsync<T>(string url);
        Task<T> PostAsync<T>(string url, HttpContent contentPost);
        Task<T> PutAsync<T>(string url, HttpContent contentPut);
    }
}
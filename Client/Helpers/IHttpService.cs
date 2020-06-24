using System.Threading.Tasks;

namespace blazormovieswasm.Client.Helpers
{
  public interface IHttpService
  {
    Task<HttpResponseWrapper<object>> Post<T>(string url, T data);
  }
}
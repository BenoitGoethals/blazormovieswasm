using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace blazormovieswasm.Client.Helpers
{
  public static class IJSRuntimeExtensionMethods
  {
    public static async ValueTask<bool> Confirm(this IJSRuntime jS, string message)
    {
      await jS.InvokeVoidAsync("console.log", "example message");
      return await jS.InvokeAsync<bool>("confirm", message);
    }

    public static async ValueTask MyFunction(this IJSRuntime jS, string message)
    {
      await jS.InvokeVoidAsync("my_function", message);
    }
  
  }
}
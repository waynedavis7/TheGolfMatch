using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace TheMatch.Blazor
{
    public static class Extensions
    {
        public static ValueTask<bool> Confirm(this IJSRuntime jsRuntime, string message)
        {
            return jsRuntime.InvokeAsync<bool>("confirm", message);
        }
    }
}

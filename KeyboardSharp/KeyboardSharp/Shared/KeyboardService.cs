using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace KeyboardSharp.Shared
{
    public delegate void KeyboardEvent(KeyboardEventArgs args);

    public class KeyboardService
    {
        private IJSRuntime _jsRuntime;

        public KeyboardService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;

            _jsRuntime.InvokeVoidAsync("registerKeyboard", DotNetObjectReference.Create(this));
        }

        public event KeyboardEvent KeyDown;
        public event KeyboardEvent KeyUp;

        [JSInvokable]
        public void OnKeyDown(KeyboardEventArgs args)
        {
            KeyDown?.Invoke(args);
        }

        [JSInvokable]
        public void OnKeyUp(KeyboardEventArgs args)
        {
            KeyUp?.Invoke(args);
        }
    }
}
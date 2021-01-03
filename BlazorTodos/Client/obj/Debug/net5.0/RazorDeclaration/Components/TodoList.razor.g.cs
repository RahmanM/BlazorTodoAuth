// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorTodos.Client.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\_Imports.razor"
using BlazorTodos.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\_Imports.razor"
using BlazorTodos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
using BlazorTodos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
using BlazorTodos.Server.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
using BlazorTodos.Client.Components;

#line default
#line hidden
#nullable disable
    public partial class TodoList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
       

    [Parameter]
    public TodoViewModel[] Todos { get; set; }

    [Parameter]
    public EventCallback<string> OnListChanged { get; set; }

    async Task deleteTodo(int id)
    {
        if (id > 0)
        {
            //bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Are you sure?");
            var confirmed = await MatDialogService.ConfirmAsync("Are you sure you want to delete the record?");
            if (confirmed)
            {
                try
                {
                    await Http.DeleteAsync("/api/todoes/" + id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Toaster.Add("There was error while saving the record. The error has been logged. Please try again.", MatToastType.Danger);
                }
                await OnListChanged.InvokeAsync("Todo is deleted.");
            }
        }

    }

    async Task flipComplete(int id)
    {
        if (id > 0)
        {

            HttpContent httpContent = new StringContent(id.ToString());

            try
            {
                await Http.PutAsync("/api/todoes/" + id, httpContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Toaster.Add("There was error while saving the record. The error has been logged. Please try again.", MatToastType.Danger);
            }
            await OnListChanged.InvokeAsync("Todo complete state is changed.");
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatDialogService MatDialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorTodos.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\temp\BlazorTodos\BlazorTodos\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\temp\BlazorTodos\BlazorTodos\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\temp\BlazorTodos\BlazorTodos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\temp\BlazorTodos\BlazorTodos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\temp\BlazorTodos\BlazorTodos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\temp\BlazorTodos\BlazorTodos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\temp\BlazorTodos\BlazorTodos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\temp\BlazorTodos\BlazorTodos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\temp\BlazorTodos\BlazorTodos\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\temp\BlazorTodos\BlazorTodos\Client\_Imports.razor"
using BlazorTodos.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\temp\BlazorTodos\BlazorTodos\Client\_Imports.razor"
using BlazorTodos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\temp\BlazorTodos\BlazorTodos\Client\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\temp\BlazorTodos\BlazorTodos\Client\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\temp\BlazorTodos\BlazorTodos\Client\Pages\Todos_Add.razor"
using BlazorTodos.Server.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todos_add")]
    public partial class Todos_Add : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "C:\temp\BlazorTodos\BlazorTodos\Client\Pages\Todos_Add.razor"
       
    private TodoViewModel todoViewModel = new TodoViewModel();

    private async Task HandleValidSubmit()
    {
        Console.WriteLine(todoViewModel);
        using var response = await Http.PostAsJsonAsync("/api/todoes", todoViewModel);
        if (!response.IsSuccessStatusCode)
        {
            var errorMessage = response.ReasonPhrase;
            Console.WriteLine($"There was an error! {errorMessage}");
            return;
        }
        else
        {
            UriHelper.NavigateTo("/todoes");
        }
    }

    private void Cancel()
    {
        UriHelper.NavigateTo("/");
    }

    private List<TodoCategoryViewModel> categories = new List<TodoCategoryViewModel>();

    protected override async Task OnInitializedAsync()
    {
        categories = await Http.GetFromJsonAsync<List<TodoCategoryViewModel>>("/api/todocategories");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

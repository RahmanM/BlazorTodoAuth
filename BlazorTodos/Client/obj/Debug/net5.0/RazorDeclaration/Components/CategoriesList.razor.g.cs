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
#line 1 "C:\temp\BlazorTodos\BlazorTodos\Client\Components\CategoriesList.razor"
using BlazorTodos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\temp\BlazorTodos\BlazorTodos\Client\Components\CategoriesList.razor"
using BlazorTodos.Server.Data;

#line default
#line hidden
#nullable disable
    public partial class CategoriesList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\temp\BlazorTodos\BlazorTodos\Client\Components\CategoriesList.razor"
       

    [Parameter]
    public TodoCategoryViewModel[] Categories { get; set; }

    [Parameter]
    public EventCallback<string> OnListChanged { get; set; }

    async Task deleteCategory(int id)
    {
        if (id > 0)
        {
            bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Are you sure?");
            if (confirmed)
            {
                await Http.DeleteAsync("/api/todocategories/" + id);
                await OnListChanged.InvokeAsync("Category is deleted.");
            }
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

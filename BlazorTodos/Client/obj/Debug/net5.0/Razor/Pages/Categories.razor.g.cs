#pragma checksum "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Pages\Categories.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef39fbcad82b1a0317e13befd9fa9c18866a6b48"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTodos.Client.Pages
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
#line 13 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\_Imports.razor"
using BlazorAnimate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Pages\Categories.razor"
using BlazorTodos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Pages\Categories.razor"
using BlazorTodos.Server.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Pages\Categories.razor"
using BlazorTodos.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Pages\Categories.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Pages\Categories.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Pages\Categories.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/categories")]
    public partial class Categories : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"cssanimation leFadeOutLeft sequence\">Categories</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p><a href=\"Categories_Add\">Add New Category</a></p>\r\n\r\n");
            __builder.OpenComponent<BlazorTodos.Client.Components.Spinner>(2);
            __builder.AddAttribute(3, "SpinWhile", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Pages\Categories.razor"
                     categories == null

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenComponent<BlazorTodos.Client.Components.CategoriesList>(5);
            __builder.AddAttribute(6, "Categories", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorTodos.Server.Data.TodoCategoryViewModel[]>(
#nullable restore
#line 16 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Pages\Categories.razor"
                            categories

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnListChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 16 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Pages\Categories.razor"
                                                      OnCategoryChangedHandler

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Pages\Categories.razor"
       
    private TodoCategoryViewModel[] categories;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            categories = await Http.GetFromJsonAsync<TodoCategoryViewModel[]>("/api/todocategories");
        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
    }

    // Call back from the child component so the page can refresh its content or do whatever is needed
    async Task OnCategoryChangedHandler(string message)
    {
        await OnInitializedAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

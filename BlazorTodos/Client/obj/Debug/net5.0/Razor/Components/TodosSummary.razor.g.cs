#pragma checksum "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodosSummary.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7436e2ef6ae25dd883a11ddae0c0d7b2fb6c3bae"
// <auto-generated/>
#pragma warning disable 1591
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
#line 1 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodosSummary.razor"
using BlazorTodos.Shared.ViewModels;

#line default
#line hidden
#nullable disable
    public partial class TodosSummary : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "div");
            __builder.AddContent(2, "Done: ");
            __builder.AddContent(3, 
#nullable restore
#line 4 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodosSummary.razor"
                Summary?.TotalCompleted

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddContent(6, "Todo: ");
            __builder.AddContent(7, 
#nullable restore
#line 5 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodosSummary.razor"
                Summary?.TotalNotCompleted

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodosSummary.razor"
       

    [Parameter]
    public TodosSummaryViewModel Summary { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

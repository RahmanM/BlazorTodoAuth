#pragma checksum "C:\temp\BlazorTodos\BlazorTodos\Client\Components\CategoriesList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50c6f26c68cae62a9c49426386eb8e637c7b1bb9"
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
#nullable restore
#line 6 "C:\temp\BlazorTodos\BlazorTodos\Client\Components\CategoriesList.razor"
 if (Categories != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table");
            __builder.AddMarkupContent(2, "<thead><tr><th>Description</th>\r\n                <th>Active?</th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(3, "tbody");
#nullable restore
#line 17 "C:\temp\BlazorTodos\BlazorTodos\Client\Components\CategoriesList.razor"
             foreach (var category in Categories)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "tr");
            __builder.OpenElement(5, "td");
            __builder.AddContent(6, 
#nullable restore
#line 20 "C:\temp\BlazorTodos\BlazorTodos\Client\Components\CategoriesList.razor"
                         category.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n                    ");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 22 "C:\temp\BlazorTodos\BlazorTodos\Client\Components\CategoriesList.razor"
                          category.Active == true ? "Yes" : "No"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.OpenElement(12, "a");
            __builder.AddAttribute(13, "href", "javascript: void(0);");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\temp\BlazorTodos\BlazorTodos\Client\Components\CategoriesList.razor"
                                                                 (()=> deleteCategory(category.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(15, "<i class=\"far fa-trash-alt\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 28 "C:\temp\BlazorTodos\BlazorTodos\Client\Components\CategoriesList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "C:\temp\BlazorTodos\BlazorTodos\Client\Components\CategoriesList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(16, "<div>There are no categories to show.</div>");
#nullable restore
#line 35 "C:\temp\BlazorTodos\BlazorTodos\Client\Components\CategoriesList.razor"
}

#line default
#line hidden
#nullable disable
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

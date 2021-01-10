#pragma checksum "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a08987dcd4839aca03b10cc77f080bdde63e444"
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
#line 13 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\_Imports.razor"
using BlazorAnimate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\_Imports.razor"
using BlazorTodos.Client.Services;

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
            __builder.OpenComponent<BlazorAnimate.Animate>(0);
            __builder.AddAttribute(1, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 11 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
                    Animations.ZoomIn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 11 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
                                                 TimeSpan.FromSeconds(0.5)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Delay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 11 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
                                                                                   TimeSpan.FromSeconds(0.3)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 13 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
     if (Todos != null)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(5, "table");
                __builder2.AddAttribute(6, "class", "table");
                __builder2.AddMarkupContent(7, "<thead><tr><th>Description</th>\r\n                    <th>Category</th>\r\n                    <th>Done?</th>\r\n                    <th></th></tr></thead>\r\n            ");
                __builder2.OpenElement(8, "tbody");
#nullable restore
#line 26 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
                 foreach (var todo in Todos)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(9, "tr");
                __builder2.AddAttribute(10, "id", 
#nullable restore
#line 28 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
                             todo.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.OpenElement(11, "td");
                __builder2.OpenComponent<BlazorTodos.Client.Components.OverstrikeText>(12);
                __builder2.AddAttribute(13, "Overstrike", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
                                                        todo.Complete

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
                                                                             todo.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n                        ");
                __builder2.OpenElement(16, "td");
                __builder2.AddContent(17, 
#nullable restore
#line 30 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
                             todo?.Category

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n                        ");
                __builder2.OpenElement(19, "td");
                __builder2.OpenComponent<BlazorTodos.Client.Components.BooleanToYesNo>(20);
                __builder2.AddAttribute(21, "Condition", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
                                                        todo.Complete

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n                        ");
                __builder2.OpenElement(23, "td");
                __builder2.OpenElement(24, "a");
                __builder2.AddAttribute(25, "href", "javascript: void(0);");
                __builder2.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
                                                                     (() => deleteTodo(todo.Id))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(27, "<i class=\"far fa-trash-alt\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, " |\r\n                            ");
                __builder2.OpenElement(29, "a");
                __builder2.AddAttribute(30, "href", "javascript: void(0);");
                __builder2.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
                                                                     (() => flipComplete(todo.Id))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(32, "<i class=\"fas fa-check\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 39 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"

                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 45 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"

    }
    else
    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(33, "<div>No Todoes to show!</div>");
#nullable restore
#line 50 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
       

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
                    Toaster.Add("Record deleted successfully.", MatToastType.Info);
                    // Apply Javascript interop animation by running Javascript function to add a class dynamically
                    //await JsRuntime.InvokeVoidAsync("deleteAnimation", id.ToString());
                    await AnimationUtil.HangAndDropLeft(id.ToString());
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
                Toaster.Add("Record updated successfully.", MatToastType.Info);
                // Apply Javascript interop animation by running Javascript function to add a class dynamically
                //await JsRuntime.InvokeVoidAsync("fadeInRightAnimation", id.ToString());
                await AnimationUtil.FadeInRight(id.ToString());
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAnimationUtil AnimationUtil { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatDialogService MatDialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

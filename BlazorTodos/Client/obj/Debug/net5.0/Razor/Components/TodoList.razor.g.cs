#pragma checksum "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "244b3a394aa794d091258f9ee02a4383160b4a51"
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
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "p");
            __Blazor.BlazorTodos.Client.Components.TodoList.TypeInference.CreateMatTextField_0(__builder, 2, 3, 
#nullable restore
#line 15 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
                             true

#line default
#line hidden
#nullable disable
            , 4, "Filter Todos", 5, "search", 6, 
#nullable restore
#line 18 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
                                true

#line default
#line hidden
#nullable disable
            , 7, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 19 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
                                OnEnterKeyPressed

#line default
#line hidden
#nullable disable
            ), 8, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 20 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
                                   FilterTodos

#line default
#line hidden
#nullable disable
            ), 9, 
#nullable restore
#line 14 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
                                    Filter

#line default
#line hidden
#nullable disable
            , 10, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Filter = __value, Filter)), 11, () => Filter);
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n\r\n\r\n");
            __builder.OpenComponent<BlazorAnimate.Animate>(13);
            __builder.AddAttribute(14, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 28 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
                    Animations.ZoomIn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 28 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
                                                 TimeSpan.FromSeconds(0.5)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "Delay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 28 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
                                                                                   TimeSpan.FromSeconds(0.3)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 30 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
     if (Todos != null)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(18, "table");
                __builder2.AddAttribute(19, "class", "table");
                __builder2.AddMarkupContent(20, "<thead><tr><th>Description</th>\r\n                    <th>Category</th>\r\n                    <th>Done?</th>\r\n                    <th></th></tr></thead>\r\n            ");
                __builder2.OpenElement(21, "tbody");
#nullable restore
#line 43 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
                 foreach (var todo in Todos)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(22, "tr");
                __builder2.AddAttribute(23, "id", 
#nullable restore
#line 45 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
                             todo.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.OpenElement(24, "td");
                __builder2.OpenComponent<BlazorTodos.Client.Components.OverstrikeText>(25);
                __builder2.AddAttribute(26, "Overstrike", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 46 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
                                                        todo.Complete

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
                                                                             todo.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                        ");
                __builder2.OpenElement(29, "td");
                __builder2.AddContent(30, 
#nullable restore
#line 47 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
                             todo?.Category

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                        ");
                __builder2.OpenElement(32, "td");
                __builder2.OpenComponent<BlazorTodos.Client.Components.BooleanToYesNo>(33);
                __builder2.AddAttribute(34, "Condition", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 49 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
                                                        todo.Complete

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                        ");
                __builder2.OpenElement(36, "td");
                __builder2.OpenElement(37, "a");
                __builder2.AddAttribute(38, "href", "javascript: void(0);");
                __builder2.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
                                                                     (() => deleteTodo(todo.Id))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(40, "<i class=\"far fa-trash-alt\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, " |\r\n                            ");
                __builder2.OpenElement(42, "a");
                __builder2.AddAttribute(43, "href", "javascript: void(0);");
                __builder2.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
                                                                     (() => flipComplete(todo.Id))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(45, "<i class=\"fas fa-check\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 56 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"

                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 62 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"

    }
    else
    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(46, "<div>No Todoes to show!</div>");
#nullable restore
#line 67 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
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
#line 72 "E:\Projects\BlazorTodosAuth\BlazorTodos\Client\Components\TodoList.razor"
       

    [Parameter]
    public List<TodoViewModel> Todos { get; set; }

    [Parameter]
    public EventCallback<string> OnListChanged { get; set; }

    [Parameter]
    public EventCallback<string> OnFilterChanged { get; set; }

    private string Filter { get; set; }

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

    async Task FilterTodos()
    {
        if (Filter == null) return;
        await OnFilterChanged.InvokeAsync(Filter);
    }

    async Task OnEnterKeyPressed(KeyboardEventArgs args)
    {
        if(args.Key == "Enter")
        {
            await FilterTodos();
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
namespace __Blazor.BlazorTodos.Client.Components.TodoList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTextField_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.FocusEventArgs> __arg5, int __seq6, TValue __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Dense", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "Icon", __arg2);
        __builder.AddAttribute(__seq3, "Outlined", __arg3);
        __builder.AddAttribute(__seq4, "OnKeyUp", __arg4);
        __builder.AddAttribute(__seq5, "OnFocusOut", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

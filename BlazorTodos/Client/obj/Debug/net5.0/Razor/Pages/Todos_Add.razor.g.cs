#pragma checksum "C:\temp\BlazorTodos\BlazorTodos\Client\Pages\Todos_Add.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69676d373b59708875677950ee6f9c6c20dee3b7"
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
            __builder.AddMarkupContent(0, "<h3>Add Todo</h3>\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 49 "C:\temp\BlazorTodos\BlazorTodos\Client\Pages\Todos_Add.razor"
                  todoViewModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 49 "C:\temp\BlazorTodos\BlazorTodos\Client\Pages\Todos_Add.razor"
                                                 HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\r\n    ");
                __builder2.OpenElement(9, "p");
                __Blazor.BlazorTodos.Client.Pages.Todos_Add.TypeInference.CreateMatTextField_0(__builder2, 10, 11, 
#nullable restore
#line 54 "C:\temp\BlazorTodos\BlazorTodos\Client\Pages\Todos_Add.razor"
                                true

#line default
#line hidden
#nullable disable
                , 12, 
#nullable restore
#line 56 "C:\temp\BlazorTodos\BlazorTodos\Client\Pages\Todos_Add.razor"
                                            true

#line default
#line hidden
#nullable disable
                , 13, 
#nullable restore
#line 57 "C:\temp\BlazorTodos\BlazorTodos\Client\Pages\Todos_Add.razor"
                                            true

#line default
#line hidden
#nullable disable
                , 14, "Todo Description minimum 5 characters", 15, "Todo Description", 16, 
#nullable restore
#line 60 "C:\temp\BlazorTodos\BlazorTodos\Client\Pages\Todos_Add.razor"
                                 true

#line default
#line hidden
#nullable disable
                , 17, 
#nullable restore
#line 55 "C:\temp\BlazorTodos\BlazorTodos\Client\Pages\Todos_Add.razor"
                                    todoViewModel.Description

#line default
#line hidden
#nullable disable
                , 18, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => todoViewModel.Description = __value, todoViewModel.Description)), 19, () => todoViewModel.Description);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n\r\n    ");
                __builder2.OpenElement(21, "div");
                __Blazor.BlazorTodos.Client.Pages.Todos_Add.TypeInference.CreateMatCheckbox_1(__builder2, 22, 23, "Is Completed?", 24, 
#nullable restore
#line 66 "C:\temp\BlazorTodos\BlazorTodos\Client\Pages\Todos_Add.razor"
                                   todoViewModel.Complete

#line default
#line hidden
#nullable disable
                , 25, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => todoViewModel.Complete = __value, todoViewModel.Complete)), 26, () => todoViewModel.Complete);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n\r\n    ");
                __builder2.OpenElement(28, "div");
                __Blazor.BlazorTodos.Client.Pages.Todos_Add.TypeInference.CreateMatSelect_2(__builder2, 29, 30, "Select a category", 31, 
#nullable restore
#line 71 "C:\temp\BlazorTodos\BlazorTodos\Client\Pages\Todos_Add.razor"
                              true

#line default
#line hidden
#nullable disable
                , 32, "true", 33, 
#nullable restore
#line 72 "C:\temp\BlazorTodos\BlazorTodos\Client\Pages\Todos_Add.razor"
                                 todoViewModel.TodoCategoryId

#line default
#line hidden
#nullable disable
                , 34, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => todoViewModel.TodoCategoryId = __value, todoViewModel.TodoCategoryId)), 35, () => todoViewModel.TodoCategoryId, 36, (__builder3) => {
#nullable restore
#line 75 "C:\temp\BlazorTodos\BlazorTodos\Client\Pages\Todos_Add.razor"
             if (categories != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\temp\BlazorTodos\BlazorTodos\Client\Pages\Todos_Add.razor"
                 foreach (var category in categories)
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MatBlazor.MatOption<int>>(37);
                    __builder3.AddAttribute(38, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int>(
#nullable restore
#line 79 "C:\temp\BlazorTodos\BlazorTodos\Client\Pages\Todos_Add.razor"
                                                   category.Id

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(40, 
#nullable restore
#line 79 "C:\temp\BlazorTodos\BlazorTodos\Client\Pages\Todos_Add.razor"
                                                                category.Description

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 80 "C:\temp\BlazorTodos\BlazorTodos\Client\Pages\Todos_Add.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\temp\BlazorTodos\BlazorTodos\Client\Pages\Todos_Add.razor"
                 
            }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n\r\n    <br>\r\n    <br>\r\n\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatButton>(42);
                __builder2.AddAttribute(43, "type", "submit");
                __builder2.AddAttribute(44, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 88 "C:\temp\BlazorTodos\BlazorTodos\Client\Pages\Todos_Add.razor"
                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "Icon", "save");
                __builder2.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(47, "Save");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatButton>(49);
                __builder2.AddAttribute(50, "type", "button");
                __builder2.AddAttribute(51, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 89 "C:\temp\BlazorTodos\BlazorTodos\Client\Pages\Todos_Add.razor"
                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "Icon", "cancel");
                __builder2.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "C:\temp\BlazorTodos\BlazorTodos\Client\Pages\Todos_Add.razor"
                                                                     ()=> @Cancel()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(55, "Cancel");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
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
namespace __Blazor.BlazorTodos.Client.Pages.Todos_Add
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTextField_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, TValue __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Required", __arg0);
        __builder.AddAttribute(__seq1, "HelperTextPersistent", __arg1);
        __builder.AddAttribute(__seq2, "HelperTextValidation", __arg2);
        __builder.AddAttribute(__seq3, "HelperText", __arg3);
        __builder.AddAttribute(__seq4, "Label", __arg4);
        __builder.AddAttribute(__seq5, "FullWidth", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateMatCheckbox_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatCheckbox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::MatBlazor.MatSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "FullWidth", __arg1);
        __builder.AddAttribute(__seq2, "Required", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
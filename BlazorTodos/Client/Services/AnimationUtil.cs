using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorTodos.Client.Services
{
    public interface IAnimationUtil
    {
        Task FadeInRight(string elementId);
        Task HangAndDropLeft(string elementId);

        Task Effect3D(string elementId);

        Task Effect3DNoDuration(string elementId);

        Task RemoveAnimation(string elementId, string animation);

        Task AddCssClass(string elementId, string cssClassName);

        Task RemoveCssClass(string elementId, string cssClassName);
    }

    /// <summary>
    /// Custom util class to be injected into the components to assist on apply animations to elements
    /// </summary>
    public class AnimationUtil : IAnimationUtil
    {
        /// <summary>
        /// Default constructor with instance of Javascript Interop
        /// </summary>
        /// <param name="jsRuntime">Javascript interop</param>
        public AnimationUtil(IJSRuntime jsRuntime)
        {
            this.JSRuntime = jsRuntime;
        }

        public IJSRuntime JSRuntime { get; }

        public async Task AddCssClass(string elementId, string cssClassName)
        {
            await JSRuntime.InvokeVoidAsync("addCssClass", elementId, cssClassName);
        }

        public async Task Effect3D(string elementId)
        {
            await JSRuntime.InvokeVoidAsync("applyAnnimation", elementId, "effect3d");
        }

        public async Task Effect3DNoDuration(string elementId)
        {
            await JSRuntime.InvokeVoidAsync("applyAnnimationNoDuration", elementId, "effect3d");
        }

        /// <summary>
        /// Apply fadeInRight animation
        /// </summary>
        /// <param name="elementId">Id of the element to apply animation to</param>
        public async Task FadeInRight(string elementId)
        {
            await JSRuntime.InvokeVoidAsync("applyAnnimation", elementId, "fadeInRight");
        }

        /// <summary>
        /// Apply hangAndDropLeft animation
        /// </summary>
        /// <param name="elementId">Id of the element to apply animation to</param>
        public async Task HangAndDropLeft(string elementId)
        {
            await JSRuntime.InvokeVoidAsync("applyAnnimation", elementId, "hangAndDropLeft");
        }

        public async Task RemoveAnimation(string elementId, string animation)
        {
            await JSRuntime.InvokeVoidAsync("removeAnimation", elementId, animation);
        }

        public async Task RemoveCssClass(string elementId, string cssClassName)
        {
            await JSRuntime.InvokeVoidAsync("removeCssClass", elementId, cssClassName);
        }
    }
}

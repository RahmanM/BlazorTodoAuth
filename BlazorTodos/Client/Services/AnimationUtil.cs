using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorTodos.Client.Services
{
    public interface IAnimationUtil
    {
        Task FadeInRight(string elementId);
        Task HangAndDropLeft(string elementId);
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
    }
}

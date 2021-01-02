using BlazorTodos.Server.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorTodos.Shared.ViewModels
{
    public class TodosSummaryViewModel
    {
        private readonly List<TodoViewModel> _todos;

        public TodosSummaryViewModel(List<TodoViewModel> todos)
        {
            _todos = todos;
        }

        public int TotalCompleted { get; set; } = 0;

        public int TotalNotCompleted { get; set; } = 0;
    }
}

using System;

namespace ToDoApp.Services
{
    public class Todoitem
    {
        public string Text { get; set; } = string.Empty;
        public DateTime? CompletedAt { get; set; }
    }
}

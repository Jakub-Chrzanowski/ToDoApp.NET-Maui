using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class Todoitem
    {
        public string Text { get; set; } = string.Empty;
        public DateTime? CompletedAt { get; set; }
    }
}

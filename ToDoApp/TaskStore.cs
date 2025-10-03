using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.Services
{
    public class TaskStore
    {
        public static TaskStore Instance { get; } = new TaskStore();

        public ObservableCollection<Todoitem> Pending { get; } = new ObservableCollection<Todoitem>();
        public ObservableCollection<Todoitem> Done { get; } = new ObservableCollection<Todoitem>();

        private TaskStore()
        {
        }

        public void AddPending(Todoitem item)
        {
            if (item == null) return;
            Pending.Add(item);
        }

        public void MarkDone(Todoitem item)
        {
            if (item == null) return;
            if (Pending.Contains(item))
                Pending.Remove(item);

            Done.Add(item);
        }
    }
}

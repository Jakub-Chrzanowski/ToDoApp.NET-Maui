using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace ToDoApp.Services
{
    public class TaskStore : INotifyPropertyChanged
    {
        public static TaskStore Instance { get; } = new TaskStore();

        public ObservableCollection<Todoitem> Pending { get; } = new ObservableCollection<Todoitem>();
        public ObservableCollection<Todoitem> Done { get; } = new ObservableCollection<Todoitem>();

        private TaskStore()
        {
            Pending.CollectionChanged += OnCollectionChanged;
            Done.CollectionChanged += OnCollectionChanged;
        }

        private void OnCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(PendingCount));
            OnPropertyChanged(nameof(DoneCount));
        }

        public int PendingCount => Pending.Count;
        public int DoneCount => Done.Count;

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

        public void RemoveDone(Todoitem item)
        {
            if (item == null) return;
            if (Done.Contains(item))
                Done.Remove(item);
        }

        public void RemovePending(Todoitem item)
        {
            if (item == null) return;
            if (Pending.Contains(item))
                Pending.Remove(item);
        }

        public void ClearAll()
        {
            Pending.Clear();
            Done.Clear();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        public void Restore(IEnumerable<Todoitem> pending, IEnumerable<Todoitem> done)
        {
            Pending.Clear();
            Done.Clear();
            foreach (var item in pending) Pending.Add(item);
            foreach (var item in done) Done.Add(item);
        }

    }
}
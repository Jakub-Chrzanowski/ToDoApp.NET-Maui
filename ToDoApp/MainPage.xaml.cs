using System;
using ToDoApp.Services;
using Microsoft.Maui.Controls;
using System.Text.Json

namespace ToDoApp
{
    public partial class MainPage : ContentPage
    {
        private string filePath = Path.Combine(FileSystem.AppDataDirectory, "tasks.json");
        public MainPage()
        {
            InitializeComponent();
            BindingContext = TaskStore.Instance;
        }

        private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            await Navigation.PushAsync(new Tasksdone());
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
        {
            await Navigation.PushAsync(new Summary());
        }

        private void NewTaskEntry_Completed(object sender, EventArgs e)
        {
            AddTaskFromEntry();
        }

        private void AddNewButton_Clicked(object sender, EventArgs e)
        {
            AddTaskFromEntry();
        }

        private void AddTaskFromEntry()
        {
            var text = NewTaskEntry.Text?.Trim();
            if (string.IsNullOrWhiteSpace(text))
                return;

            TaskStore.Instance.AddPending(new Todoitem { Text = text });
            NewTaskEntry.Text = string.Empty;
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (!e.Value)
                return;

            if (sender is CheckBox cb && cb.BindingContext is Todoitem item)
            {
                item.CompletedAt = DateTime.Now;
                TaskStore.Instance.MarkDone(item);
            }
        }
        private void SaveButton_Clicked(object sender, CheckedChangedEventArgs e)
        {
            string json = JsonSerializer.Serialize(Todoitem);

        }
        private void RestoreButton_Clicked(object sender, CheckedChangedEventArgs e)
        {

        }
    }
}

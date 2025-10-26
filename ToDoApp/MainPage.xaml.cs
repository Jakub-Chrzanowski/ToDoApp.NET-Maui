using System;
using System.IO;
using System.Text.Json;
using ToDoApp.Services;
using Microsoft.Maui.Controls;

namespace ToDoApp
{
    public partial class MainPage : ContentPage
    {
        private readonly string filePath = Path.Combine(FileSystem.AppDataDirectory, "tasks.json");

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

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                var data = new
                {
                    Pending = TaskStore.Instance.Pending,
                    Done = TaskStore.Instance.Done
                };

                string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
                await File.WriteAllTextAsync(filePath, json);

                await DisplayAlert("Success", "Tasks saved successfully!", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Saving failed: {ex.Message}", "OK");
            }
        }

        private async void RestoreButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    await DisplayAlert("Info", "No saved tasks found.", "OK");
                    return;
                }

                string json = await File.ReadAllTextAsync(filePath);
                var data = JsonSerializer.Deserialize<TaskData>(json);

                if (data != null)
                {
                    TaskStore.Instance.Restore(data.Pending, data.Done);
                }

                await DisplayAlert("Success", "Tasks restored successfully!", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Restoring failed: {ex.Message}", "OK");
            }
        }
    }


    public class TaskData
    {
        public List<Todoitem> Pending { get; set; } = new();
        public List<Todoitem> Done { get; set; } = new();
    }
}

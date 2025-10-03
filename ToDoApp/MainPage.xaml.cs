
namespace ToDoApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = Services.TaskStore.Instance;
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

            Services.TaskStore.Instance.AddPending(new Models.Todoitem { Text = text });
            NewTaskEntry.Text = string.Empty;
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (!e.Value) 
                return;

            if (sender is CheckBox cb && cb.BindingContext is Models.Todoitem item)
            {

                item.CompletedAt = DateTime.Now;
                Services.TaskStore.Instance.MarkDone(item);
            }
        }
    }
}

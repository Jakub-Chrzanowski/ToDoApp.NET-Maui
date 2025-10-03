namespace ToDoApp;

public partial class Tasksdone : ContentPage
{
	public Tasksdone()
	{
		InitializeComponent();
        BindingContext = Services.TaskStore.Instance;
    }

    private async void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Summary());
    }
}
namespace ToDoApp;

public partial class Tasksdone : ContentPage
{
	public Tasksdone()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}
namespace ToDoApp;

public partial class Summary : ContentPage
{
	public Summary()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		await Navigation.PushAsync(new MainPage());
    }

    private async void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Tasksdone());
    }
}
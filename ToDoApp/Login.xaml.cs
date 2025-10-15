namespace ToDoApp;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private async void Login_Btn_Clicked(object sender, EventArgs e)
    {
		if(Login_Text.Text == "user" && Password_Text.Text == "password")
		{
            await Navigation.PushAsync(new MainPage());
        }
		else
		{
			await DisplayAlert("Podaj poprawne dane", "Spróbuj ponownie","Ok");
		}
    }
}
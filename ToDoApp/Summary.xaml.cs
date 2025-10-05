using System;
using ToDoApp.Services;
using Microsoft.Maui.Controls;

namespace ToDoApp;

public partial class Summary : ContentPage
{
    public Summary()
    {
        InitializeComponent();
        BindingContext = TaskStore.Instance;
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }

    private async void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Tasksdone());
    }

    private void DeleteAll_Clicked(object sender, EventArgs e)
    {
        TaskStore.Instance.ClearAll();
    }
}
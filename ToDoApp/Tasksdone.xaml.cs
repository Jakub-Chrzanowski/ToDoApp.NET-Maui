using System;
using System.Linq;
using ToDoApp.Services;
using Microsoft.Maui.Controls;

namespace ToDoApp;

public partial class Tasksdone : ContentPage
{
    public Tasksdone()  
    {
        InitializeComponent();
        BindingContext = TaskStore.Instance;
    }

    private async void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Summary());
    }

    private void DeleteSelected_Clicked(object sender, EventArgs e)
    {
        var selected = DoneCollectionView.SelectedItems?.Cast<Todoitem>().ToList();
        if (selected == null || selected.Count == 0)
            return;

        foreach (var item in selected)
        {
            TaskStore.Instance.RemoveDone(item);
        }

        DoneCollectionView.SelectedItems?.Clear();
    }
}
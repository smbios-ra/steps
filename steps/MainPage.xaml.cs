﻿namespace steps;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void Login_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new steps.MVVM.Views.Movies());

    }
}
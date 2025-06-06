﻿namespace PracticalWorkII;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnLoginClicked(object sender, EventArgs e)
    {
        string tempUser = UsernameEntry.Text;
        string tempPass = PasswordEntry.Text;

        if (tempUser == SessionData.loggedUser.Username && tempPass == SessionData.loggedUser.Password)
        {
            DisplayAlert("Success", "Logged in", "OK");

            Navigation.PushAsync(new ConversorPage());
        }
        else
        {
            DisplayAlert("Error", "Incorrect user or passwords", "Try again");
        }
    }

    private void OnGoToRegisterClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RegisterPage());
    }
    
    private void OnForgotPasswordClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ForgotPasswordPage());
    }

}


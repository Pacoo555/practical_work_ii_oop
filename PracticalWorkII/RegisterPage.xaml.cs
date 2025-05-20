using System.Runtime.Intrinsics.X86;

namespace PracticalWorkII;

public static class SessionData
{
    public static string Username { get; set; }
    public static string Password { get; set; }
}

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
    }

    private void OnRegisterClicked(object sender, EventArgs e)
    {
        SessionData.Username = newUsernameEntry.Text;
        SessionData.Password = newPasswordEntry.Text;

        if (string.IsNullOrWhiteSpace(SessionData.Username) || string.IsNullOrWhiteSpace(SessionData.Password))
        {
            DisplayAlert("Error", "You must fill all of the gaps", "OK");
            return;
        }

        DisplayAlert("Success", $"User {SessionData.Username} created.", "OK");

        Navigation.PopAsync();
    }
}


namespace PracticalWorkII;

public partial class ForgotPasswordPage : ContentPage
{

    public ForgotPasswordPage()
    {
        InitializeComponent();
    }

    private void OnChangePasswordClicked(object sender, EventArgs e)
    {
        string name = NameEntry.Text;
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        string oldName = SessionData.loggedUser.Name;
        string oldUsername = SessionData.loggedUser.Username;

        if (name == oldName && username == oldUsername)
        {
            SessionData.loggedUser.Password = password;
            DisplayAlert("Success", "Your password has been changed", "OK");
        }
        else
        {
            DisplayAlert("Error", "Name or username are incorrect, unable to verify identity", "OK");
        }
    }
}

namespace PracticalWorkII;

public class User
{
    public string Name { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public int NumOfOperations { get; set; } = 0;
}

public static class SessionData
{
    public static User loggedUser { get; set; }
}


public partial class RegisterPage : ContentPage
{
    private const string UserFileName = "users.csv";

    public RegisterPage()
    {
        InitializeComponent();
    }

    private void OnRegisterClicked(object sender, EventArgs e)
    {
        string name = newNameEntry.Text;
        string username = newUsernameEntry.Text?.Trim();
        string password = newPasswordEntry.Text;
        string confirmPassword = confirmPasswordEntry.Text;

        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(username) ||
            string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
        {
            DisplayAlert("Error", "All fields are required.", "OK");
            return;
        }

        if (name.Equals(username, StringComparison.OrdinalIgnoreCase))
        {
            DisplayAlert("Error", "Name and username must be different.", "OK");
            return;
        }

        if (password != confirmPassword)
        {
            DisplayAlert("Error", "Passwords do not match.", "OK");
            return;
        }

        if (!IsValidPassword(password))
        {
            DisplayAlert("Error", "Password must be at least 8 characters long and include uppercase, lowercase, number, and symbol.", "OK");
            return;
        }

        if (!checkBox.IsChecked)
        {
            DisplayAlert("Error", "You must agree to the protection policy.", "OK");
            return;
        }

        User user = new User
        {
            Name = name,
            Username = username,
            Password = password,
            NumOfOperations = 0
        };

        SessionData.loggedUser = user;

        SaveUserToCsv(user.Name, user.Username, user.Password);

        DisplayAlert("Success", $"User {username} registered.", "OK");
        Navigation.PopAsync();
    }

    private bool IsValidPassword(string password)
    {
        return password.Length >= 8 &&
               password.Any(char.IsUpper) &&
               password.Any(char.IsLower) &&
               password.Any(char.IsDigit) &&
               password.Any(ch => !char.IsLetterOrDigit(ch));
    }

    private void SaveUserToCsv(string name, string username, string password)
    {
        string path = "Users.csv";

        bool fileExists = File.Exists(path);
        using var writer = new StreamWriter(path, append: true);

        if (!fileExists)
        {
            // Escribe la cabecera solo si el archivo no existe
            writer.WriteLine("Name,Username,Password,OperationsExecuted");
        }

        writer.WriteLine($"{Escape(name)},{Escape(username)},{Escape(password)},0");
    }

    private string Escape(string value)
    {
        return $"\"{value.Replace("\"", "\"\"")}\"";
    }

}
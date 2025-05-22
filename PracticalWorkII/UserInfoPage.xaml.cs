using System;

namespace PracticalWorkII
{
    public partial class UserInfoPage : ContentPage
    {
        public UserInfoPage()
        {
            InitializeComponent();
            nameLabel.Text = $"Name: {SessionData.loggedUser.Name}";
            usernameLabel.Text = $"Username: {SessionData.loggedUser.Username}";
            passwordLabel.Text = $"Password: {SessionData.loggedUser.Password}";
            numOfOperationsLabel.Text = $"Number of Operations: {SessionData.loggedUser.NumOfOperations}";

        }
    }
}

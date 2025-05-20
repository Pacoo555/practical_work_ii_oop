using System;
using Microsoft.Maui.Controls;

namespace PracticalWorkII
{
    
    public partial class ConversorPage : ContentPage
    {
        public ConversorPage()
        {
            InitializeComponent();
        }

        private void OnInputClicked(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                InputDisplay.Text += button.Text;
            }
        }

        private void OnClearClicked(object sender, EventArgs e)
        {
            InputDisplay.Text = string.Empty;
        }




        private void OnConversionClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int operation = GetOperationCode(button.Text);

            try
            {
                string result = _converter.PerformConversion(operation, _currentInput);
                DisplayAlert("Conversion Result", result, "OK");

                // Optionally clear input
                _currentInput = "";
                InputDisplay.Text = "";
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", $"Conversion failed:\n{ex.Message}", "OK");
            }
        }

        private int GetOperationCode(string buttonText)
        {
            return buttonText switch
            {
                "Decimal To Binary" => 1,
                "Decimal to Two Complement" => 2,
                "Decimal To Octal" => 3,
                "Decimal To Hexadecimal" => 4,
                "Binary To Decimal" => 5,
                "Two Complement To Decimal" => 6,
                "Octal To Decimal" => 7,
                "Hexadecimal To Decimal" => 8,
                _ => throw new InvalidOperationException("Invalid operation text")
            };
        }
    }
    
}

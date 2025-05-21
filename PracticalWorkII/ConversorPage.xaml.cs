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

        Converter converter = new Converter();
        Operations ops = new Operations(";");
        string input = "";
        string output = "";
        int error = 1;
        int bitSize;


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
            input = InputDisplay.Text;

            string errorMessage = "";

            try
            {
                if (!string.IsNullOrWhiteSpace(BitSizeEntry.Text))
                {
                    bitSize = Int32.Parse(BitSizeEntry.Text);
                }

                output = converter.PerformConversion(operation, input, bitSize);
                DisplayAlert("Conversion Result", output, "OK");

                InputDisplay.Text = "";

                ops.AddOperation(input, output, operation, error, errorMessage);
                ops.SaveOperations("output.csv");

                DisplayAlert("Data updated to output.csv", "", "OK");
            }
            catch (OverflowException ex)
            {
                errorMessage = ex.Message;
                DisplayAlert("Overflow Error", "Introduce a bit number valid for the input", "OK");
            }
            catch (FormatException ex)
            {
                errorMessage = ex.Message;
                DisplayAlert("Format Error", "Introduce a valid input for the conversion chosen", "OK");
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                DisplayAlert("Unknown Error", "An unknown error has occurred", "OK");
            }

            

            





        }


        private int GetOperationCode(string buttonText)
        {
            return buttonText switch
            {
                "Decimal To Binary" => 1,
                "Decimal to Two Complement" => 4,
                "Decimal To Octal" => 2,
                "Decimal To Hexadecimal" => 3,
                "Binary To Decimal" => 5,
                "Two Complement To Decimal" => 6,
                "Octal To Decimal" => 7,
                "Hexadecimal To Decimal" => 8,
                _ => throw new InvalidOperationException("Invalid operation text")
            };
        }
    }
    
}

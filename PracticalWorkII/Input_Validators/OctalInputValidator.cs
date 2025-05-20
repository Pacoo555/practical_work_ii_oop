using System;

namespace PracticalWorkII
{
    public class OctalInputValidator : InputValidator
    {
        public override void validate(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                bool IsDigit = c >= '0' && c <= '7';

                if (!IsDigit)
                {
                    throw new FormatException("Bad format: input is not a valid octal number.");
                }
            }
        }
    }
}
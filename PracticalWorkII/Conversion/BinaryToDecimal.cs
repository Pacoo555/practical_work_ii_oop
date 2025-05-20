using System;

namespace PracticalWorkII
{
    public class BinaryToDecimal : Conversion
    {
        public BinaryToDecimal(string name, string definition) : base(name, definition, new BinaryInputValidator())
        {

        }
        public override string Change(string input)
        {
            int decimalValue = 0;
            int power = 0;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] == '1')
                {
                    decimalValue += (int)Math.Pow(2, power);
                }
                power++;
            }

            return decimalValue.ToString();
        }
    }
}
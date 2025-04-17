namespace Bookstore
{
    public static class Validator
    {
        public static string LineEnd { get; set; } = "\n";

        public static string IsPresent(string value, string name)
        {
            string msg = "";
            if (string.IsNullOrWhiteSpace(value))
            {
                msg += name + " is a required field." + LineEnd;
            }
            return msg;
        }

        public static string IsLengthValid(string value, string name, int maxLength)
        {
            string msg = "";
            if (!string.IsNullOrWhiteSpace(value) && value.Length > maxLength)
            {
                msg += name + " must be " + maxLength + " characters or less." + LineEnd;
            }
            return msg;
        }

        public static string IsDecimal(string value, string name)
        {
            string msg = "";
            if (string.IsNullOrWhiteSpace(value))
            {
                msg += name + " is a required field." + LineEnd;
            }
            else if (!decimal.TryParse(value, out decimal number) || number <= 0)
            {
                msg += name + " must be a positive number." + LineEnd;
            }
            return msg;
        }

        public static string IsInt32(string value, string name)
        {
            string msg = "";
            if (string.IsNullOrWhiteSpace(value))
            {
                msg += name + " is a required field." + LineEnd;
            }
            else if (!int.TryParse(value, out int number) || number < 0)
            {
                msg += name + " must be a non-negative number." + LineEnd;
            }
            return msg;
        }
    }
}
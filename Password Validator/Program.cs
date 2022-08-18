using System;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool passwordLengh = ValidatePasswordLenght(password);
            bool lettersAndDigits = ValidateCharacters(password);
            bool leastToDigits = ValidateLengh(password);

            if (!passwordLengh)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!lettersAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!leastToDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (passwordLengh&&lettersAndDigits&&leastToDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }

         static bool ValidateLengh(string password)
        {
            int count = 0;
            foreach (char symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    count++;
                }
            }
            return count >= 2;
        }

         static bool ValidateCharacters(string password)
        {
            foreach (char symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
                
            }
            return true;
        }

         static bool ValidatePasswordLenght(string password)
        {

            return password.Length >= 6 && password.Length <= 10;
        }
    }
}

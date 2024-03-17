using CustomExceptionLibrary;

namespace Task_2_UserManagementSystem
{
    public class UserValidation
    {
        public static void ValidateNotEmpty(string value, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new NotEmptyException($"{fieldName} cannot be empty.");
            }
        }

        public static void ValidateAge(string age)
        {
            var result = 0;
            var isIntiger =  int.TryParse(age, out result);

            if (!isIntiger)
                throw new InvalidOperationException($"Age should be integer.");

            if (result <= 18)
                throw new ArgumentOutOfRangeException($"Age should be greater than 18.");
        }

        public static void ValidatePassword(string password)
        {
            ValidateNotEmpty(password, UserField.Password);

            if (password.Length < 8)
            {
                throw new InvalidPasswordException($"Password length must be greater than 8");
            }
        }

        public static void ValidateRepeatPassword(string password, string repeatPassword)
        {
            if (!password.Equals(repeatPassword))
            {
                throw new InvalidPasswordException($"Passwords do not match.");
            }
        }
    }
}

using CustomExceptionLibrary;
using Task_2_UserManagementSystem;

try
{
    var name = UserInput.GetUserInput<string>(UserField.Name);
    UserValidation.ValidateNotEmpty(name, UserField.Name);

    var surname = UserInput.GetUserInput<string>(UserField.Surname);
    UserValidation.ValidateNotEmpty(surname, UserField.Surname);

    var age = UserInput.GetUserInput<string>(UserField.Age);
    UserValidation.ValidateAge(age);

    var password = UserInput.GetUserInput<string>(UserField.Password);
    UserValidation.ValidatePassword(password);

    var repeatPassword = UserInput.GetUserInput<string>(UserField.RepeartPassword);
    UserValidation.ValidateRepeatPassword(password, repeatPassword);

    var newUser = new User(name, surname, int.Parse(age), password, repeatPassword);

    Console.WriteLine("User created successfuly");
}

catch(NotEmptyException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

catch (InvalidPasswordException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

catch (Exception ex)
{
    Console.WriteLine($"Unexpected error: {ex.Message}");
}
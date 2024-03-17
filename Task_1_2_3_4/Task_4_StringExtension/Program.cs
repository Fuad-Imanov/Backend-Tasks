using CustomExceptionLibrary;
using Task_4_StringExtension;

try
{
    var mainString = UserInput.GetUserInput<string>("Input mainString");

    var  subString = UserInput.GetUserInput<string>("Input subString");

    Console.WriteLine(mainString.CountSubString(subString));
}

catch(NotEmptyException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}


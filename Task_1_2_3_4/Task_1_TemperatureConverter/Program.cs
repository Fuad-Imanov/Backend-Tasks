using Task_1_TemperatureConverter;

try
{
    double celsiusDegree = UserInput.GetUserInputAsDouble("Please enter the Celsius temperature");
    Celsius celsius = new Celsius(celsiusDegree);

    Kelvin kelvin = celsius; 

    Console.WriteLine($"Celsius: {celsius.Degree}°C");
    Console.WriteLine($"Kelvin: {kelvin.Degree}K");
}

catch (FormatException ex)
{
    Console.WriteLine($"Error: {ex.Message}. Please enter a valid number.");
}

catch (Exception ex)
{
    Console.WriteLine($"Unexpected error: {ex.Message}");
}

Console.ReadKey();
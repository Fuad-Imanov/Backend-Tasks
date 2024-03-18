namespace Task_1_TemperatureConverter
{
    public static class UserInput
    {
        public static double GetUserInputAsDouble(string message)
        {
            Console.WriteLine($"{message}:");

            string userInput = Console.ReadLine();

            if (!double.TryParse(userInput, out double result))
                throw new FormatException("Invalid input. Please enter a valid number.");

            return result;
        }
    }
}

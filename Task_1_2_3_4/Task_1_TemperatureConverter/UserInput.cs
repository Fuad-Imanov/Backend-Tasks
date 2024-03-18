namespace Task_1_TemperatureConverter
{
    public class UserInput
    {
        public static double GetUserInputAsDouble(string message)
        {
            Console.WriteLine($"{message}:");

            if (!double.TryParse(Console.ReadLine(), out double result))
                throw new FormatException("Invalid input. Please enter a valid number.");

            return result;
        }
    }
}

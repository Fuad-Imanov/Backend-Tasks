namespace Task_4_StringExtension
{
    public class UserInput
    {
        public static T GetUserInput<T>(string message)
        {
            Console.WriteLine($"{message}");

            var value = Console.ReadLine();

            return (T)(object)value;
        }
    }
}

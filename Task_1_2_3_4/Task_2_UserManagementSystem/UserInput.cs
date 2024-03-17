namespace Task_2_UserManagementSystem
{
    public class UserInput
    {
        public static T GetUserInput<T>(string fieldName)
        {
            Console.WriteLine($"Input {fieldName}");

            var value = Console.ReadLine();

            return (T)(object)value;
        }
    }
}

namespace Task_2_UserManagementSystem
{
    public class UserInput
    {
        public static string GetUserInput(string fieldName)
        {
            Console.WriteLine($"Input {fieldName}");

            var value = Console.ReadLine();

            return value;
        }
    }
}

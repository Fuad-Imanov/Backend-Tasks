namespace Task_2_UserManagementSystem
{
    public class User
    {
        public User(string name,string surname,int age,string password,string repeatPassword)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Password = password;
            RepeatPassword = repeatPassword;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public string RepeatPassword {  get; set; }

    }
}

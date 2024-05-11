namespace ToDoList.Domain.Entities
{
    public class User : Entity
    {
        public string Login { get; private set; }
        public string Password { get; private set; }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}

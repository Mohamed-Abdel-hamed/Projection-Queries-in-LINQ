namespace Select_User
{
    internal class Program
    {
        public static void Main()
        {
            List<User> users = new List<User>
        {
            new User(1, "Alice", true),
            new User(2, "Bob", false),
            new User(3, "Charlie", true),
            new User(4, "David", false)
        };

            var userNames = users.Select(user => user.Name).ToList();

            Console.WriteLine("User Names:");
            foreach (var name in userNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}

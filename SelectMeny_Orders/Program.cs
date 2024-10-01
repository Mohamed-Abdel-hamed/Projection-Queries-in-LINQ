namespace SelectMeny_Orders
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }

        public Order(int id, decimal amount)
        {
            Id = id;
            Amount = amount;
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
            Orders = new List<Order>();
        }
    }

    public class Program
    {
        public static void Main()
        {
            List<Customer> customers = new List<Customer>
        {
            new Customer(1, "Alice") { Orders = new List<Order> { new Order(1, 100), new Order(2, 150) }},
            new Customer(2, "Bob") { Orders = new List<Order> { new Order(3, 200) }},
            new Customer(3, "Charlie") { Orders = new List<Order> { new Order(4, 250), new Order(5, 300) }}
        };
            var allOrders = customers.SelectMany(customer => customer.Orders).ToList();

            Console.WriteLine("All Orders:");
            foreach (var order in allOrders)
            {
                Console.WriteLine($"Order ID: {order.Id}, Amount: {order.Amount}");
            }
        }
    }
}

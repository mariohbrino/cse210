using System;

class Program
{
    private static List<Order> _orders = [];

    private static void SetUpOrders()
    {
        // Define two orders with a 2-3 products each
        Product product1 = new Product(101, "Laptop", 999.99, 10);
        Product product2 = new Product(102, "Smartphone", 699.99, 20);
        Product product3 = new Product(103, "Tablet", 399.99, 15);
        Address address1 = new Address("123 Main Street", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        order1.SetProduct(product1);
        order1.SetProduct(product2);
        order1.SetProduct(product3);

        Product product4 = new Product(201, "Headphones", 49.99, 50);
        Product product5 = new Product(202, "Wireless Mouse", 29.99, 30);
        Product product6 = new Product(203, "Keyboard", 59.99, 25);
        Address address2 = new Address("456 Elm Avenue", "Los Angeles", "CA", "USA");
        Customer customer2 = new Customer("Jane Doe", address2);
        Order order2 = new Order(customer2);
        order2.SetProduct(product4);
        order2.SetProduct(product5);
        order2.SetProduct(product6);

        Product product7 = new Product(301, "Monitor", 199.99, 12);
        Product product8 = new Product(302, "External Hard Drive", 89.99, 18);
        Product product9 = new Product(303, "USB Flash Drive", 19.99, 100);
        Address address3 = new Address("789 Oak Drive", "Chicago", "IL", "USA");
        Customer customer3 = new Customer("Nick Doe", address3);
        Order order3 = new Order(customer3);
        order3.SetProduct(product7);
        order3.SetProduct(product8);
        order3.SetProduct(product9);

        Product product10 = new Product(401, "Gaming Chair", 249.99, 8);
        Product product11 = new Product(402, "Webcam", 79.99, 22);
        Product product12 = new Product(403, "Microphone", 99.99, 16);
        Address address4 = new Address("10 Downing Street", "London", "Greater London", "United Kingdom");
        Customer customer4 = new Customer("Josh Doe", address4);
        Order order4 = new Order(customer4);
        order4.SetProduct(product10);
        order4.SetProduct(product11);
        order4.SetProduct(product12);

        _orders.AddRange(new List<Order>{order1, order2, order3, order4});
    }

    private static void DisplayOrders()
    {
        foreach (Order order in _orders)
        {
            string customerName = order.GetCustomer().GetName();
            Console.WriteLine($"------------ Order for [{customerName}] ------------");
            string packingLabel = order.GetPackingLabel();
            string shippingLabel = order.GetShippingLabel();
            string orderCosts = order.GetOrderCosts();
            Console.WriteLine(packingLabel);
            Console.WriteLine(shippingLabel);
            Console.WriteLine(orderCosts);
            Console.WriteLine("");
        }
    }

    static void Main(string[] args)
    {
        SetUpOrders();
        DisplayOrders();
    }
}
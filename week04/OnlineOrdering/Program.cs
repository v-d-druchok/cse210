using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Address address1 = new Address("63 Abandoned Cabin", "Morristown", "Tennessee", "US");
        Customer customer1 = new Customer("Ash Williams", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Banana", 1100010, 0.50, 400000);
        Product product2 = new Product("All American Spud Daemons", 110110, 6.66, 8);
        Product product3 = new Product("Halloween decor 'crucifix'", 110011, 5.00, 1);
        Product product4 = new Product("Salt", 828347, 8.50, 1);
        Product product5 = new Product("Slat & Vinegar Crisps", 6326376, 4.30, 1);
        Product product6 = new Product("Necronomicon", 600600600, 10.50, 1);
        Product product7 = new Product("Holy Bible", 1231235324, 35.50, 1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);
        order1.AddProduct(product4);
        order1.AddProduct(product5);
        order1.AddProduct(product6);
        order1.AddProduct(product7);

        Console.WriteLine($"Packing Label:\n{order1.MakePackingLabel()}\nShipping Label:\n{order1.MakeShippingLabel()}\n\nTotal:\n{order1.Total()}$\n");

        
        Address address2 = new Address("2nd Ave", "Climax", "Saskatchewan", "Canada");
        Customer customer2 = new Customer("Jhonny Degen", address2);
        Order order2 = new Order(customer2);

        Product product8 = new Product("Pringles", 132334567, 3.00, 1);
        Product product9 = new Product("CocaCola 2l", 12456554, 2.46, 1);
        Product product10 = new Product("MassGainer Whey", 127438756, 109.68, 5);
        Product product11 = new Product("Rubber gloves", 323546577, 6.47, 1);
        Product product12 = new Product("Olive oil", 1238656, 20.11, 1);
        Product product13 = new Product("Cucumber", 120940809, 0.50, 1);
        Product product14 = new Product("Banana", 1100010, 0.50, 1);
        Product product15 = new Product("Dish Sponges", 6743657, 2.68, 1);
        Product product16 = new Product("Eggplant", 124565621, 1.50, 1);
        Product product17 = new Product("Pvc Pipe", 124354334, 2.50, 1);
        Product product18 = new Product("Lotion", 12435463, 12.50, 1);

        order2.AddProduct(product8);
        order2.AddProduct(product9);
        order2.AddProduct(product10);
        order2.AddProduct(product11);
        order2.AddProduct(product12);
        order2.AddProduct(product13);
        order2.AddProduct(product14);
        order2.AddProduct(product15);
        order2.AddProduct(product16);
        order2.AddProduct(product17);
        order2.AddProduct(product18);

        Console.WriteLine($"\nPacking Label:\n{order2.MakePackingLabel()}\nShipping Label:\n{order2.MakeShippingLabel()}\n\nTotal:\n{order2.Total()}$");
    }
}
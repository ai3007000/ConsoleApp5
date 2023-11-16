using System;

namespace ConsoleApp5.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User human1 = new User("Артём Иванов");
            Product product1 = new Product("Компьютерная мышь", "...");
            Product product2 = new Product("Компьютерная клавиатура", "...");
            Product product3 = new Product("Монитор", "...");
            
            Console.WriteLine("Введите адрес доставки");
            string address = Console.ReadLine();

            HomeDelivery delivery = new HomeDelivery(address);
            Order<HomeDelivery> order1 = new Order<HomeDelivery>(delivery, 34658, product1, product2, product3);
            
        }
    }
}
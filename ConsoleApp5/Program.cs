using System;

namespace ConsoleApp5.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User human1 = new User("Артём Иванов", new Company("Google", "+79231868874"));

            Product product1 = new Product("Компьютерная мышь", "...");
            Product product2 = new Product("Компьютерная клавиатура", "...");
            Product product3 = new Product("Монитор", "...");
            
            Console.WriteLine("Введите адрес доставки");
            string address = Console.ReadLine();

            string PlaceOfDelivery;
            HomeDelivery delivery = new HomeDelivery(address);

            if (delivery is HomeDelivery)
            {
                PlaceOfDelivery = "Дом";
                Order<HomeDelivery> order1 = new Order<HomeDelivery>(human1, delivery, PlaceOfDelivery, 34658, product1, product2, product3);
                order1.MakeDelivery();
            }
            else if (delivery is PickPointDelivery)
            {
                PlaceOfDelivery = "Пункт выдачи";
                Order<HomeDelivery> order1 = new Order<HomeDelivery>(human1, delivery, PlaceOfDelivery, 34658, product1, product2, product3);
                order1.MakeDelivery();
            }
            else
            {
                PlaceOfDelivery = "Розничный магазин";
                Order<HomeDelivery> order1 = new Order<HomeDelivery>(human1, delivery, PlaceOfDelivery, 34658, product1, product2, product3);
                order1.MakeDelivery();
            }

        }
    }
}
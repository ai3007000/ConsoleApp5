using ConsoleApp5.ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.ConsoleApp
{
    /// <summary>
    /// Заказ
    /// </summary>
    /// <typeparam name="TDelivery"></typeparam>
    /// <typeparam name="TStruct"></typeparam>
    class Order<TDelivery> where TDelivery : Delivery
    {
        public Order(User user, TDelivery Delivery, string PlaceOfDelivery, int Number, params Product[] Products)
        {
            this.Delivery = Delivery;
            this.PlaceOfDelivery = PlaceOfDelivery;
            this.Number = Number;
            this.Products = Products;
            this.user = user;
        }
        private User user { get; set; }
        private TDelivery Delivery { get; set; } // Доставка
        private string PlaceOfDelivery { get; set; }

        private int Number { get; set; } // Номер заказа
        private Product[] Products { get; set; } // Продукт (название и описание)
        /// <summary>
        /// Показать адрес доставки
        /// </summary>
        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.ShowAddress());
        }
        public void MakeDelivery()
        {
            this.Delivery.MakeDelivery(); // Адрес доставки 
            this.user.ShowName(); // Имя получателя
            Console.WriteLine($"Номер заказа: {this.Number}");

            Console.WriteLine("Заказы:");
            for (int j = 0; j < this.Products.Length; j++)
            {
                Console.WriteLine($"Заказ №{this.Number}\tНазвание: {this.Products[j].Name}\tОписание: {this.Products[j].Description}");
                if (this.PlaceOfDelivery == "Пункт выдачи")
                {
                    PickPointDelivery.Order[j] = this.Products[j];
                }
                if (this.PlaceOfDelivery == "Розничный магазин")
                {
                    ShopDelivery.Order[j] = this.Products[j];
                }
            }
        }
    }
}

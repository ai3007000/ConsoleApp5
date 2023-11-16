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
        public Order(TDelivery Delivery, int Number, params Product[] Products)
        {
            this.Delivery = Delivery;
            this.Number = Number;
            this.Products = Products;
        }
        private User user { get; set; }
        private TDelivery Delivery { get; set; } // Доставка

        private int Number { get; set; } // Номер заказа
        private Product[] Products { get; set; } // Продукт (название и описание)
        /// <summary>
        /// Показать адрес доставки
        /// </summary>
        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.ShowAddress());
        }

        // ... Другие поля
    }
}

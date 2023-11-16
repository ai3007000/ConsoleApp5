using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.ConsoleApp
{
    /// <summary>
    /// Продукт
    /// </summary>
    class Product
    {
        public Product(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
        }
        static Product()
        {
            QuantityOrder++;
        }
        public string Name { get; set; } // Название
        public string Description { get; set; } // Описание
        private static int QuantityOrder; // Количество заказов
        /// <summary>
        /// Показать количество заказов
        /// </summary>
        public static void ShowQuantityOrder()
        {
            Console.WriteLine(QuantityOrder);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.ConsoleApp
{
    /// <summary>
    /// Доставка
    /// </summary>
    abstract class Delivery
    {
        public string Address { get; set; } // Адрес
        public abstract string ShowAddress(); 
    }

    /// <summary>
    /// Доставка на дом
    /// </summary>
    class HomeDelivery : Delivery
    {
        public HomeDelivery(string Address)
        {
            this.Address = Address;
        }
        private string Address { get; set; } // Адрес
        /// <summary>
        /// Показать адрес доставки
        /// </summary>
        /// <returns>Адрес доставки</returns>
        public override string ShowAddress()
        {
            return this.Address;
        }
    }

    /// <summary>
    /// Доставка в пункт выдачи
    /// </summary>
    class PickPointDelivery : Delivery
    {
        public PickPointDelivery(string Address)
        {
            this.Address = Address;
        }
        private string Address { get; set; }
        /// <summary>
        /// Показать адрес доставки
        /// </summary>
        /// <returns>Адрес доставки</returns>
        public override string ShowAddress()
        {
            return this.Address;
        }
    }

    /// <summary>
    /// Доставка в розничный магазин
    /// </summary>
    class ShopDelivery : Delivery
    {
        public ShopDelivery(string Address)
        {
            this.Address = Address;
        }
        private string Address { get; set; }
        /// <summary>
        /// Показать адрес доставки
        /// </summary>
        /// <returns>Адрес доставки</returns>
        public override string ShowAddress()
        {
            return this.Address;
        }
    }
}

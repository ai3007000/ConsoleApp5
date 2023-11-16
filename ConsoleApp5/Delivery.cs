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
        public abstract void MakeDelivery();

    }

    /// <summary>
    /// Доставка на дом
    /// </summary>
    class HomeDelivery : Delivery
    {
        public HomeDelivery(string Address)
        {
            this.Address = Address;
            this.Courier = new User("Василий Васечкин", new Company("CDEK", "+9816498564"));
        }
        private string Address { get; set; } // Адрес
        private User Courier { get; set; } // Курьер
        /// <summary>
        /// Показать адрес доставки
        /// </summary>
        /// <returns>Адрес доставки</returns>
        public override string ShowAddress()
        {
            return this.Address;
        }
        /// <summary>
        /// Показать курьера
        /// </summary>
        private void ShowCourier()
        {
            Console.Write("Курьер ");
            this.Courier.ShowName(); // Имя курьера
            this.Courier.ShowCompany(); // Показать данные компании
        }
        /// <summary>
        /// Произвести доставку
        /// </summary>
        public override void MakeDelivery()
        {
            Console.WriteLine($"Адрес доставки: {this.ShowAddress()}");
            this.ShowCourier();
        }
    }

    /// <summary>
    /// Доставка в пункт выдачи
    /// </summary>
    class PickPointDelivery : Delivery
    {
        static PickPointDelivery()
        {
            Order = new Product[100]; // Количество мест на складе
        }
        public PickPointDelivery(string Address)
        {
            this.Address = Address;
            this.WorkingHours = "С 9:00 до 18:00";
        }
        private string Address { get; set; }
        public static Product[] Order {  get; set; }
        private string WorkingHours {  get; set; }
        /// <summary>
        /// Показать адрес доставки
        /// </summary>
        /// <returns>Адрес доставки</returns>
        public override string ShowAddress()
        {
            return this.Address;
        }
        /// <summary>
        /// Произвести доставку
        /// </summary>
        public override void MakeDelivery()
        {
            Messenger.SendMessage<EmailMessage>(new EmailMessage($"Адрес доставки: {this.ShowAddress()}"));
        }
        /// <summary>
        /// Показать часы работы
        /// </summary>
        public void ShowWorkingHours()
        {
            Messenger.SendMessage<EmailMessage>(new EmailMessage($"Часы работы: {this.WorkingHours}"));
        }
    }

    /// <summary>
    /// Доставка в розничный магазин
    /// </summary>
    class ShopDelivery : Delivery
    {
        static ShopDelivery()
        {
            Order = new Product[100]; // Количество мест на складе
        }
        public ShopDelivery(string Address)
        {
            this.Address = Address;
            this.WorkingHours = "С 9:00 до 18:00";
        }
        private string Address { get; set; }
        private string WorkingHours { get; set; }
        public static Product[] Order { get; set; }
        /// <summary>
        /// Показать адрес доставки
        /// </summary>
        /// <returns>Адрес доставки</returns>
        public override string ShowAddress()
        {
            return this.Address;
        }
        /// <summary>
        /// Произвести доставку
        /// </summary>
        public override void MakeDelivery()
        {
            Messenger.SendMessage<EmailMessage>(new EmailMessage($"Адрес доставки: {this.ShowAddress()}"));
        }
        /// <summary>
        /// Показать часы работы
        /// </summary>
        public void ShowWorkingHours()
        {
            Messenger.SendMessage<EmailMessage>(new EmailMessage($"Часы работы: {this.WorkingHours}"));
        }
    }
}

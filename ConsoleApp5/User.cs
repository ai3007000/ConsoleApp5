using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.ConsoleApp
{
    /// <summary>
    /// Пользователь
    /// </summary>
    class User
    {
        public User(string Name, Company Company)
        {
            this.Name = Name;
            this.Company = Company;
        }

        private string Name { get; set; }
        private Company Company { get; set; }
        /// <summary>
        /// Показать имя
        /// </summary>
        /// <returns></returns>
        public void ShowName()
        {
            Console.WriteLine($"Имя: {this.Name}");
        }
        public void ShowCompany()
        {
            Console.WriteLine($"Название компании: {this.Company.ShowCompany()}\nРабочий тел.:{this.Company.ShowWorkNumberOfPhone()}");
        }
    }
}

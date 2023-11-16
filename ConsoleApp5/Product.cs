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
        public string Name; // Название
        public string Description; // Описание
    }
}

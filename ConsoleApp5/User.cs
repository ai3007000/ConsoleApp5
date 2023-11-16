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
        public User(string Name)
        {
            this.Name = Name;
        }

        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.ConsoleApp
{
    /// <summary>
    /// Компания
    /// </summary>
    class Company
    {
        public Company(string company, string WorkNumberOfPhone) 
        { 
            this.company = company;
            this.WorkNumberOfPhone = WorkNumberOfPhone;
        }
        private string company {  get; set; }
        private string WorkNumberOfPhone {  get; set; }
        /// <summary>
        /// Показать название компании
        /// </summary>
        /// <returns></returns>
        public string ShowCompany()
        {
            return this.company;
        }
        /// <summary>
        /// Показать рабочий телефон
        /// </summary>
        /// <returns></returns>
        public string ShowWorkNumberOfPhone()
        {
            return this.WorkNumberOfPhone;
        }
    }
}

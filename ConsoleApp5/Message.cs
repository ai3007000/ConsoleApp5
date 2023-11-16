using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.ConsoleApp
{
    /// <summary>
    /// Сообщение
    /// </summary>
    class Message
    {
        public string TextMessage {  get; set; }
        public void ShowMessage()
        {
            Console.WriteLine(this.TextMessage);
        }
    }

    /// <summary>
    /// Email сообщение
    /// </summary>
    class EmailMessage : Message
    {

    }

    /// <summary>
    /// Смс сообщение
    /// </summary>
    class SmsMessage : Message 
    {

    }
}

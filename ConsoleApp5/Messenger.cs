using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.ConsoleApp
{
    class Messenger
    {
        public Messenger(User recipient) 
        {
            this.sender = new User("Интернет-магазин", new Company("Литрес", "486498465416"));
            this.recipient = recipient;
        }
        private User sender { get; set; }
        private User recipient { get; set; }
        /// <summary>
        /// Отправить сообщение
        /// </summary>
        public static void SendMessage<T>(T message) where T : Message
        // Messanger.SendMessage<EmailMessage>(new EmailMessage("jeiwque))
        {
            message.ShowMessage();
        }
        public void ShowSender()
        {
            Console.WriteLine(this.sender);
        }
    }
}

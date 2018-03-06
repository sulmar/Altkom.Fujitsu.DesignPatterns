using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.DesignPatterns.ConsoleClient.BehavioralPatterns.CommandPattern
{
    public interface ICommand
    {
        void Execute();
        bool CanExecute();
    }

    public class Mail
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }

    public class SendCommand : ICommand
    {
        private readonly Mail mail;

        public SendCommand(Mail mail)
        {
            this.mail = mail;
        }

        public bool CanExecute()
        {
            return
                   !string.IsNullOrEmpty(mail.From)
                && !string.IsNullOrEmpty(mail.To);
        }

        public void Execute()
        {
            Console.WriteLine("Sending...");
        }
    }
}

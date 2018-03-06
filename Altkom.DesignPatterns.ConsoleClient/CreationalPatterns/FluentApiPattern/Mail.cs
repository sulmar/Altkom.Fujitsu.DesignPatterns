using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.DesignPatterns.ConsoleClient.CreationalPatterns.FluentApiPattern
{
    public class Mail
    {
        private string from;

        private string to;

        private string cc;

        private string subject;


        public void Send()
        {
            Console.WriteLine($"Sending ... from: {from} to: {to} subject: {subject}");
        }

        public static Mail Create()
        {
            return new Mail();
        }

        public Mail From(string sender)
        {
            this.from = sender;

            return this;
        }

        public Mail To(string recipient)
        {
            this.to = recipient;

            return this;
        }

        public Mail CC(string recipient)
        {
            this.cc = this.cc + "," + recipient;

            return this;
        }

        public Mail Subject(string subject)
        {
            this.subject = subject;

            return this;
        }



    }
}

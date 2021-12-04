using System;

namespace Ex2
{
    class Email
    {
        public String Theme { get; set; }
        public String From { get; set; }
        public String To { get; set; }
    }
    interface ISend
    {
        void Send();
    }
    class SendWords : ISend
    {
        Email email;
        public SendWords(Email _email)
        {
            email = _email;
        }
        public void Send()
        {
            Console.WriteLine("Email from '" + email.From + "' to '" + email.To + "' was send. The text: "+ email.Theme );
        }
    }

    class SendFrom : ISend
    {
        Email email;
        public SendFrom(Email _email)
        {
            email = _email;
        }
        public void Send()
        {
            Console.WriteLine("Email from '" + email.From + "' was send");
        }
    }

    class SendTo : ISend
    {
        Email email;
        public SendTo(Email _email)
        {
            email = _email;
        }
        public void Send()
        {
            Console.WriteLine("Email to '" + email.To + "' was send");
        }
    }
    class SendFromTo : ISend
    {
        Email email;
        public SendFromTo(Email _email)
        {
            email = _email;
        }
        public void Send()
        {
            Console.WriteLine("Email from '" + email.From + "' to '" + email.To + "' was send");
        }
    }
    class EmailSender
    {
        public void Send(ISend send)
        {
            send.Send();
        }
    } 
class Program
    {
        static void Main(string[] args)
        {
            Email e1 = new Email()
            {
                From = "Me",
                To = "Vasya",
                Theme = "Who are you?"
            };
            Email e2 = new Email()
            {
                From = "Vasya",
                To = "Me",
                Theme = "vacuum cleaners!"
            };
            Email e3 = new Email()
            {
                From = "Kolya",
                To =
           "Vasya",
                Theme = "No! Thanks!"
            };
            Email e4 = new Email()
            {
                From = "Vasya",
                To = "Me",
                Theme = "washing machines!"
            };
            Email e5 = new Email()
            {
                From = "Me",
                To = "Vasya",
                Theme = "Yes"
            };
            Email e6 = new Email()
            {
                From = "Vasya",
                To =
           "Petya",
                Theme = "+2"
            };
            EmailSender es = new EmailSender();
            es.Send(new SendWords(e1));
            es.Send(new SendTo(e2));
            es.Send(new SendFrom(e3));
            es.Send(new SendFromTo(e4));
            es.Send(new SendWords(e5));
            es.Send(new SendTo(e6));
            Console.ReadKey();
        }
    }

}

using System;


namespace SRP
{
    class Program
    {

        public static void BadExample()
        {
            var emailSender = new EmailSenderBad();
            emailSender.Send();
            emailSender.AddToStats();
            emailSender.LogError(new Exception("Coś poszło nie tak"));
        }



        static void Main(string[] args)
        {
            
            Console.WriteLine($"Hello World! This is SRP ");
            Console.ReadLine();
        }
    }

    public class GoodExample
    {
        private  IEmailSender _emailSender;
        private  ILoger _loger;
        private  IStatistic _statistic;

        public GoodExample(IEmailSender emailSender, ILoger loger, IStatistic statistic)
        {
            _emailSender = emailSender;
            _loger = loger;
            _statistic = statistic;
        }

        public void SendEmail()
        {
            try
            {
                _emailSender.Send();
                _statistic.Add(_emailSender);

            }
            catch (Exception e)
            {
                _loger.LogError(e);
                throw;
            }
        }
    }
}

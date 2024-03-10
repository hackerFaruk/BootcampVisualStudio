namespace ConsoleApp.BootCampNotes.OOP.Polymorph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmsNotification yeniMesaj = new SmsNotification();
            EmailNotification yeniMail = new EmailNotification();

            yeniMail.History();
            yeniMesaj.Call();
            yeniMail.SendNotification("habeer");
            yeniMail.SecretNotKeeper(); // private clasla yaptığı işlemi dışarı vermek için publica 
            

        }
    }

    class Notification
    {
        // bu emthoda farklı clasllarda override edilebilir artık virtual sayesinde
        public virtual void SendNotification(string data)
        {
            Console.WriteLine("dikkat dikkat haber haber ");
        }

        public void History()
        {
            Console.WriteLine("eski bildirimler kontrol ediliyorr");
        }
    }

    class SmsNotification : Notification
    {
        public  void Call()
        {
            Console.WriteLine("dülülü dülülül telefon çalır ");
        }
    }

    class EmailNotification : Notification
    {
        public override void SendNotification(string data)
        {
            Console.WriteLine("Internet Çağı Haberiiii");
        }

        private string SecretKeeper()
        {
            Console.WriteLine("bu sırdı");

            return "sır";
        }
        public void SecretNotKeeper()
        {
            Console.WriteLine(SecretKeeper());
        }
    }
}

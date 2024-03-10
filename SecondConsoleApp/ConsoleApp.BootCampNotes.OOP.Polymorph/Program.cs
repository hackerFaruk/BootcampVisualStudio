namespace ConsoleApp.BootCampNotes.OOP.Polymorph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmsNotification yeniMesaj = new SmsNotification();
            EmailNotification yeniMail = new EmailNotification();
            Notification yeniNotfi = new Notification();    

            yeniMail.History();
            yeniMesaj.Call();
            yeniMail.SendNotification("habeer");
            yeniMail.SecretNotKeeper(); // private clasla yaptığı işlemi dışarı vermek için publica 

            Notification[] allNotfis = new Notification[3];
            allNotfis[0] = yeniMail;
            allNotfis[1] = yeniMesaj;
            allNotfis[2] = yeniNotfi;


            foreach (Notification item in allNotfis)
            {
                Console.WriteLine("Hepsi base claslarına göre muamel alabilir");
            }

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

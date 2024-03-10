
// burada encapsulation konuşcaz ve oop anlayan biri olcaz 

namespace ConsoleApp.BootCampNotes.OOP.Enkapsulasyon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }



        public class Car
        {
            private string make;
            private string model;
            private int year;

            public Car(string make, string model, int year)
            {

                // bunlar private fieldlar  öyle dışardan ulaşaman
                this.make = make;
                this.model = model;
                this.year = year;
            }

            // Propertyler ise senin gizli alanlara ulaştırır ve bunu yaparken denetim verir 
            // bu encapsulation ite 
            public string Make
            {
                get { return make; }
                set { make = value; }
            }

            public string Model
            {
                get { return model; }
                set { model = value; }
            }

            public int Year
            {
                get { return year; }
                set { year = value; }
            }

            // Method demonstrating encapsulated behavior
            public void Start()
            {
                RevEngine();
                ReleaseBreaks();
                FullThrotle();
            }



            private void RevEngine()
            {
                Console.WriteLine("wroom wroom");
            }

            private void ReleaseBreaks()
            {
                Console.WriteLine("breaks are disangaged");
            }

            private void FullThrotle()
            {
                Console.WriteLine(" Gotto go fastt");
            }
        }







    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMarket
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string TCKN { get; set; }
        public string PhoneNumber { get; set; }

        public Person( string name , string  lastName) {
        
            this.Name = name;
            this.LastName = lastName;

            Random rnd = new Random();
            this.TCKN = rnd.Next(10000, 10000).ToString(); 
            this.TCKN += rnd.Next(10000, 10000).ToString(); 
            this.TCKN += rnd.Next(1, 10).ToString(); 

            this.PhoneNumber = rnd.Next(1000000, 10000000).ToString();

        }

        
    }
}

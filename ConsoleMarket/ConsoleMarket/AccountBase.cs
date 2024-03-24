namespace ConsoleMarket
{
    public class AccountBase
    {
        public Person AccountOwner { get; private set; }


        public AccountBase(Person accountOwner)
        {
            this.AccountOwner = accountOwner;
            
        }
    }
}
using System;

namespace Chap13Part3
{
    class Account
    {
        protected string ID;
        protected decimal balance;

        public Account()
        {
            ID = "";
            balance = 0;
        }

        public Account(string idNum, decimal bal)
        {
            ID = idNum;
            balance = bal;
        }

        public void desposit(decimal amount)
        {
            balance += amount; 
        }

        public virtual void withdraw(decimal amount)
        {
            balance -= amount;
        }

        public override string ToString()
        {
            return ID + ": " + balance;
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
    }

    class CheckingAccount : Account
    {
        private decimal overdraw = -400; 

        public CheckingAccount(string idNum, decimal bal)
            :base(idNum, bal)
        {

        }

        public override void withdraw(decimal amount)
        {
            if ((balance - amount) >= overdraw)
                balance -= amount;
            else
                Console.WriteLine("Insufficient funds");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            CheckingAccount chkAcct = new CheckingAccount("1", 1000);
            chkAcct.withdraw(1500);
            Console.WriteLine(chkAcct.ToString());
            Console.ReadKey();

        }
    }
}

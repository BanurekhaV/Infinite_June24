using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Dotnet
{
    class Accounts
    {
        int balance;

        public Accounts(int a)
        {
            balance = a;
        }

        public void Credit(int amt)
        {
            balance += amt;
            Console.WriteLine(balance);
        }
        public void Debit(int amt)
        {
            balance -= amt;
            Console.WriteLine(balance);
        }
    }
    class TaskEg
    {
        static void Main()
        {
            var account = new Accounts(1000);

            
            var task = new Task[10];
            for(int i= 0; i<task.Length; i++)
            {
                task[i] = Task.Run(() => RandomlyUpdate(account));
            }
            Task.WaitAll(task);
            Console.Read();
        }

        static void RandomlyUpdate(Accounts account)
        {
            var rnd = new Random();
            for(int i=0; i<10; i++)
            {
                var amount = rnd.Next(1, 100);
                bool docredit = rnd.NextDouble() < 0.5;
                if (docredit)
                {
                    account.Credit(amount);
                }
                else
                    account.Debit(amount);
            }
        }
    }
}

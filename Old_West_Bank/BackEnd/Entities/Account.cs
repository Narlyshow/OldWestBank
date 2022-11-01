using System;
using System.Collections.Generic;
using System.Text;

namespace Old_West_Bank.BackEnd.Entities
{
    abstract class Account
    {
        public int Number { get; set; }
        public double Balance { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string HolderName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime AccountDate { get; set; }



        public abstract void Withdraw(double amount);

        public abstract void Deposit(double amount);
    }
}

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

        /// <summary>
        /// Criando o construtor Account apenas para facilitar a instanciação dos contrutores das outras subclasses que vão herdar as propriedades de Account.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="email"></param>
        /// <param name="cpf"></param>
        /// <param name="holderName"></param>
        /// <param name="birthDate"></param>
        /// <param name="accountDate"></param>
        protected Account(string email, string cpf, string holderName, DateTime birthDate, DateTime accountDate)
        {
            Email = email;
            Cpf = cpf;
            HolderName = holderName;
            BirthDate = birthDate;
            AccountDate = accountDate;
        }

        public abstract void Withdraw(double amount);

        public abstract void Deposit(double amount);
    }
}

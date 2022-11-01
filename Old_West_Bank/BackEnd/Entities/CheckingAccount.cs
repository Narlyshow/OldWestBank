using System;
using System.Collections.Generic;
using System.Text;

namespace Old_West_Bank.BackEnd.Entities
{
    class CheckingAccount : Account
    {

        public CheckingAccount(string email, string cpf, string holderName, DateTime birthDate, DateTime accountDate)
            : base(email, cpf, holderName, birthDate, accountDate) { }


        public override void Withdraw(double amount)
        {
            //TODO: Criar lógica de saque da quantia desejada.
            throw new NotImplementedException();
        }

        public override void Deposit(double amount)
        {
            //TODO: Criar lógica de depósito da quantia desejada.
            throw new NotImplementedException();
        }

        public void UpdateBalance()
        {
            //TODO: Mostrar o Saldo Existente na conta para o usuário.
        }


        public override string ToString()
        {
            Console.WriteLine();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nome Completo: " + HolderName + "\nCPF: " + Cpf + "\nEmail: " + Email + "\nData de Nascimento: " + BirthDate.ToString("dd/MM/yyyy") + "\nData de Criação da Conta: " + AccountDate);

            return sb.ToString();
        }
    }
}

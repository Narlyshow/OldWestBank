using System;
using System.Collections.Generic;
using System.Text;

namespace Old_West_Bank.BackEnd.Entities
{
    /// <summary>
    /// Classe Conta Poupança Selada para não ser herdada de nenhuma outra subclasse.
    /// </summary>
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        public int IncomePercentage { get; set; } = 10;

        public SavingsAccount(string email, string cpf, string holderName, DateTime birthDate, DateTime accountDate, double interestRate)
            : base(email, cpf, holderName, birthDate, accountDate)
        {
            InterestRate = interestRate;
        }

        public override void Withdraw(double amount)
        {
            //TODO: Criar lógica de saque da quantia desejada de acordo com a taxa de juros.
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

        public void YieldBalance(int IncomePercentage, DateTime time)
        {
            //TODO: Criar Lógica de Rendimento para conta render x % em determinado tempo --> ??(segundo / minuto / hora / dia)??
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

using System;
using System.Text;
using System.Globalization;
namespace Old_West_Bank.BackEnd.Entities
{
    class BusinessAccount : Account
    {
        /// <summary>
        /// Nome da empresa, CNPJ, Limite de Empréstimo da conta e Quantidade de Empréstimos disponpiveis.
        /// </summary>
        public string CompanyName { get; set; }
        public string Cnpj { get; set; }
        public double LoanLimit { get; set; }
        public int QuantityLoan { get; set; }

        public BusinessAccount(string email, string cpf, string holderName, DateTime birthDate, DateTime accountDate, string companyName, string cnpj, double loanLimit, int quantityLoan)
            : base(email, cpf, holderName, birthDate, accountDate)
        {
            CompanyName = companyName;
            Cnpj = cnpj;
            LoanLimit = loanLimit;
            QuantityLoan = quantityLoan;
        }

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

        public void Loan(double amount)
        {
            //TODO: Criar lógica de Empréstimo da quantia desejada de acordo com a Quantidade de Empréstimos disponíveis para o usuário
            // e se a quantia pedida ultrapassa o limite de empréstimo. Caso ultrapasse, mostre o até quanto ele pode pegar.

        }

        public void UpdateBalance()
        {
            //TODO: Mostrar o Saldo Existente na conta para o usuário.
        }


        public override string ToString()
        {
            Console.WriteLine();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nome Completo: " 
                + HolderName 
                + "\nCPF: " 
                + Cpf
                + "\nNome Da Empresa: " 
                + CompanyName
                + "\nCNPJ: " 
                + Cnpj 
                +  "\nEmail: " 
                + Email 
                + "\nLimite de Empréstimo: "
                + LoanLimit.ToString("F2", CultureInfo.InvariantCulture)
                + "\nQuantidade de Empréstimos Possíveis: "
                + QuantityLoan
                + "\nData de Nascimento: " 
                + BirthDate.ToString("dd/MM/yyyy") 
                + "\nData de Criação da Conta: " 
                + AccountDate);

            return sb.ToString();
        }
    }
}

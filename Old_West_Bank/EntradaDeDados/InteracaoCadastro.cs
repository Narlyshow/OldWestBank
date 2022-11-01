using Old_West_Bank.BackEnd.Entities;
using Old_West_Bank.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Old_West_Bank.EntradaDeDados
{
    class InteracaoCadastro
    {
        public SavingsAccount TelaCadastroPoupanca()
        {
            Console.Clear();
            double interestRate = 10.0;
            SavingsAccount ContaPoupanca;

            Console.WriteLine("Bem vindo a tela de cadastro da sua conta poupança.");
            Console.WriteLine("Por favor, digite seu:");
            Console.WriteLine();

            Console.Write("CPF: ");
            string cpf = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Nome Completo: ");
            string name = Console.ReadLine();

            Console.Write("Data de Nascimento: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            DateTime accountDate = DateTime.Now;


            Console.WriteLine();
            Console.WriteLine("Sua conta Poupança foi criada com sucesso! ");

            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Dados da conta: ");

            ContaPoupanca = new SavingsAccount(email, cpf, name, birthDate, accountDate, interestRate);

            return ContaPoupanca;

        }

        public BusinessAccount TelaCadastroEmpresarial()
        {
            Console.Clear();
            BusinessAccount ContaEmpresarial;
            double loanLimit = 50000.00;
            int quantityLimit = 3;

            Console.WriteLine("Bem vindo a tela de cadastro da sua conta empresarial.");
            Console.WriteLine("Por favor, digite seu:");
            Console.WriteLine();

            Console.Write("CPF: ");
            string cpf = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Nome Completo: ");
            string name = Console.ReadLine();

            Console.Write("Data de Nascimento: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            DateTime accountDate = DateTime.Now;

            Console.Write("Nome da Empresa: ");
            string companyName = Console.ReadLine();

            Console.Write("CNPJ da Empresa: ");
            string cnpj = Console.ReadLine();



            Console.WriteLine();
            Console.WriteLine("Sua Conta Empresarial foi criada com sucesso! ");
            ContaEmpresarial = new BusinessAccount(email, cpf, name, birthDate, accountDate, companyName, cnpj, loanLimit, quantityLimit);

            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Dados da conta: ");


            return ContaEmpresarial;
        }

        public CheckingAccount TelaCadastroCorrente()
        {
            Console.Clear();
            CheckingAccount ContaCorrente;

            Console.WriteLine("Bem vindo a tela de cadastro da sua conta poupança.");
            Console.WriteLine("Por favor, digite seu:");
            Console.WriteLine();

            Console.Write("CPF: ");
            string cpf = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Nome Completo: ");
            string name = Console.ReadLine();

            Console.Write("Data de Nascimento: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            DateTime accountDate = DateTime.Now;


            Console.WriteLine();
            Console.WriteLine("Sua conta Poupança foi criada com sucesso! ");
            ContaCorrente = new CheckingAccount(email, cpf, name, birthDate, accountDate);

            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Dados da conta: ");

            return ContaCorrente;

            
        }

    }


}

using Old_West_Bank.BackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Old_West_Bank.EntradaDeDados
{
    class InteracaoCadastro
    {
        public void TelaCadastroPoupanca()
        {
            double interestRate = 10.0;
            SavingsAccount contaPoupanca;

            Console.WriteLine("Bem vindo a tela de cadastro da sua conta poupança.");
            Console.WriteLine("Por favor, digite seu:");
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
            Console.WriteLine("Dados da conta: ");

            contaPoupanca = new SavingsAccount(email, cpf, name, birthDate, accountDate, interestRate);
            Console.WriteLine(contaPoupanca.ToString()); 
        }
    }
}

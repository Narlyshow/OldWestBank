using Old_West_Bank.BackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Old_West_Bank.UI
{
    class TelaCadastro
    {
        public string ApresentacaoOpcoesCadastro()
        {
            Console.Clear();
            StringBuilder sb = new StringBuilder();
            Console.WriteLine();
            sb.AppendLine("* Bem vindo ao Cadastro Old West! *");
            sb.AppendLine("Está pronto para ser o cowboy mais rico desse velho oeste?");
            sb.AppendLine("Espero que sim. Antes de começarmos com o seu cadastro, peço que por favor escolha qual conta deseja criar.");
            sb.AppendLine();
            sb.AppendLine("Se deseja criar uma Conta Poupança digite ----> 1");
            sb.AppendLine("Se deseja criar uma Conta Empresarial digite ----> 2");
            sb.AppendLine("Ou se deseja criar uma Conta Corrente digite ----> 3");
            sb.AppendLine("Se ainda não estiver pronto para fazer parte desse Velho Oeste, volte mais tarde ----> 0");

            return sb.ToString();
        }

        public string TelaCadastroPoupanca() {
            StringBuilder sb = new StringBuilder();
            SavingsAccount contaPoupanca;

            //string email, string cpf, string holderName, DateTime birthDate, DateTime accountDate, double interestRate
            sb.AppendLine("* Bem vindo ao Cadastro da sua Conta Poupança! *");
            sb.AppendLine("Digite seu: ");

            sb.Append("CPF: ");
            string cpf = Console.ReadLine();
            sb.Append("Email: ");
            string email = Console.ReadLine();
            sb.Append("Nome Completo: ");
            string nome = Console.ReadLine();
            sb.Append("Data de Nascimento: ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
            DateTime dataDaConta = DateTime.Now;
            double interestRate = 20.00;

            sb.AppendLine("Sua conta foi criada com sucesso! Você vai ser redirecionado para tela de login.");
            contaPoupanca = new SavingsAccount(email, cpf, nome, dataNascimento, dataDaConta, interestRate);
            
            return sb.ToString();
            
        }

        public void TelaCadastroEmpresarial() { }

        public void TelaCadastroCorrente() { }
    }
}

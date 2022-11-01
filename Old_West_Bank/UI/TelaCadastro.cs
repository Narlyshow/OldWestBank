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

        public void TelaCadastroPoupanca() { }

        public void TelaCadastroEsmpresarial() { }

        public void TelaCadastroCorrente() { }
    }
}

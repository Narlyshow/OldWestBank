using System;
using System.Collections.Generic;
using System.Text;

namespace Old_West_Bank.UI
{
    class TelaLogin
    {
    
        public string ApresentacaoOpcoesLogin()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("* ESCOLHA A SUA OPÇÃO *");
            sb.AppendLine();
            sb.AppendLine("Se já tem cadastro aqui digite ---> 1");
            sb.AppendLine("Se deseja fazer parte do Old West digite ---> 2");
            sb.AppendLine("Ou se deseja sair e voltar outra hora digite ---> 0");

            return sb.ToString();
        }
    }
}

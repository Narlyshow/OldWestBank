using Old_West_Bank.BackEnd.Entities;
using Old_West_Bank.EntradaDeDados;
using Old_West_Bank.UI;
using System;
using System.IO;
using System.Threading;

namespace Old_West_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Sair sair = new Sair();
            TelaLogin tl = new TelaLogin();
            ValidadorOpcoes validador = new ValidadorOpcoes();
            ConsoleKeyInfo keyInfo;

            Console.Title = "Old West BANK";
            TelaBoasVindas telaInicial = new TelaBoasVindas();
            TelaCadastro telaCadastroInicial = new TelaCadastro();
            InteracaoCadastro telaCadastroInt = new InteracaoCadastro();

            telaInicial.TelaApresentacao();

            /*do
            {
                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.Write(tl.ApresentacaoOpcoesLogin());
                    break;
                    
                }
                else if (keyInfo.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.WriteLine("OOOld West agradece a visita!");
                    sair.Exit();
                    
                }


            } while (keyInfo.Key != ConsoleKey.Enter || keyInfo.Key != ConsoleKey.Escape);*/


            while (true)
            {
                keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.Write(tl.ApresentacaoOpcoesLogin());
                    break;
                }
                else if (keyInfo.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.WriteLine("OOOld West agradece a visita!");
                    sair.Exit();

                }
                if (keyInfo.Key != ConsoleKey.Enter || keyInfo.Key != ConsoleKey.Escape)
                    continue;

            }

            string opLogin = String.Empty;
            string opCadastro = String.Empty;

            do
            {

                opLogin = Console.ReadLine();
                bool op = validador.ValidarOpcao(opLogin);
                if (op == false)
                {
                    Console.Clear();
                    Console.WriteLine("Opção Inválida tente novamente!");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Console.Write(tl.ApresentacaoOpcoesLogin());

                }
                else
                {
                    break;
                }

            } while (true);


            while (true)
            {
                if (opLogin == "1")
                {
                    //TODO: chamar/criar metodo da tela de opções do usuario que já é cadastrado 
                    break;
                }
                else if (opLogin == "2")
                {
                    //TODO: chamar/criar metodo da tela de cadastro de usuario
                    Console.WriteLine(telaCadastroInicial.ApresentacaoOpcoesCadastro());
                    break;
                }
                else
                {
                    sair.Exit();
                    break;
                }
            }

            opCadastro = Console.ReadLine();
            if (opCadastro == "1")
            {
                Console.WriteLine(telaCadastroInt.TelaCadastroPoupanca());
            }
            else if (opCadastro == "2")
            {
                Console.WriteLine(telaCadastroInt.TelaCadastroEmpresarial());

            }
            else if (opCadastro == "3")
            {
                Console.WriteLine(telaCadastroInt.TelaCadastroCorrente());
            }
            else if (opCadastro == "0")
            {
                sair.Exit();
            }

        }
    }
}

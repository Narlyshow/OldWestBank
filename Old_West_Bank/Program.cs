using Old_West_Bank.BackEnd.Entities;
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
            TelaCadastro telaCadastro = new TelaCadastro();

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


            if (opLogin == "1")
            {
                //TODO: chamar/criar metodo da tela de opções do usuario que já é cadastrado 
            }
            else if (opLogin == "2")
            {
                //TODO: chamar/criar metodo da tela de cadastro de usuario
                Console.WriteLine(telaCadastro.ApresentacaoOpcoesCadastro());
                
            }
            else
            {
                sair.Exit();
            }


        }
    }
}

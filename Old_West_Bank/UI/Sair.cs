using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Old_West_Bank.UI
{
    class Sair
    {

        public void Exit()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            string op = "Encerrando";
            Console.Write(op);           
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);           
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Environment.Exit(0);
        }

    }
}

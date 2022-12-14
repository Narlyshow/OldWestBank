using Old_West_Bank.BackEnd.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace Old_West_Bank.UI
{
    class TelaBoasVindas
    {

        /// <summary>
        /// Carrega um texto .txt na tela 
        /// </summary>
        public void TelaApresentacao()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string path = Directory.GetCurrentDirectory();

            string arquivo = Path.Combine(path + @"\Txt_Tela", "TELA_INICIAL.txt");

            if (File.Exists(arquivo))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(arquivo))
                    {
                        String linha;
                        // Lê linha por linha até o final do arquivo
                        while ((linha = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(linha);
                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine(" O arquivo inicial não foi localizado !");
            }

            }

    }
}

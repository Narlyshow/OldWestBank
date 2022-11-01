using System;
using System.Collections.Generic;
using System.Text;

namespace Old_West_Bank.BackEnd.Entities
{
    class ValidadorOpcoes
    {

        public int opcao { get; set; }


        public ValidadorOpcoes()
        {
        }

        public ValidadorOpcoes(int opcao)
        {
            this.opcao = opcao;
        }



        public bool ValidarOpcao(string opLogin)
        {

            //int n;
            //bool result = Int32.TryParse(opLogin, out n);          
            if (opLogin == "1" || opLogin == "2" || opLogin == "0")           
                return true;          
            else
                return false;
          
        }
    
    }


}

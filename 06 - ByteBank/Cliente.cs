using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    public class Cliente
    {
        public string _cpf; 
        public string Nome { get; set; }
        public string CPF 
        {
            get 
            {
                return _cpf;
            } 
            set
            {
                // logica de programação de CPF
                _cpf = value;
            } 
        }
        public string Profissao { get; set; }
       
        //prop + 2 tab --> atalho para get e set 
    }   
}

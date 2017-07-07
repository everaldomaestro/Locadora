using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation
{
    public class Validation
    {
        private string cnpjcpf;
        private string nome;
        private string data;
        private string moeda;

        private bool teste = false;

        public bool CNPJCPF(string cnpjcpf)
        {
            this.cnpjcpf = cnpjcpf;


            return teste;
        }

        public bool Nome(string nome)
        {
            this.nome = nome;


            return teste;
        }

        public bool Data(string data)
        {
            this.data = data;


            return teste;
        }

        public bool Moeda(string moeda)
        {
            this.moeda = moeda;


            return teste;
        }
    }
}

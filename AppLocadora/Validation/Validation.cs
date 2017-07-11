using System.Text.RegularExpressions;

namespace Util
{
    public class Validation
    {
        private string _cpf;
        private string _nome;
        private string _data;
        private string _moeda;

        private bool teste = false;

        public bool CPF(string cpf)
        {
            return true;
        }

        public bool Nome(string nome)
        {
            Regex rgx = new Regex(@"^[A-ZÀ-Ú]+((\s[A-ZÀ-Ú]+)+)?$");

            if (rgx.IsMatch(nome))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Data(string data)
        {
            _data = data;


            return teste;
        }

        public bool Moeda(string moeda)
        {
            _moeda = moeda;


            return teste;
        }
    }
}

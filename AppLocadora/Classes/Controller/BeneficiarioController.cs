using Classes.Conexao;
using Classes.DAO;
using Classes.Entidades;
using Interfaces.Operation;
using System.Collections.ObjectModel;

namespace Classes.Controller
{
    public class BeneficiarioController
    {
        public Collection<Beneficiario> ListarTudo()
        {
            Collection<Beneficiario> result = null;

            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Beneficiario> TableIDAO = new BeneficiarioDAO(con);

                result = TableIDAO.ListarTudo();
            }

            return result;
        }

        public Beneficiario LocalizarPorCodigo(int ID)
        {
            Beneficiario result = null;

            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Beneficiario> TableIDAO = new BeneficiarioDAO(con);

                Beneficiario b = TableIDAO.LocalizarPorCodigo(ID);
            }

            return result;
        }

        public void Inserir(Beneficiario obj)
        {
            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Beneficiario> TableIDAO = new BeneficiarioDAO(con);

                Beneficiario beneficiario = new Beneficiario();
                
                beneficiario.BENEFICIARIO_CNPJCPF = obj.BENEFICIARIO_CNPJCPF;
                beneficiario.BENEFICIARIO_NOMEFAN = obj.BENEFICIARIO_NOMEFAN;
                beneficiario.BENEFICIARIO_RAZAOSOC = obj.BENEFICIARIO_RAZAOSOC;

                TableIDAO.Inserir(beneficiario);
            }
        }

        public void Excluir(int ID)
        {
            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Beneficiario> TableIDAO = new BeneficiarioDAO(con);

                Beneficiario beneficiario = new Beneficiario();
                beneficiario.BENEFICIARIO_ID = ID;

                TableIDAO.Remover(beneficiario);
            }
        }

        public void Atualizar(Beneficiario obj)
        {
            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Beneficiario> TableIDAO = new BeneficiarioDAO(con);

                Beneficiario beneficiario = new Beneficiario();

                beneficiario.BENEFICIARIO_ID = obj.BENEFICIARIO_ID;
                beneficiario.BENEFICIARIO_CNPJCPF = obj.BENEFICIARIO_CNPJCPF;
                beneficiario.BENEFICIARIO_NOMEFAN = obj.BENEFICIARIO_NOMEFAN;
                beneficiario.BENEFICIARIO_RAZAOSOC = obj.BENEFICIARIO_RAZAOSOC;

                TableIDAO.Atualizar(beneficiario);
            }
        }
    }
}

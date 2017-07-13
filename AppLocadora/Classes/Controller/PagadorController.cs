using Classes.Conexao;
using Classes.DAO;
using Classes.Entidades;
using Interfaces.Operation;
using System.Collections.ObjectModel;

namespace Classes.Controller
{
    public class PagadorController
    {
        public Collection<Pagador> ListarTudo()
        {
            Collection<Pagador> result = null;

            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Pagador> TableIDAO = new PagadorDAO(con);

                result = TableIDAO.ListarTudo();
            }

            return result;
        }

        public Pagador LocalizarPorCodigo(int ID)
        {
            Pagador result = null;

            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Pagador> TableIDAO = new PagadorDAO(con);

                Pagador b = TableIDAO.LocalizarPorCodigo(ID);
            }

            return result;
        }

        public void Inserir(Pagador obj)
        {
            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Pagador> TableIDAO = new PagadorDAO(con);

                Pagador pagador = new Pagador();

                pagador.PAGADOR_CNPJCPF = obj.PAGADOR_CNPJCPF;
                pagador.PAGADOR_NOME = obj.PAGADOR_NOME;
                pagador.PAGADOR_NOMECOMPLETO = obj.PAGADOR_NOMECOMPLETO;

                TableIDAO.Inserir(pagador);
            }
        }

        public void Excluir(int ID)
        {
            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Pagador> TableIDAO = new PagadorDAO(con);

                Pagador pagador = new Pagador();
                pagador.PAGADOR_ID = ID;

                TableIDAO.Remover(pagador);
            }
        }

        public void Atualizar(Pagador obj)
        {
            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Pagador> TableIDAO = new PagadorDAO(con);

                Pagador pagador = new Pagador();

                pagador.PAGADOR_ID = obj.PAGADOR_ID;
                pagador.PAGADOR_CNPJCPF = obj.PAGADOR_CNPJCPF;
                pagador.PAGADOR_NOME = obj.PAGADOR_NOME;
                pagador.PAGADOR_NOMECOMPLETO = obj.PAGADOR_NOMECOMPLETO;

                TableIDAO.Atualizar(pagador);
            }
        }

        public Pagador LocalizarPrimeiro()
        {
            Pagador result = null;

            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Pagador> TableIDAO = new PagadorDAO(con);

                result = TableIDAO.LocalizarPrimeiro();
            }

            return result;
        }
    }
}

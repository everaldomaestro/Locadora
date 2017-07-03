using Classes.Conexao;
using Classes.DAO;
using Classes.Entidades;
using Interfaces.Operation;
using System.Collections.ObjectModel;

namespace Classes.Controller
{
    public class Forma_PagController
    {
        public Collection<Forma_Pag> ListarTudo()
        {
            Collection<Forma_Pag> result = null;

            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Forma_Pag> TableIDAO = new Forma_PagDAO(con);

                result = TableIDAO.ListarTudo();
            }

            return result;
        }

        public Forma_Pag LocalizarPorCodigo(int ID)
        {
            Forma_Pag result = null;

            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Forma_Pag> TableIDAO = new Forma_PagDAO(con);

                Forma_Pag b = TableIDAO.LocalizarPorCodigo(ID);
            }

            return result;
        }

        public void Inserir(Forma_Pag obj)
        {
            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Forma_Pag> TableIDAO = new Forma_PagDAO(con);

                Forma_Pag forma_Pag = new Forma_Pag();

                forma_Pag.FORMA_PAG_DESCRICAO = obj.FORMA_PAG_DESCRICAO;

                TableIDAO.Inserir(forma_Pag);
            }
        }

        public void Excluir(int ID)
        {
            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Forma_Pag> TableIDAO = new Forma_PagDAO(con);

                Forma_Pag forma_Pag = new Forma_Pag();
                forma_Pag.FORMA_PAG_ID = ID;

                TableIDAO.Remover(forma_Pag);
            }
        }

        public void Atualizar(Forma_Pag obj)
        {
            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Forma_Pag> TableIDAO = new Forma_PagDAO(con);

                Forma_Pag forma_Pag = new Forma_Pag();

                forma_Pag.FORMA_PAG_ID = obj.FORMA_PAG_ID;
                forma_Pag.FORMA_PAG_DESCRICAO = obj.FORMA_PAG_DESCRICAO;

                TableIDAO.Atualizar(forma_Pag);
            }
        }
    }
}

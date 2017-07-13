using Classes.Conexao;
using Classes.DAO;
using Classes.Entidades;
using Interfaces.Operation;
using System.Collections.ObjectModel;

namespace Classes.Controller
{
    public class Metodo_PagController
    {
        public Collection<Metodo_Pag> ListarTudo()
        {
            Collection<Metodo_Pag> result = null;

            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Metodo_Pag> TableIDAO = new Metodo_PagDAO(con);

                result = TableIDAO.ListarTudo();
            }

            return result;
        }

        public Metodo_Pag LocalizarPorCodigo(int ID)
        {
            Metodo_Pag result = null;

            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Metodo_Pag> TableIDAO = new Metodo_PagDAO(con);

                result = TableIDAO.LocalizarPorCodigo(ID);
            }

            return result;
        }

        public void Inserir(Metodo_Pag obj)
        {
            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Metodo_Pag> TableIDAO = new Metodo_PagDAO(con);

                Metodo_Pag metodo_pag = new Metodo_Pag();

                metodo_pag.METODO_PAG_DESCRICAO = obj.METODO_PAG_DESCRICAO;

                TableIDAO.Inserir(metodo_pag);
            }
        }

        public void Excluir(int ID)
        {
            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Metodo_Pag> TableIDAO = new Metodo_PagDAO(con);

                Metodo_Pag metodo_pag = new Metodo_Pag();
                metodo_pag.METODO_PAG_ID = ID;

                TableIDAO.Remover(metodo_pag);
            }
        }

        public void Atualizar(Metodo_Pag obj)
        {
            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Metodo_Pag> TableIDAO = new Metodo_PagDAO(con);

                Metodo_Pag metodo_pag = new Metodo_Pag();

                metodo_pag.METODO_PAG_ID = obj.METODO_PAG_ID;
                metodo_pag.METODO_PAG_DESCRICAO = obj.METODO_PAG_DESCRICAO;

                TableIDAO.Atualizar(metodo_pag);
            }
        }

        public Metodo_Pag LocalizarPrimeiro()
        {
            Metodo_Pag result = null;

            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Metodo_Pag> TableIDAO = new Metodo_PagDAO(con);

                result = TableIDAO.LocalizarPrimeiro();
            }

            return result;
        }
    }
}

using Classes.Conexao;
using Classes.DAO;
using Classes.Entidades;
using Interfaces.Operation;
using System.Collections.ObjectModel;

namespace Classes.Controller
{
    public class Tipo_PagControlle
    {
        public Collection<Tipo_Pag> ListarTudo()
        {
            Collection<Tipo_Pag> result = null;

            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Tipo_Pag> TableIDAO = new Tipo_PagDAO(con);

                result = TableIDAO.ListarTudo();
            }

            return result;
        }

        public Tipo_Pag LocalizarPorCodigo(int ID)
        {
            Tipo_Pag result = null;

            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Tipo_Pag> TableIDAO = new Tipo_PagDAO(con);

                Tipo_Pag b = TableIDAO.LocalizarPorCodigo(ID);
            }

            return result;
        }

        public void Inserir(Tipo_Pag obj)
        {
            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Tipo_Pag> TableIDAO = new Tipo_PagDAO(con);

                Tipo_Pag tipo_pag = new Tipo_Pag();

                tipo_pag.TIPO_PAG_DESCRICAO = obj.TIPO_PAG_DESCRICAO;

                TableIDAO.Inserir(tipo_pag);
            }
        }

        public void Excluir(int ID)
        {
            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Tipo_Pag> TableIDAO = new Tipo_PagDAO(con);

                Tipo_Pag tipo_pag = new Tipo_Pag();
                tipo_pag.TIPO_PAG_ID = ID;

                TableIDAO.Remover(tipo_pag);
            }
        }

        public void Atualizar(Tipo_Pag obj)
        {
            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Tipo_Pag> TableIDAO = new Tipo_PagDAO(con);

                Tipo_Pag tipo_pag = new Tipo_Pag();

                tipo_pag.TIPO_PAG_ID = obj.TIPO_PAG_ID;
                tipo_pag.TIPO_PAG_DESCRICAO = obj.TIPO_PAG_DESCRICAO;

                TableIDAO.Atualizar(tipo_pag);
            }
        }
    }
}

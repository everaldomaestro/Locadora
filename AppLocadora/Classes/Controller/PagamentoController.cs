using Classes.Conexao;
using Classes.DAO;
using Classes.Entidades;
using Interfaces.Operation;
using System.Collections.ObjectModel;

namespace Classes.Controller
{
    public class PagamentoController
    {
        public Collection<Pagamento> ListarTudo()
        {
            Collection<Pagamento> result = null;

            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Pagamento> TableIDAO = new PagamentoDAO(con);

                result = TableIDAO.ListarTudo();
            }

            return result;
        }

        public Pagamento LocalizarPorCodigo(int ID)
        {
            Pagamento result = null;

            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Pagamento> TableIDAO = new PagamentoDAO(con);

                Pagamento b = TableIDAO.LocalizarPorCodigo(ID);
            }

            return result;
        }

        public void Inserir(Pagamento obj)
        {
            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Pagamento> TableIDAO = new PagamentoDAO(con);

                Pagamento pagamento = new Pagamento();

                pagamento.PAGAMENTO_DATA = obj.PAGAMENTO_DATA;
                pagamento.PAGAMENTO_VENCIMENTO = obj.PAGAMENTO_VENCIMENTO;
                pagamento.PAGAMENTO_VALORPAGAR = obj.PAGAMENTO_VALORPAGAR;
                pagamento.PAGAMENTO_VALORPAGO = obj.PAGAMENTO_VALORPAGO;
                pagamento.PAGAMENTO_PAGADOR = obj.PAGAMENTO_PAGADOR;
                pagamento.PAGAMENTO_BENEFICIARIO = obj.PAGAMENTO_BENEFICIARIO;
                pagamento.PAGAMENTO_METODOPAG = obj.PAGAMENTO_METODOPAG;
                pagamento.PAGAMENTO_FORMAPAG = obj.PAGAMENTO_FORMAPAG;
                pagamento.PAGAMENTO_TIPOPAG = obj.PAGAMENTO_TIPOPAG;

                TableIDAO.Inserir(pagamento);
            }
        }

        public void Excluir(int ID)
        {
            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Pagamento> TableIDAO = new PagamentoDAO(con);

                Pagamento pagamento = new Pagamento();
                pagamento.PAGAMENTO_ID = ID;

                TableIDAO.Remover(pagamento);
            }
        }

        public void Atualizar(Pagamento obj)
        {
            using (Connection con = new Connection())
            {
                con.Abrir();
                IDAO<Pagamento> TableIDAO = new PagamentoDAO(con);

                Pagamento pagamento = new Pagamento();

                pagamento.PAGAMENTO_ID = obj.PAGAMENTO_ID;
                pagamento.PAGAMENTO_DATA = obj.PAGAMENTO_DATA;
                pagamento.PAGAMENTO_VENCIMENTO = obj.PAGAMENTO_VENCIMENTO;
                pagamento.PAGAMENTO_VALORPAGAR = obj.PAGAMENTO_VALORPAGAR;
                pagamento.PAGAMENTO_VALORPAGO = obj.PAGAMENTO_VALORPAGO;
                pagamento.PAGAMENTO_PAGADOR = obj.PAGAMENTO_PAGADOR;
                pagamento.PAGAMENTO_BENEFICIARIO = obj.PAGAMENTO_BENEFICIARIO;
                pagamento.PAGAMENTO_METODOPAG = obj.PAGAMENTO_METODOPAG;
                pagamento.PAGAMENTO_FORMAPAG = obj.PAGAMENTO_FORMAPAG;
                pagamento.PAGAMENTO_TIPOPAG = obj.PAGAMENTO_TIPOPAG;

                TableIDAO.Atualizar(pagamento);
            }
        }
    }
}

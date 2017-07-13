using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Entidades;
using Interfaces.Operation;
using Interfaces.Conexao;
using System.Data.SqlClient;
using System.Data;

namespace Classes.DAO
{
    public class PagamentoDAO : IDAO<Pagamento>, IDisposable
    {

        private IConnection _connection;

        public PagamentoDAO(IConnection Connection)
        {
            this._connection = Connection;
        }

        public void Atualizar(Pagamento model)//OK
        {
            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "UPDATE PAGAMENTO SET " +
                    "PAGAMENTO_DATA=@DATA," +
                    "PAGAMENTO_VENCIMENTO=@VENCIMENTO," +
                    "PAGAMENTO_VALORPAGAR=@VALORPAGAR," +
                    "PAGAMENTO_VALORPAGO=@VALORPAGO," +
                    "PAGAMENTO_PAGADOR=@PAGADOR," +
                    "PAGAMENTO_BENEFICIARIO=@BENEFICIARIO," +
                    "PAGAMENTO_METODOPAG=@METODOPAG," +
                    "PAGAMENTO_FORMAPAG=@FORMAPAG," +
                    "PAGAMENTO_TIPOPAG=@TIPOPAG " +
                    "WHERE PAGAMENTO_ID=@ID";

                cmd.Parameters.Add("@DATA", SqlDbType.Date).Value =
                    model.PAGAMENTO_DATA;
                cmd.Parameters.Add("@VENCIMENTO", SqlDbType.Date).Value =
                    model.PAGAMENTO_VENCIMENTO;
                cmd.Parameters.Add("@VALORPAGAR", SqlDbType.SmallMoney).Value =
                    model.PAGAMENTO_VALORPAGAR;
                cmd.Parameters.Add("@VALORPAGO", SqlDbType.SmallMoney).Value =
                    model.PAGAMENTO_VALORPAGO;
                cmd.Parameters.Add("@PAGADOR", SqlDbType.Int).Value =
                    model.PAGAMENTO_PAGADOR;
                cmd.Parameters.Add("@BENEFICIARIO", SqlDbType.Int).Value =
                    model.PAGAMENTO_BENEFICIARIO;
                cmd.Parameters.Add("@METODOPAG", SqlDbType.Int).Value =
                    model.PAGAMENTO_METODOPAG;
                cmd.Parameters.Add("@FORMAPAG", SqlDbType.Int).Value =
                    model.PAGAMENTO_FORMAPAG;
                cmd.Parameters.Add("@TIPOPAG", SqlDbType.Int).Value =
                    model.PAGAMENTO_TIPOPAG;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value =
                    model.PAGAMENTO_ID;

                cmd.ExecuteNonQuery();
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Pagamento Inserir(Pagamento model)//OK
        {
            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "INSERT INTO PAGAMENTO (" +
                    "PAGAMENTO_DATA," +
                    "PAGAMENTO_VENCIMENTO," +
                    "PAGAMENTO_VALORPAGAR," +
                    "PAGAMENTO_VALORPAGO," +
                    "PAGAMENTO_PAGADOR," +
                    "PAGAMENTO_BENEFICIARIO," +
                    "PAGAMENTO_METODOPAG," +
                    "PAGAMENTO_FORMAPAG," +
                    "PAGAMENTO_TIPOPAG)" +
                    "VALUES(" +
                    "@DATA," +
                    "@VENCIMENTO," +
                    "@VALORPAGAR," +
                    "@VALORPAGO," +
                    "@PAGADOR," +
                    "@BENEFICIARIO," +
                    "@METODOPAG," +
                    "@FORMAPAG," +
                    "@TIPOPAG)";

                cmd.Parameters.Add("@DATA", SqlDbType.Date).Value = 
                    model.PAGAMENTO_DATA;
                cmd.Parameters.Add("@VENCIMENTO", SqlDbType.Date).Value =
                    model.PAGAMENTO_VENCIMENTO;
                cmd.Parameters.Add("@VALORPAGAR", SqlDbType.SmallMoney).Value =
                    model.PAGAMENTO_VALORPAGAR;
                cmd.Parameters.Add("@VALORPAGO", SqlDbType.SmallMoney).Value =
                    model.PAGAMENTO_VALORPAGO;
                cmd.Parameters.Add("@PAGADOR", SqlDbType.Int).Value =
                    model.PAGAMENTO_PAGADOR;
                cmd.Parameters.Add("@BENEFICIARIO", SqlDbType.Int).Value =
                    model.PAGAMENTO_BENEFICIARIO;
                cmd.Parameters.Add("@METODOPAG", SqlDbType.Int).Value =
                    model.PAGAMENTO_METODOPAG;
                cmd.Parameters.Add("@FORMAPAG", SqlDbType.Int).Value =
                    model.PAGAMENTO_FORMAPAG;
                cmd.Parameters.Add("@TIPOPAG", SqlDbType.Int).Value =
                    model.PAGAMENTO_TIPOPAG;

                cmd.ExecuteNonQuery();
            }

            return model;
        }

        public Collection<Pagamento> ListarTudo()//OK
        {
            Collection<Pagamento> Pagamentos = new Collection<Pagamento>();

            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "SELECT " +
                    "PAGAMENTO_ID," +
                    "PAGAMENTO_DATA," +
                    "PAGAMENTO_VENCIMENTO," +
                    "PAGAMENTO_VALORPAGAR," +
                    "PAGAMENTO_VALORPAGO," +
                    "PAGAMENTO_PAGADOR," +
                    "PAGAMENTO_BENEFICIARIO," +
                    "PAGAMENTO_METODOPAG," +
                    "PAGAMENTO_FORMAPAG," +
                    "PAGAMENTO_TIPOPAG " +
                    "FROM PAGAMENTO " +
                    "ORDER BY PAGAMENTO_ID";

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable tblPagamento = new DataTable();
                    adapter.Fill(tblPagamento);

                    foreach (DataRow row in tblPagamento.Rows)
                    {
                        Pagamento pagamento = new Pagamento
                        {
                            PAGAMENTO_ID = int.Parse(row["PAGAMENTO_ID"].ToString()),
                            PAGAMENTO_DATA = DateTime.Parse(row["PAGAMENTO_DATA"].ToString()),
                            PAGAMENTO_VENCIMENTO = DateTime.Parse(row["PAGAMENTO_VENCIMENTO"].ToString()),
                            PAGAMENTO_VALORPAGAR = Decimal.Parse(row["PAGAMENTO_VALORPAGAR"].ToString()),
                            PAGAMENTO_VALORPAGO = Decimal.Parse(row["PAGAMENTO_VALORPAGO"].ToString()),
                            PAGAMENTO_PAGADOR = int.Parse(row["PAGAMENTO_PAGADOR"].ToString()),
                            PAGAMENTO_BENEFICIARIO = int.Parse(row["PAGAMENTO_BENEFICIARIO"].ToString()),
                            PAGAMENTO_METODOPAG = int.Parse(row["PAGAMENTO_METODOPAG"].ToString()),
                            PAGAMENTO_FORMAPAG = int.Parse(row["PAGAMENTO_FORMAPAG"].ToString()),
                            PAGAMENTO_TIPOPAG = int.Parse(row["PAGAMENTO_TIPOPAG"].ToString())
                        };
                        Pagamentos.Add(pagamento);
                    }
                }
            }

            return Pagamentos;

        }

        public Pagamento LocalizarPorCodigo(params object[] keys)//OK
        {
            Pagamento pagamento = null;

            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "SELECT " +
                    "PAGAMENTO_ID," +
                    "PAGAMENTO_DATA," +
                    "PAGAMENTO_VENCIMENTO," +
                    "PAGAMENTO_VALORPAGAR," +
                    "PAGAMENTO_VALORPAGO," +
                    "PAGAMENTO_PAGADOR," +
                    "PAGAMENTO_BENEFICIARIO," +
                    "PAGAMENTO_METODOPAG," +
                    "PAGAMENTO_FORMAPAG," +
                    "PAGAMENTO_TIPOPAG " +
                    "FROM PAGAMENTO " +
                    "WHERE PAGAMENTO_ID=@ID";

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value =
                    keys[0];

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        pagamento = new Pagamento();
                        reader.Read();
                        pagamento.PAGAMENTO_ID = reader.GetInt32(0);
                        pagamento.PAGAMENTO_DATA = reader.GetDateTime(1);
                        pagamento.PAGAMENTO_VENCIMENTO = reader.GetDateTime(2);
                        pagamento.PAGAMENTO_VALORPAGAR = reader.GetDecimal(3);
                        pagamento.PAGAMENTO_VALORPAGO = reader.GetDecimal(4);
                        pagamento.PAGAMENTO_PAGADOR = reader.GetInt32(5);
                        pagamento.PAGAMENTO_BENEFICIARIO = reader.GetInt32(6);
                        pagamento.PAGAMENTO_METODOPAG = reader.GetInt32(7);
                        pagamento.PAGAMENTO_FORMAPAG = reader.GetInt32(8);
                        pagamento.PAGAMENTO_TIPOPAG = reader.GetInt32(9);
                    }
                }
            }

            return pagamento;
        }

        public Pagamento LocalizarPrimeiro()
        {
            Pagamento pagamento = null;

            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "SELECT " +
                    "TOP 1 " +
                    "PAGAMENTO_ID," +
                    "PAGAMENTO_DATA," +
                    "PAGAMENTO_VENCIMENTO," +
                    "PAGAMENTO_VALORPAGAR," +
                    "PAGAMENTO_VALORPAGO," +
                    "PAGAMENTO_PAGADOR," +
                    "PAGAMENTO_BENEFICIARIO," +
                    "PAGAMENTO_METODOPAG," +
                    "PAGAMENTO_FORMAPAG," +
                    "PAGAMENTO_TIPOPAG " +
                    "FROM PAGAMENTO";

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        pagamento = new Pagamento();
                        reader.Read();
                        pagamento.PAGAMENTO_ID = reader.GetInt32(0);
                        pagamento.PAGAMENTO_DATA = reader.GetDateTime(1);
                        pagamento.PAGAMENTO_VENCIMENTO = reader.GetDateTime(2);
                        pagamento.PAGAMENTO_VALORPAGAR = reader.GetDecimal(3);
                        pagamento.PAGAMENTO_VALORPAGO = reader.GetDecimal(4);
                        pagamento.PAGAMENTO_PAGADOR = reader.GetInt32(5);
                        pagamento.PAGAMENTO_BENEFICIARIO = reader.GetInt32(6);
                        pagamento.PAGAMENTO_METODOPAG = reader.GetInt32(7);
                        pagamento.PAGAMENTO_FORMAPAG = reader.GetInt32(8);
                        pagamento.PAGAMENTO_TIPOPAG = reader.GetInt32(9);
                    }
                }
            }

            return pagamento;
        }

        public bool Remover(Pagamento model)//OK
        {
            bool retornar = false;

            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "DELETE FROM PAGAMENTO WHERE PAGAMENTO_ID=@ID";

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value =
                    model.PAGAMENTO_ID;
                
                if(cmd.ExecuteNonQuery() > 0)
                {
                    retornar = true;
                }                
            }

            return retornar;
        }
    }
}

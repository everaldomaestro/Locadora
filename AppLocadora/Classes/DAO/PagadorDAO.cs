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
    public class PagadorDAO : IDAO<Pagador>, IDisposable
    {

        private IConnection _connection;

        public PagadorDAO(IConnection Connection)
        {
            this._connection = Connection;
        }

        public void Atualizar(Pagador model)//OK
        {
            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "UPDATE PAGADOR SET " +
                    "PAGADOR_CNPJCPF=@CNPJCPF," +
                    "PAGADOR_NOME=@NOME " +
                    "WHERE PAGADOR_ID=@ID";

                cmd.Parameters.Add("@CNPJCPF", SqlDbType.Text).Value =
                    model.PAGADOR_CNPJCPF;
                cmd.Parameters.Add("@NOME", SqlDbType.Text).Value =
                    model.PAGADOR_NOME;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value =
                    model.PAGADOR_ID;

                cmd.ExecuteNonQuery();
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Pagador Inserir(Pagador model)//OK
        {
            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "INSERT INTO PAGADOR (" +
                    "PAGADOR_CNPJCPF," +
                    "PAGADOR_NOME)" +
                    "VALUES(" +
                    "@CNPJCPF," +
                    "@NOME)";

                cmd.Parameters.Add("@CNPJCPF", SqlDbType.Text).Value = 
                    model.PAGADOR_CNPJCPF;
                cmd.Parameters.Add("@NOME", SqlDbType.Text).Value =
                    model.PAGADOR_NOME;

                cmd.ExecuteNonQuery();
            }

            return model;
        }

        public Collection<Pagador> ListarTudo()//OK
        {
            Collection<Pagador> Pagadores = new Collection<Pagador>();

            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "SELECT " +
                    "PAGADOR_ID," +
                    "PAGADOR_CNPJCPF," +
                    "PAGADOR_NOME " +
                    "FROM PAGADOR " +
                    "ORDER BY PAGADOR_NOME";

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable tblPagador = new DataTable();
                    adapter.Fill(tblPagador);

                    foreach (DataRow row in tblPagador.Rows)
                    {
                        Pagador pagador = new Pagador
                        {                        
                            PAGADOR_ID = int.Parse(row["PAGADOR_ID"].ToString()),
                            PAGADOR_CNPJCPF = row["PAGADOR_CNPJCPF"].ToString(),
                            PAGADOR_NOME = row["PAGADOR_NOME"].ToString(),
                        };
                        Pagadores.Add(pagador);
                    }
                }
            }

            return Pagadores;

        }

        public Pagador LocalizarPorCodigo(params object[] keys)//OK
        {
            Pagador pagador = null;

            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "SELECT " +
                    "PAGADOR_ID," +
                    "PAGADOR_CNPJCPF," +
                    "PAGADOR_NOME " +
                    "FROM PAGADOR " +
                    "WHERE PAGADOR_ID=@ID";

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value =
                    keys[0];

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        pagador = new Pagador();
                        reader.Read();
                        pagador.PAGADOR_ID = reader.GetInt32(0);
                        pagador.PAGADOR_CNPJCPF = reader.GetString(1);
                        pagador.PAGADOR_NOME = reader.GetString(2);
                    }
                }
            }

            return pagador;
        }

        public bool Remover(Pagador model)//OK
        {
            bool retornar = false;

            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "DELETE FROM PAGADOR WHERE PAGADOR_ID=@ID";

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value =
                    model.PAGADOR_ID;
                
                if(cmd.ExecuteNonQuery() > 0)
                {
                    retornar = true;
                }                
            }

            return retornar;
        }
    }
}

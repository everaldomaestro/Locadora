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
    public class Metodo_PagDAO : IDAO<Metodo_Pag>, IDisposable
    {
        private IConnection _connection;

        public Metodo_PagDAO(IConnection Connection)
        {
            this._connection = Connection;
        }

        public void Atualizar(Metodo_Pag model)//OK
        {
            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "UPDATE METODO_PAG SET " +
                    "METODO_PAG_DESCRICAO=@DESCRICAO " +
                    "WHERE METODO_PAG_ID=@ID";

                cmd.Parameters.Add("@DESCRICAO", SqlDbType.Text).Value =
                    model.METODO_PAG_DESCRICAO;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value =
                    model.METODO_PAG_ID;

                cmd.ExecuteNonQuery();
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Metodo_Pag Inserir(Metodo_Pag model)//OK
        {
            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "INSERT INTO METODO_PAG (" +
                    "METODO_PAG_DESCRICAO) " +
                    "VALUES(" +
                    "@DESCRICAO)";

                cmd.Parameters.Add("@DESCRICAO", SqlDbType.Text).Value =
                    model.METODO_PAG_DESCRICAO;

                cmd.ExecuteNonQuery();
            }

            return model;
        }

        public Collection<Metodo_Pag> ListarTudo()//OK
        {
            Collection<Metodo_Pag> Metodos_Pag = new Collection<Metodo_Pag>();

            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "SELECT " +
                    "METODO_PAG_ID," +
                    "METODO_PAG_DESCRICAO " +
                    "FROM METODO_PAG " +
                    "ORDER BY METODO_PAG_DESCRICAO";

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable tblMetodo_Pag = new DataTable();
                    adapter.Fill(tblMetodo_Pag);

                    foreach (DataRow row in tblMetodo_Pag.Rows)
                    {
                        Metodo_Pag Metodo_Pag = new Metodo_Pag
                        {                        
                            METODO_PAG_ID = int.Parse(row["METODO_PAG_ID"].ToString()),
                            METODO_PAG_DESCRICAO = row["METODO_PAG_DESCRICAO"].ToString(),
                        };

                        Metodos_Pag.Add(Metodo_Pag);
                    }
                }
            }

            return Metodos_Pag;

        }

        public Metodo_Pag LocalizarPorCodigo(params object[] keys)//OK
        {
            Metodo_Pag metodo_pag = null;

            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "SELECT " +
                    "METODO_PAG_ID," +
                    "METODO_PAG_DESCRICAO " +
                    "FROM METODO_PAG " +
                    "WHERE METODO_PAG_ID=@ID";

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value =
                    keys[0];

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        metodo_pag = new Metodo_Pag();
                        reader.Read();
                        metodo_pag.METODO_PAG_ID = reader.GetInt32(0);
                        metodo_pag.METODO_PAG_DESCRICAO = reader.GetString(1);
                    }
                }
            }

            return metodo_pag;
        }

        public Metodo_Pag LocalizarPrimeiro()
        {
            Metodo_Pag metodo_pag = null;

            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "SELECT " +
                    "TOP 1 " +
                    "METODO_PAG_ID," +
                    "METODO_PAG_DESCRICAO " +
                    "FROM METODO_PAG ";

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        metodo_pag = new Metodo_Pag();
                        reader.Read();
                        metodo_pag.METODO_PAG_ID = reader.GetInt32(0);
                        metodo_pag.METODO_PAG_DESCRICAO = reader.GetString(1);
                    }
                }
            }

            return metodo_pag;
        }

        public bool Remover(Metodo_Pag model)//OK
        {
            bool retornar = false;

            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "DELETE FROM METODO_PAG WHERE METODO_PAG_ID=@ID";

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value =
                    model.METODO_PAG_ID;
                
                if(cmd.ExecuteNonQuery() > 0)
                {
                    retornar = true;
                }                
            }

            return retornar;
        }
    }
}

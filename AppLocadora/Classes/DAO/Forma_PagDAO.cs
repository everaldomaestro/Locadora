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
    public class Forma_PagDAO : IDAO<Forma_Pag>, IDisposable
    {

        private IConnection _connection;

        public Forma_PagDAO(IConnection Connection)
        {
            this._connection = Connection;
        }

        public void Atualizar(Forma_Pag model)//OK
        {
            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "UPDATE FORMA_PAG SET " +
                    "FORMA_PAG_DESCRICAO=@DESCRICAO " +
                    "WHERE FORMA_PAG_ID=@ID";

                cmd.Parameters.Add("@DESCRICAO", SqlDbType.Text).Value =
                    model.FORMA_PAG_DESCRICAO;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value =
                    model.FORMA_PAG_ID;

                cmd.ExecuteNonQuery();
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Forma_Pag Inserir(Forma_Pag model)//OK
        {
            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "INSERT INTO FORMA_PAG (" +
                    "FORMA_PAG_DESCRICAO)" +
                    "VALUES(" +
                    "@DESCRICAO)";

                cmd.Parameters.Add("@DESCRICAO", SqlDbType.Text).Value =
                    model.FORMA_PAG_DESCRICAO;

                cmd.ExecuteNonQuery();
            }

            return model;
        }

        public Collection<Forma_Pag> ListarTudo()//OK
        {
            Collection<Forma_Pag> Formas_Pag = new Collection<Forma_Pag>();

            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "SELECT " +
                    "FORMA_PAG_ID," +
                    "FORMA_PAG_DESCRICAO " +
                    "FROM FORMA_PAG " +
                    "ORDER BY FORMA_PAG_DESCRICAO";

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable tblForma_Pag = new DataTable();
                    adapter.Fill(tblForma_Pag);

                    foreach (DataRow row in tblForma_Pag.Rows)
                    {
                        Forma_Pag forma_pag = new Forma_Pag
                        {                        
                            FORMA_PAG_ID = int.Parse(row["FORMA_PAG_ID"].ToString()),
                            FORMA_PAG_DESCRICAO = row["FORMA_PAG_DESCRICAO"].ToString(),
                        };
                        Formas_Pag.Add(forma_pag);
                    }
                }
            }

            return Formas_Pag;

        }

        public Forma_Pag LocalizarPorCodigo(params object[] keys)//OK
        {
            Forma_Pag forma_Pag = null;

            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "SELECT " +
                    "FORMA_PAG_ID," +
                    "FORMA_PAG_DESCRICAO " +
                    "FROM FORMA_PAG " +
                    "WHERE FORMA_PAG_ID=@ID";

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value =
                    keys[0];

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        forma_Pag = new Forma_Pag();
                        reader.Read();
                        forma_Pag.FORMA_PAG_ID = reader.GetInt32(0);
                        forma_Pag.FORMA_PAG_DESCRICAO = reader.GetString(1);
                    }
                }
            }

            return forma_Pag;
        }

        public Forma_Pag LocalizarPrimeiro()//OK
        {
            Forma_Pag forma_Pag = null;

            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "SELECT " +
                    "TOP 1 " +
                    "FORMA_PAG_ID," +
                    "FORMA_PAG_DESCRICAO " +
                    "FROM FORMA_PAG ";

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        forma_Pag = new Forma_Pag();
                        reader.Read();
                        forma_Pag.FORMA_PAG_ID = reader.GetInt32(0);
                        forma_Pag.FORMA_PAG_DESCRICAO = reader.GetString(1);
                    }
                }
            }

            return forma_Pag;
        }

        public bool Remover(Forma_Pag model)//OK
        {
            bool retornar = false;

            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "DELETE FROM FORMA_PAG WHERE FORMA_PAG_ID=@ID";

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value =
                    model.FORMA_PAG_ID;
                
                if(cmd.ExecuteNonQuery() > 0)
                {
                    retornar = true;
                }                
            }

            return retornar;
        }
    }
}

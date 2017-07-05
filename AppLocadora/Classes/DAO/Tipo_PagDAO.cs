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
    public class Tipo_PagDAO : IDAO<Tipo_Pag>, IDisposable
    {

        private IConnection _connection;

        public Tipo_PagDAO(IConnection Connection)
        {
            this._connection = Connection;
        }

        public void Atualizar(Tipo_Pag model)//OK
        {
            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "UPDATE TIPO_PAG SET " +
                    "TIPO_PAG_DESCRICAO=@DESCRICAO " +
                    "WHERE TIPO_PAG_ID=@ID";

                cmd.Parameters.Add("@DESCRICAO", SqlDbType.Text).Value =
                    model.TIPO_PAG_DESCRICAO;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value =
                    model.TIPO_PAG_ID;

                cmd.ExecuteNonQuery();
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Tipo_Pag Inserir(Tipo_Pag model)//OK
        {
            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "INSERT INTO TIPO_PAG (" +
                    "TIPO_PAG_DESCRICAO)" +
                    "VALUES(" +
                    "@DESCRICAO)";

                cmd.Parameters.Add("@DESCRICAO", SqlDbType.Text).Value = 
                    model.TIPO_PAG_DESCRICAO;

                cmd.ExecuteNonQuery();
            }

            return model;
        }

        public Collection<Tipo_Pag> ListarTudo()//OK
        {
            Collection<Tipo_Pag> Tipos_Pag = new Collection<Tipo_Pag>();

            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "SELECT " +
                    "TIPO_PAG_ID," +
                    "TIPO_PAG_DESCRICAO " +
                    "FROM TIPO_PAG " +
                    "ORDER BY TIPO_PAG_DESCRICAO";

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable tblTipo_Pag = new DataTable();
                    adapter.Fill(tblTipo_Pag);

                    foreach (DataRow row in tblTipo_Pag.Rows)
                    {
                        Tipo_Pag tipo_Pag = new Tipo_Pag
                        {                        
                            TIPO_PAG_ID = int.Parse(row["TIPO_PAG_ID"].ToString()),
                            TIPO_PAG_DESCRICAO = row["TIPO_PAG_DESCRICAO"].ToString(),
                        };

                        Tipos_Pag.Add(tipo_Pag);
                    }
                }
            }

            return Tipos_Pag;
        }

        public Tipo_Pag LocalizarPorCodigo(params object[] keys)//OK
        {
            Tipo_Pag tipo_Pag = null;

            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "SELECT " +
                    "TIPO_PAG_ID," +
                    "TIPO_PAG_DESCRICAO " +
                    "FROM TIPO_PAG " +
                    "WHERE TIPO_PAG_ID=@ID";

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value =
                    keys[0];

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        tipo_Pag = new Tipo_Pag();
                        reader.Read();
                        tipo_Pag.TIPO_PAG_ID = reader.GetInt32(0);
                        tipo_Pag.TIPO_PAG_DESCRICAO = reader.GetString(1);
                    }
                }
            }

            return tipo_Pag;
        }

        public bool Remover(Tipo_Pag model)//OK
        {
            bool retornar = false;

            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "DELETE FROM TIPO_PAG WHERE TIPO_PAG_ID=@ID";

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value =
                    model.TIPO_PAG_ID;
                
                if(cmd.ExecuteNonQuery() > 0)
                {
                    retornar = true;
                }                
            }

            return retornar;
        }
    }
}

using System;
using System.Collections.ObjectModel;
using Classes.Entidades;
using Interfaces.Operation;
using Interfaces.Conexao;
using System.Data.SqlClient;
using System.Data;

namespace Classes.DAO
{
    public class BeneficiarioDAO : IDAO<Beneficiario>, IDisposable
    {

        private IConnection _connection;

        public BeneficiarioDAO(IConnection Connection)
        {
            this._connection = Connection;
        }

        public void Atualizar(Beneficiario model)
        {
            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "UPDATE BENEFICIARIO SET " +
                    "BENEFICIARIO_CNPJCPF=@CNPJCPF," +
                    "BENEFICIARIO_NOMEFAN=@NOMEFAN," +
                    "BENEFICIARIO_RAZAOSOC=@RAZAOSOC " +
                    "WHERE BENEFICIARIO_ID=@ID";

                cmd.Parameters.Add("@CNPJCPF", SqlDbType.Text).Value =
                    model.BENEFICIARIO_CNPJCPF;
                cmd.Parameters.Add("@NOMEFAN", SqlDbType.Text).Value =
                    model.BENEFICIARIO_NOMEFAN;
                cmd.Parameters.Add("@RAZAOSOC", SqlDbType.Text).Value =
                    model.BENEFICIARIO_RAZAOSOC;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value =
                    model.BENEFICIARIO_ID;

                cmd.ExecuteNonQuery();
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Beneficiario Inserir(Beneficiario model)
        {
            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "INSERT INTO BENEFICIARIO (" +
                    "BENEFICIARIO_CNPJCPF," +
                    "BENEFICIARIO_NOMEFAN," +
                    "BENEFICIARIO_RAZAOSOC)" +
                    "VALUES(" +
                    "@CNPJCPF," +
                    "@NOMEFAN," +
                    "@RAZAOSOC)";

                cmd.Parameters.Add("@CNPJCPF", SqlDbType.Text).Value = 
                    model.BENEFICIARIO_CNPJCPF;
                cmd.Parameters.Add("@NOMEFAN", SqlDbType.Text).Value =
                    model.BENEFICIARIO_NOMEFAN;
                cmd.Parameters.Add("@RAZAOSOC", SqlDbType.Text).Value =
                    model.BENEFICIARIO_RAZAOSOC;

                cmd.ExecuteNonQuery();
            }

            return model;
        }

        public Collection<Beneficiario> ListarTudo()
        {
            Collection<Beneficiario> Beneficiarios = new Collection<Beneficiario>();

            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "SELECT " +
                    "BENEFICIARIO_ID," +
                    "BENEFICIARIO_CNPJCPF," +
                    "BENEFICIARIO_NOMEFAN," +
                    "BENEFICIARIO_RAZAOSOC " +
                    "FROM BENEFICIARIO " +
                    "ORDER BY BENEFICIARIO_NOMEFAN";

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable tblBeneficiario = new DataTable();
                    adapter.Fill(tblBeneficiario);

                    foreach (DataRow row in tblBeneficiario.Rows)
                    {
                        Beneficiario beneficiario = new Beneficiario {                        
                            BENEFICIARIO_ID = int.Parse(row["BENEFICIARIO_ID"].ToString()),
                            BENEFICIARIO_CNPJCPF = row["BENEFICIARIO_CNPJCPF"].ToString(),
                            BENEFICIARIO_NOMEFAN = row["BENEFICIARIO_NOMEFAN"].ToString(),
                            BENEFICIARIO_RAZAOSOC = row["BENEFICIARIO_RAZAOSOC"].ToString()
                        };
                        Beneficiarios.Add(beneficiario);
                    }
                }
            }

            return Beneficiarios;

        }

        public Beneficiario LocalizarPorCodigo(params object[] keys)
        {
            Beneficiario beneficiario = null;

            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "SELECT " +
                    "BENEFICIARIO_ID," +
                    "BENEFICIARIO_CNPJCPF," +
                    "BENEFICIARIO_NOMEFAN," +
                    "BENEFICIARIO_RAZAOSOC " +
                    "FROM BENEFICIARIO " +
                    "WHERE BENEFICIARIO_ID=@ID";

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value =
                    keys[0];

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        beneficiario = new Beneficiario();
                        reader.Read();
                        beneficiario.BENEFICIARIO_ID = reader.GetInt32(0);
                        beneficiario.BENEFICIARIO_CNPJCPF = reader.GetString(1);
                        beneficiario.BENEFICIARIO_NOMEFAN = reader.GetString(2);
                        beneficiario.BENEFICIARIO_RAZAOSOC = reader.GetString(3);
                    }
                }
            }

            return beneficiario;
        }

        public Beneficiario LocalizarPrimeiro()
        {
            Beneficiario beneficiario = null;

            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "SELECT " +
                    "TOP 1 " +
                    "BENEFICIARIO_ID," +
                    "BENEFICIARIO_CNPJCPF," +
                    "BENEFICIARIO_NOMEFAN," +
                    "BENEFICIARIO_RAZAOSOC " +
                    "FROM BENEFICIARIO";

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        beneficiario = new Beneficiario();
                        reader.Read();
                        beneficiario.BENEFICIARIO_ID = reader.GetInt32(0);
                        beneficiario.BENEFICIARIO_CNPJCPF = reader.GetString(1);
                        beneficiario.BENEFICIARIO_NOMEFAN = reader.GetString(2);
                        beneficiario.BENEFICIARIO_RAZAOSOC = reader.GetString(3);
                    }
                }
            }

            return beneficiario;
        }

        public bool Remover(Beneficiario model)
        {
            bool retornar = false;

            using (SqlCommand cmd = _connection.Buscar().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                    "DELETE FROM BENEFICIARIO WHERE BENEFICIARIO_ID=@ID";

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value =
                    model.BENEFICIARIO_ID;
                
                if(cmd.ExecuteNonQuery() > 0)
                {
                    retornar = true;
                }                
            }

            return retornar;
        }
    }
}

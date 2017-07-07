using System;
using System.Data.SqlClient;
using Interfaces.Conexao;
using System.Data;

namespace Classes.Conexao
{
    public class Connection : IConnection, IDisposable
    {
        private SqlConnection _connection;

        public Connection()
        {
            _connection = new SqlConnection(
                "Data Source = TI, 1433; " +
                "Initial Catalog = GRFINANCEIRO;" +
                "Integrated Security = True");
        }

        public SqlConnection Abrir()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }

            return _connection;
        }

        public SqlConnection Buscar()
        {
            return this.Abrir();
        }

        public void Dispose()
        {
            this.Fechar();
            GC.SuppressFinalize(this);
        }

        public void Fechar()
        {
            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }
    }
}

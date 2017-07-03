﻿using System;
using System.Data.SqlClient;

namespace Interfaces.Conexao
{
    public interface IConnection: IDisposable
    {
        //Abrir conexão
        SqlConnection Abrir();
        //Quando aberta a busca não abrirá mais a conexão
        SqlConnection Buscar();
        //Fechar a conexão
        void Fechar();
    }
}

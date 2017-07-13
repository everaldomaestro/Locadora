using System;
using System.Collections.ObjectModel;

namespace Interfaces.Operation
{
    //Interface tipada, podendo usar qualquer tipo de entidade
    public interface IDAO<T>:IDisposable where T: class, new()
    {
        //Insert
        T Inserir(T model);
        //Update
        void Atualizar(T model);
        //Delete
        bool Remover(T model);
        //Select All
        Collection<T> ListarTudo();
        //Select por ID
        T LocalizarPorCodigo(params Object[] keys);
        //Selecionar o primeiro objeto
        T LocalizarPrimeiro();
    }
}

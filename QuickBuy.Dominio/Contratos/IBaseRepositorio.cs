using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Contratos
{
    public interface IBaseRepositorio<TEntity> : IDisposable  where TEntity : class
    {
        void Adicionar(int id);

        TEntity ObterPorID(int id);

        IEnumerable<TEntity> ObterTodos();

        void Atualizar(TEntity entity);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AracKiralama.Interfaces
{
    public interface IGenelService<T> : IDisposable
    {
        T Add(T entity);
        T Update(T entity);
        T Get(int id);

        List<T> GetAll();
        bool Delete(int id);
        bool Delete(T entity);

    }

}

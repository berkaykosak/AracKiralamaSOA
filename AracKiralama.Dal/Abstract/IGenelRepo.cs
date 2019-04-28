using System;
using System.Collections.Generic;
using System.Text;

namespace AracKiralama.DAL.Abstract
{
   public interface IGenelRepo<T>: IDisposable where T : class
    {
        T Add(T entity);
        T Update(T entity);
        T Get(int id);
        List<T> GetAll();
        bool Delete(int id);
        bool Delete(T entity);
        new void Dispose();
    }
}

using AracKiralama.DAL.Abstract;
using AracKiralama.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AracKiralama.Bll
{
    public class GenelManager<T> : IGenelService<T> where T : class
    {
        private readonly IGenelRepo<T> genelRepo;

        protected GenelManager(IGenelRepo<T> _genelRepo)
        {
            genelRepo = _genelRepo;
        }
        public T Add(T entity)
        {
            return genelRepo.Add(entity);
        }

        public bool Delete(int id)
        {
            return genelRepo.Delete(id);
        }

        public bool Delete(T entity)
        {
            return genelRepo.Delete(entity);
        }

        public void Dispose()
        {   
            //Çöp verileri temizlemek ve uzaklaştırmak için yazdığımız kodlar
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        //iplemente sorununu çözmek için yazdığımız protected kod parçası
        protected virtual void Dispose(bool disposeIslemi)
        {
            if (disposeIslemi)
            {
                genelRepo.Dispose();
            }
        }

        public T Get(int id)
        {
            return genelRepo.Get(id);
        }

        public List<T> GetAll()
        {
            return genelRepo.GetAll();
        }

        public T Update(T entity)
        {
            return genelRepo.Update(entity);
        }
    }
}

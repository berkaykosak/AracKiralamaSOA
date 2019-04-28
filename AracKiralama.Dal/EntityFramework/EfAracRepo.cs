using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracKiralama.Dal.Concrete.EntityFramework.Repository;
using AracKiralama.DAL.Abstract;
using AracKiralama.DAL.EntityFramework;
using AracKiralama.Entities;
namespace AracKiralama.DAL.EntityFramework
{
    //BURADAKİ NEW LER HATAYI ÇÖZMEK İÇİN GİZLEMEK İSTİYORSANIZ DİYİP HATA VERİYORDU SORUN ÇIKARSA NEW YAZILARINI FONKSİYON TANIMLARINDAN SİL....
    public class EfAracRepo : EfGenelRepo<Arac>, IAracRepo
    {
        public new Arac Add(Arac entity)
        {
            throw new NotImplementedException();
        }

        public new bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public new bool Delete(Arac entity)
        {
            throw new NotImplementedException();
        }

        public new void Dispose()
        {
            throw new NotImplementedException();
        }

        public new Arac Get(int id)
        {
            throw new NotImplementedException();
        }

        public new List<Arac> GetAll()
        {
            throw new NotImplementedException();
        }

        public new Arac Update(Arac entity)
        {
            throw new NotImplementedException();
        }
    }
}

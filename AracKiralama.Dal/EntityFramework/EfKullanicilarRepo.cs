using AracKiralama.Dal.Concrete.EntityFramework.Repository;
using AracKiralama.DAL.Abstract;
using AracKiralama.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AracKiralama.DAL.EntityFramework
{
    class EfKullanicilarRepo : EfGenelRepo<Kullanicilar>, IKullanicilarRepo
    {
        public EfKullanicilarRepo()
        {
            context = new AracKiralamaSoaContext();
        }
        public Kullanicilar LoginUser(string eposta, string sifre)
        {
            return context.Kullanici.FirstOrDefault(x => x.email == eposta && x.sifre == sifre);

        }
    }
}

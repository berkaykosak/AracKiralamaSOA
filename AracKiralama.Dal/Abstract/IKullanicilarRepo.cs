using AracKiralama.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AracKiralama.DAL.Abstract
{
    public interface IKullanicilarRepo:IGenelRepo<Kullanicilar>
    {
        Kullanicilar LoginUser(string eposta, string sifre);

    }
}

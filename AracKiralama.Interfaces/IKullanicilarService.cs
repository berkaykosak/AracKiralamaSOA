using AracKiralama.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AracKiralama.Interfaces
{
    public interface IKullanicilarService:IGenelService <Kullanicilar>
    {
        Kullanicilar LoginUser(string eposta, string sifre);
    }
}

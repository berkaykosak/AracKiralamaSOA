using AracKiralama.DAL.Abstract;
using AracKiralama.Entities;
using AracKiralama.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AracKiralama.Bll
{
    public class KullanicilarManager : GenelManager<Kullanicilar>, IKullanicilarService
    {
        private IKullanicilarRepo kullanicilarRepo;

        //Her manager sınıfında yaptığımız gibi bu sınıf içinde de ilgili interface repository sınıfını import ettik ve gerekli uygulamaları sağladık.
        //Oluşturduğum constructor ile de veri bağımlılığı sağlamış olduk.
        public KullanicilarManager(IKullanicilarRepo _kullanicilarRepo):base(_kullanicilarRepo)
        {
            kullanicilarRepo = _kullanicilarRepo;
        }



        public Kullanicilar LoginUser(string eposta, string sifre)
        {
            try
            {
                if (string.IsNullOrEmpty(eposta.Trim()) || string.IsNullOrEmpty(sifre.Trim()))
                {
                    throw new Exception("Email or Password is not null.");
                }
                var kullanicilar = kullanicilarRepo.LoginUser(eposta, sifre);
                if (kullanicilar == null)
                {
                    throw new Exception("ID or Password failed");
                }
                else
                {
                    return kullanicilar;
                }
            }
            catch (Exception e)
            {
                throw new Exception("User Login Fail" + e.Message);
            }

        }


    }
}
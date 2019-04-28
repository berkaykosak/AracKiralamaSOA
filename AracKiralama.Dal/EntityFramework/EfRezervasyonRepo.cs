using AracKiralama.Dal.Concrete.EntityFramework.Repository;
using AracKiralama.DAL.Abstract;
using AracKiralama.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AracKiralama.DAL.EntityFramework
{
    public class EfRezervasyonRepo:EfGenelRepo<Rezervasyon>,IRezervasyonRepo
    {
    }
}

using AracKiralama.DAL.Abstract;
using AracKiralama.Entities;
using AracKiralama.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AracKiralama.Bll
{
    public class RezervasyonManager : GenelManager<Rezervasyon>, IRezervasyonService
    {
        private IRezervasyonRepo rezRepo;

        public RezervasyonManager(IRezervasyonRepo _rezRepo) : base(_rezRepo)
        {
            rezRepo = _rezRepo;
        }
    }
}

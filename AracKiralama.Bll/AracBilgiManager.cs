using AracKiralama.DAL.Abstract;
using AracKiralama.Entities;
using AracKiralama.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AracKiralama.Bll
{
    public class AracBilgiManager : GenelManager<Arac>, IAracBilgiService
    {
        private IAracRepo aracBilgiRepo;

        public AracBilgiManager(IAracRepo _aracBilgiRepo):base (_aracBilgiRepo)
        {
            this.aracBilgiRepo = _aracBilgiRepo;
        }

    }
}

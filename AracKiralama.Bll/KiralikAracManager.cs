using AracKiralama.DAL.Abstract;
using AracKiralama.Entities;
using AracKiralama.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AracKiralama.Bll
{
    public class KiralikAracManager:GenelManager<KiralikArac>,IKiralikAracService
    {
        private IKiralikAracRepo kiralikAracRepo;

        public KiralikAracManager(IKiralikAracRepo _kiralikAracRepo): base(_kiralikAracRepo)
        {
            kiralikAracRepo = _kiralikAracRepo;
        }
    }
}

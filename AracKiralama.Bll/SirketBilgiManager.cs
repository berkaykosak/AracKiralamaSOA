using AracKiralama.DAL.Abstract;
using AracKiralama.Entities;
using AracKiralama.Interfaces;

namespace AracKiralama.Bll
{
    public class SirketManager : GenelManager<SirketBilgi>, ISirketBilgiService
    {
        private ISirketRepo sirketRepository;

        public SirketManager(ISirketRepo _sirketRepo) : base(_sirketRepo)
        {
            sirketRepository = _sirketRepo;
        }




    }
}

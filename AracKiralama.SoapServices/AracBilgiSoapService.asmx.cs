using AracKiralama.Bll;
using AracKiralama.DAL.EntityFramework;
using AracKiralama.Entities;
using AracKiralama.Transfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AracKiralama.SoapServices
{
    /// <summary>
    /// AracBilgiSoapService için özet açıklama
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Bu Web Hizmeti'nin, ASP.NET AJAX kullanılarak komut dosyasından çağrılmasına, aşağıdaki satırı açıklamadan kaldırmasına olanak vermek için.
    // [System.Web.Script.Services.ScriptService]
    public class AracBilgiSoapService : System.Web.Services.WebService
    {

        AracBilgiManager aracManager = new AracBilgiManager(new EfAracRepo());
        [WebMethod]
        public void Add(AracTransfer nesne)
        {
            aracManager.Add(new Arac
            {
                aracID = nesne.aracID,
                aracMarka = nesne.aracMarka,
                airbag = nesne.airbag,
                bagajHacmi = nesne.bagajHacmi,
                gunlukKiralikFiyat = nesne.gunlukKiralikFiyat,
                gunlukKmSinir = nesne.gunlukKmSinir,
                gerekenEhliyetYasi = nesne.gerekenEhliyetYasi,
                anlikKm= nesne.anlikKm,
                koltukSayisi = nesne.koltukSayisi,
                minimumYas = nesne.minimumYas
            });
        }
        [WebMethod]
        public bool Delete(int id)
        {
            return aracManager.Delete(id);
        }


        [WebMethod]
        public AracTransfer Get(int id)
        {

            var nesne1 = aracManager.Get(id);
            return new AracTransfer
            {
                aracID = nesne1.aracID,
                aracMarka = nesne1.aracMarka,
                airbag = nesne1.airbag,
                bagajHacmi = nesne1.bagajHacmi,
                gunlukKiralikFiyat = nesne1.gunlukKiralikFiyat,
                gunlukKmSinir = nesne1.gunlukKmSinir,
                gerekenEhliyetYasi = nesne1.gerekenEhliyetYasi,
                anlikKm = nesne1.anlikKm,
                koltukSayisi = nesne1.koltukSayisi,
                minimumYas = nesne1.minimumYas
            };
        }
        [WebMethod]
        public List<AracTransfer> GetAll()
        {
            return aracManager.GetAll().Select(nesne2 => new AracTransfer
            {
                aracID = nesne2.aracID,
                aracMarka = nesne2.aracMarka,
                airbag = nesne2.airbag,
                bagajHacmi = nesne2.bagajHacmi,
                gunlukKiralikFiyat = nesne2.gunlukKiralikFiyat,
                gunlukKmSinir = nesne2.gunlukKmSinir,
                gerekenEhliyetYasi = nesne2.gerekenEhliyetYasi,
                anlikKm = nesne2.anlikKm,
                koltukSayisi = nesne2.koltukSayisi,
                minimumYas = nesne2.minimumYas

            }).ToList();
        }
        [WebMethod]
        public void Update(AracTransfer nesne3)
        {
            aracManager.Update(new Arac
            {
                aracID = nesne3.aracID,
                aracMarka = nesne3.aracMarka,
                airbag = nesne3.airbag,
                bagajHacmi = nesne3.bagajHacmi,
                gunlukKiralikFiyat = nesne3.gunlukKiralikFiyat,
                gunlukKmSinir = nesne3.gunlukKmSinir,
                gerekenEhliyetYasi = nesne3.gerekenEhliyetYasi,
                anlikKm = nesne3.anlikKm,
                koltukSayisi = nesne3.koltukSayisi,
                minimumYas = nesne3.minimumYas
            });
        }
    }
}
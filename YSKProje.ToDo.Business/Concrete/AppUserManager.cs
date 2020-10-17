using Microsoft.EntityFrameworkCore.Update;
using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.Business.Interfaces;
using YSKProje.ToDo.DataAccess.Interfaces;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.Business.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _appUserDal;
        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public List<AppUser> GetirAdminOlmayanlar()
        {
            return _appUserDal.GetirAdminOlmayanlar();
        }

        public List<AppUser> GetirAdminOlmayanlar(out int toplamSayfa, string aranacakKelime, int aktifSayfa)
        {
            return _appUserDal.GetirAdminOlmayanlar(out toplamSayfa, aranacakKelime, aktifSayfa);
        }

        public List<DualHelper> GetirEnCokGorevdeCalisanPersoneller()
        {
            return _appUserDal.GetirEnCokGorevdeCalisanPersoneller();
        }

        public List<DualHelper> GetirEnCokGorevTamamlamisPersonel()
        {
            return _appUserDal.GetirEnCokGorevTamamlamisPersonel();
        }
    }
}

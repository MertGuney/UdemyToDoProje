using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using YSKProje.ToDo.Business.Interfaces;
using YSKProje.ToDo.Entities.Concrete;
using YSKProje.ToDo.Web.BaseControllers;
using YSKProje.ToDo.Web.StringInfo;

namespace YSKProje.ToDo.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = RoleInfo.Admin)]
    [Area(AreaInfo.Admin)]
    public class HomeController : BaseIdentityController
    {
        private readonly IGorevService _gorevService;
        private readonly IBildirimService _bildirimService;
        private readonly IRaporService _raporService;
        public HomeController(IGorevService gorevService, IBildirimService bildirimService, UserManager<AppUser> userManager, IRaporService raporService) : base(userManager)
        {
            _gorevService = gorevService;
            _bildirimService = bildirimService;
            _raporService = raporService;
        }
        public async Task<IActionResult> Index()
        {
            var user = await GetirGirisYapanKullanici();
            TempData["Active"] = TempDataInfo.Anasayfa;
            ViewBag.AtanmayiBekleyenGorevSayisi = _gorevService.GetirAtanmayiBekleyenGorevSayisi();
            ViewBag.TamamlanmisGorevSayisi = _gorevService.GetirTamamlanmisGorevSayisi();
            ViewBag.OkunmamisBildirimSayisi = _bildirimService.GetirOkunmayanBildirimIleAppUserId(user.Id);
            ViewBag.ToplamRaporSayisi = _raporService.GetirRaporSayisi();
            return View();
        }
    }
}
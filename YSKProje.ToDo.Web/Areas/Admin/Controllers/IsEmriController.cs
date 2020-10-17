using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using YSKProje.ToDo.Business.Interfaces;
using YSKProje.ToDo.DTO.DTOs.AppUserDtos;
using YSKProje.ToDo.DTO.DTOs.GorevDtos;
using YSKProje.ToDo.DTO.DTOs.RaporDtos;
using YSKProje.ToDo.Entities.Concrete;
using YSKProje.ToDo.Web.BaseControllers;
using YSKProje.ToDo.Web.StringInfo;

namespace YSKProje.ToDo.Web.Areas.Admin.Controllers
{
    [Area(AreaInfo.Admin)]
    [Authorize(Roles = RoleInfo.Admin)]
    public class IsEmriController : BaseIdentityController
    {
        private readonly IAppUserService _appUserService;
        private readonly IGorevService _gorevService;
        private readonly IDosyaService _dosyaService;
        private readonly IBildirimService _bildirimService;
        private readonly IMapper _mapper;

        public IsEmriController(IAppUserService appUserService, IGorevService gorevService, UserManager<AppUser> userManager, IDosyaService dosyaService, IBildirimService bildirimService, IMapper mapper) : base(userManager)
        {
            _appUserService = appUserService;
            _gorevService = gorevService;
            _dosyaService = dosyaService;
            _bildirimService = bildirimService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            TempData["Active"] = TempDataInfo.IsEmri;
            var model = _mapper.Map<List<GorevListAllDto>>(_gorevService.GetirTumTablolarla());
            return View(model);
        }
        public IActionResult AtaPersonel(int id, string s, int sayfa = 1)
        {
            TempData["Active"] = TempDataInfo.IsEmri;

            ViewBag.AktifSayfa = sayfa;

            ViewBag.Aranan = s;
            //ViewBag.ToplamSayfa = (int)Math.Ceiling((double)_appUserService.GetirAdminOlmayanlar().Count/3);
            var personeller = _mapper.Map<List<AppUserListDto>>(_appUserService.GetirAdminOlmayanlar(out int toplamSayfa, s, sayfa));
            ViewBag.ToplamSayfa = toplamSayfa;
            ViewBag.Personeller = personeller;

            var gorev = _mapper.Map<GorevListDto>(_gorevService.GetirAciliyetileId(id));

            return View(gorev);
        }
        [HttpPost]
        public IActionResult AtaPersonel(PersonelGorevlendirDto model)
        {
            var guncellenceGorev = _gorevService.GetirIdile(model.GorevId);
            guncellenceGorev.AppUserId = model.PersonelId;
            _gorevService.Guncelle(guncellenceGorev);
            _bildirimService.Kaydet(new Bildirim
            {
                AppUserId = model.PersonelId,
                Aciklama = $"{guncellenceGorev.Ad} adlı iş için görevlendirildiniz."
            });
            return RedirectToAction("Index");
        }
        public IActionResult GorevlendirPersonel(PersonelGorevlendirDto model)
        {
            TempData["Active"] = TempDataInfo.IsEmri;

            var user = _mapper.Map<AppUserListDto>(_userManager.Users.FirstOrDefault(I => I.Id == model.PersonelId));
            var gorev = _mapper.Map<GorevListDto>(_gorevService.GetirAciliyetileId(model.GorevId));

            PersonelGorevlendirListDto personelGorevlendirModel = new PersonelGorevlendirListDto
            {
                AppUser = user,
                Gorev = gorev
            };

            return View(personelGorevlendirModel);
        }
        public IActionResult Detaylandır(int id)
        {
            TempData["Active"] = TempDataInfo.IsEmri;
            var model = _mapper.Map<GorevListAllDto>(_gorevService.GetirRaporlarileId(id));
            return View(model);
        }

        public IActionResult GetirExcel(int id)
        {
            var excel = _mapper.Map<List<RaporDosyaDto>>(_gorevService.GetirRaporlarileId(id).Raporlar);
            return File(_dosyaService.AktarExcel(excel), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", Guid.NewGuid() + ".xlsx");
        }
        public IActionResult GetirPdf(int id)
        {
            var pdf = _mapper.Map<List<RaporDosyaDto>>(_gorevService.GetirRaporlarileId(id).Raporlar);
            var path = _dosyaService.AktarPdf(pdf);
            return File(path, "application/pdf", Guid.NewGuid() + ".pdf");
        }
    }
}

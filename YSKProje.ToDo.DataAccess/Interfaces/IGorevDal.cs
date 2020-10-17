﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.DataAccess.Interfaces
{
    public interface IGorevDal : IGenericDal<Gorev>
    {
        List<Gorev> GetirAciliyetIleTamamlanmayan();
        List<Gorev> GetirTumTablolarla();
        List<Gorev> GetirTumTablolarla(Expression<Func<Gorev, bool>> filter);
        List<Gorev> GetirTumTablolarlaTamamlanmayan(out int toplamSayfa, int userId, int aktifSayfa);

        Gorev GetirAciliyetileId(int id);
        List<Gorev> GetirileAppUserId(int appUserID);
        Gorev GetirRaporlarileId(int id);
        int GetirGorevSayisiIleAppUserId(int id);
        int GetirGorevSayisiTamamlanmasiGerekenIleAppUserId(int id);
        int GetirAtanmayiBekleyenGorevSayisi();
        int GetirTamamlanmisGorevSayisi();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YSKProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using YSKProje.ToDo.DataAccess.Interfaces;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EFBildirimRepository : EfGenericRepository<Bildirim>, IBildirimDal
    {
        public int GetirOkunmayanBildirimIleAppUserId(int AppUserId)
        {
            using var context = new TodoContext();
            return context.Bildirimler.Count(I => I.AppUserId == AppUserId && !I.Durum);
        }

        public List<Bildirim> GetirOkunmayanlar(int AppUserId)
        {
            using var context = new TodoContext();
            return context.Bildirimler.Where(I => I.AppUserId == AppUserId && !I.Durum).ToList();
        }
    }
}

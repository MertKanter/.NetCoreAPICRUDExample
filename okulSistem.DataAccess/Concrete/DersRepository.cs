using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using okulSistem.DataAccess.Abstract;
using okulSistem.Entities;

namespace okulSistem.DataAccess.Concrete
{
    public class DersRepository:IDersRepository
    {
        public List<Ders> GetAllDers()
        {
            using (var okulSistemDbContext = new OkulSistemDbContext())
            {
                return okulSistemDbContext.Dersler.ToList();
            }
        }

        public Ders GetDersId(int id)
        {
            using (var okulSistemDbContext = new OkulSistemDbContext())
            {
                return okulSistemDbContext.Dersler.Find(id);
            }
        }

        public Ders CreateDers(Ders ders)
        {
            using (var okulSistemDbContext = new OkulSistemDbContext())
            {
                okulSistemDbContext.Dersler.Add(ders);
                okulSistemDbContext.SaveChanges();
                return ders;
            }
        }

        public Ders UpdateDers(Ders ders)
        {
            using (var okulSistemDbContext = new OkulSistemDbContext())
            {
                okulSistemDbContext.Dersler.Update(ders);
                okulSistemDbContext.SaveChanges();
                return ders;
            }
        }

        public void DeleteDers(int id)
        {
            using (var okulSistemDbContext = new OkulSistemDbContext())
            {
                var deletedDers = GetDersId(id);
                okulSistemDbContext.Dersler.Remove(deletedDers);
                okulSistemDbContext.SaveChanges();
            }
        }
    }
}

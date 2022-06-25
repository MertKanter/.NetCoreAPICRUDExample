using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using okulSistem.DataAccess.Abstract;
using okulSistem.Entities;

namespace okulSistem.DataAccess.Concrete
{
    public class OgrenciRepository:IOgrenciRepository
    {
        public List<Ogrenci> GetAllOgrenci()
        {
            using (var okulSistemdbContext = new OkulSistemDbContext())
            {
                return okulSistemdbContext.Ogrenciler.ToList();
            }
        }

        public Ogrenci GetOgrenciId(int id)
        {
            using (var okulSistemdbContext = new OkulSistemDbContext())
            {
                return okulSistemdbContext.Ogrenciler.Find(id);
            }
        }

        public Ogrenci CreateOgrenci(Ogrenci ogrenci)
        {
            using (var okulSistemdbContext = new OkulSistemDbContext())
            {
                okulSistemdbContext.Ogrenciler.Add(ogrenci);
                okulSistemdbContext.SaveChanges();
                return ogrenci;
            }
        }

        public Ogrenci UpdateOgrenci(Ogrenci ogrenci)
        {
            using (var okulSistemdbContext = new OkulSistemDbContext())
            {
                okulSistemdbContext.Ogrenciler.Update(ogrenci);
                okulSistemdbContext.SaveChanges();
                return ogrenci;
            }
        }

        public void DeleteOgrenci(int id)
        {
            using (var okulSistemdbContext = new OkulSistemDbContext())
            {
                var deletedOgrenci = GetOgrenciId(id);
                okulSistemdbContext.Ogrenciler.Remove(deletedOgrenci);
                okulSistemdbContext.SaveChanges();
            }
        }
    }
}

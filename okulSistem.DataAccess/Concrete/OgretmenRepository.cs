using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using okulSistem.DataAccess.Abstract;
using okulSistem.Entities;

namespace okulSistem.DataAccess.Concrete
{
    public class OgretmenRepository:IOgretmenRepository
    {
        public List<Ogretmen> GetAllOgretmen()
        {
            using (var okulSistemdbContext = new OkulSistemDbContext())
            {
                return okulSistemdbContext.Ogretmenler.ToList();
            }
        }

        public Ogretmen GetOgretmenId(int id)
        {
            using (var okulSistemdbContext = new OkulSistemDbContext())
            {
                return okulSistemdbContext.Ogretmenler.Find(id);
            }
        }

        public Ogretmen CreateOgretmen(Ogretmen ogretmen)
        {
            using (var okulSistemdbContext = new OkulSistemDbContext())
            {
                okulSistemdbContext.Ogretmenler.Add(ogretmen);
                okulSistemdbContext.SaveChanges();
                return ogretmen;
            }
        }

        public Ogretmen UpdateOgretmen(Ogretmen ogretmen)
        {
            using (var okulSistemdbContext = new OkulSistemDbContext())
            {
                okulSistemdbContext.Ogretmenler.Update(ogretmen);
                okulSistemdbContext.SaveChanges();
                return ogretmen;
            }
        }

        public void DeleteOgretmen(int id)
        {
            using (var okulSistemdbContext = new OkulSistemDbContext())
            {
                var deletedOgretmen = GetOgretmenId(id);
                okulSistemdbContext.Ogretmenler.Remove(deletedOgretmen);
                okulSistemdbContext.SaveChanges();
            }
        }
    }
}

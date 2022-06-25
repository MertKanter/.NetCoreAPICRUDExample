using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using okulSistem.Entities;

namespace okulSistem.DataAccess.Abstract
{
    public interface IOgretmenRepository
    {
        List<Ogretmen> GetAllOgretmen();

        Ogretmen GetOgretmenId(int id);

        Ogretmen CreateOgretmen(Ogretmen ogretmen);

        Ogretmen UpdateOgretmen(Ogretmen ogretmen);

        void DeleteOgretmen(int id);
    }
}

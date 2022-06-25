using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using okulSistem.Entities;

namespace okulSistem.DataAccess.Abstract
{
    public interface IDersRepository
    {
        List<Ders> GetAllDers();

        Ders GetDersId(int id);

        Ders CreateDers(Ders ders);

        Ders UpdateDers(Ders ders);

        void DeleteDers(int id);
    }
}

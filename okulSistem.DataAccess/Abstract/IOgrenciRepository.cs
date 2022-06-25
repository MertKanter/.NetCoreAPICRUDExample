using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using okulSistem.Entities;

namespace okulSistem.DataAccess.Abstract
{
    public interface IOgrenciRepository
    {
        List<Ogrenci> GetAllOgrenci();

        Ogrenci GetOgrenciId(int id);

        Ogrenci CreateOgrenci(Ogrenci ogrenci);

        Ogrenci UpdateOgrenci(Ogrenci ogrenci);

        void DeleteOgrenci(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using okulSistem.Business.Abstract;
using okulSistem.DataAccess.Abstract;
using okulSistem.DataAccess.Concrete;
using okulSistem.Entities;

namespace okulSistem.Business.Concrete
{
    public class OgrenciManager:IOgrenciService
    {
        private IOgrenciRepository _ogrenciRepository;

        public OgrenciManager()
        {
            _ogrenciRepository = new OgrenciRepository();
        }
        public List<Ogrenci> GetAllOgrenci()
        {
            return _ogrenciRepository.GetAllOgrenci();
        }

        public Ogrenci GetOgrenciId(int id)
        {
            return _ogrenciRepository.GetOgrenciId(id);
        }

        public Ogrenci CreateOgrenci(Ogrenci ogrenci)
        {
            return _ogrenciRepository.CreateOgrenci(ogrenci);
        }

        public Ogrenci UpdateOgrenci(Ogrenci ogrenci)
        {
            return _ogrenciRepository.UpdateOgrenci(ogrenci);
        }

        public void DeleteOgrenci(int id)
        {
            _ogrenciRepository.DeleteOgrenci(id);
        }
    }
}

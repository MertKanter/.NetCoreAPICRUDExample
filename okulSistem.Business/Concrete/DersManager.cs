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
    public class DersManager:IDersService
    {
        private IDersRepository _dersRepository;

        public DersManager()
        {
            _dersRepository = new DersRepository();
        }
        public List<Ders> GetAllDers()
        {
            return _dersRepository.GetAllDers();
        }

        public Ders GetDersId(int id)
        {
            return _dersRepository.GetDersId(id);
        }

        public Ders CreateDers(Ders ders)
        {
           return _dersRepository.CreateDers(ders);
        }

        public Ders UpdateDers(Ders ders)
        {
            return _dersRepository.UpdateDers(ders);
        }

        public void DeleteDers(int id)
        {
            _dersRepository.DeleteDers(id);
        }
    }
}

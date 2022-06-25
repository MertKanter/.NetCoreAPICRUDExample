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
    public class OgretmenManager:IOgretmenService
    {
        private IOgretmenRepository _ogretmenRepository;
        public OgretmenManager()
        {
            _ogretmenRepository = new OgretmenRepository();
        }
        public List<Ogretmen> GetAllOgretmen()
        {
           return _ogretmenRepository.GetAllOgretmen();
        }

        public Ogretmen GetOgretmenId(int id)
        {
           return _ogretmenRepository.GetOgretmenId(id);
        }

        public Ogretmen CreateOgretmen(Ogretmen ogretmen)
        {
            return _ogretmenRepository.CreateOgretmen(ogretmen);
        }

        public Ogretmen UpdateOgretmen(Ogretmen ogretmen)
        {
            return _ogretmenRepository.UpdateOgretmen(ogretmen);
        }

        public void DeleteOgretmen(int id)
        {
            _ogretmenRepository.DeleteOgretmen(id);
        }
    }
}

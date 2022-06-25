using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using okulSistem.Business.Abstract;
using okulSistem.Business.Concrete;
using okulSistem.Entities;

namespace okulSistem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OgrenciController : ControllerBase
    {
        private IOgrenciService _ogrenciService;

        public OgrenciController()
        {
            _ogrenciService = new OgrenciManager();
        }
        [HttpGet]
        public List<Ogrenci> Get()
        {
            return _ogrenciService.GetAllOgrenci();
        }
        [HttpGet("{id}")]
        public Ogrenci Get(int id)
        {
            return _ogrenciService.GetOgrenciId(id);
        }

        [HttpPost]
        public Ogrenci Post([FromBody] Ogrenci ogrenci)
        {
            return _ogrenciService.CreateOgrenci(ogrenci);
        }
        [HttpPut]
        public Ogrenci Put([FromBody] Ogrenci ogrenci)
        {
            return _ogrenciService.UpdateOgrenci(ogrenci);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _ogrenciService.DeleteOgrenci(id);
        }
    }
}

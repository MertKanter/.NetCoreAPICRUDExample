using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using okulSistem.Business.Abstract;
using okulSistem.Business.Concrete;
using okulSistem.Entities;

namespace okulSistem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DersController : ControllerBase
    {
        private IDersService _dersService;

        public DersController()
        {
            _dersService = new DersManager();
        }

        [HttpGet]
        public List<Ders> Get()
        {
            return _dersService.GetAllDers();
        }
        [HttpGet("{id}")]
        public Ders Get(int id)
        {
            return _dersService.GetDersId(id);
        }

        [HttpPost]
        public Ders Post([FromBody] Ders ders)
        {
            return _dersService.CreateDers(ders);
        }
        [HttpPut]
        public Ders Put([FromBody] Ders ders)
        {
            return _dersService.UpdateDers(ders);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _dersService.DeleteDers(id);
        }

    }
}

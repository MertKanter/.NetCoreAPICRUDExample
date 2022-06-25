using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using okulSistem.Business.Abstract;
using okulSistem.Business.Concrete;
using okulSistem.Entities;

namespace okulSistem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OgretmenController : ControllerBase
    {
        private IOgretmenService _ogretmenService;

        public OgretmenController()
        {
            _ogretmenService = new OgretmenManager();
        }
        [HttpGet]
        public List<Ogretmen> Get()
        {
            return _ogretmenService.GetAllOgretmen();
        }
        [HttpGet("{id}")]
        public Ogretmen Get(int id)
        {
            return _ogretmenService.GetOgretmenId(id);
        }

        [HttpPost]
        public Ogretmen Post([FromBody] Ogretmen ogretmen)
        {
            return _ogretmenService.CreateOgretmen(ogretmen);
        }
        [HttpPut]
        public Ogretmen Put([FromBody] Ogretmen ogretmen)
        {
            return _ogretmenService.UpdateOgretmen(ogretmen);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _ogretmenService.DeleteOgretmen(id);
        }
    }
}

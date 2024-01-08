using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Membre.Data.Interface;
using Membre.Data.Repository;

namespace MembreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembreController : ControllerBase
    {
        private readonly IMembre membres = new MembreRepository();
        [HttpGet("getall")]
        public IActionResult GetAllMembres()
        {
            return Ok(membres.GetAllMembre());
        }
        [HttpGet("getmembrebyid/{id}")]
        public IActionResult GetMenbere(int id)
        {
            return Ok(membres.GetMembre(id));
        }
    }
}

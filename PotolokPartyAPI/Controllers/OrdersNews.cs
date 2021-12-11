using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PotolokPartyAPI.Service;

namespace PotolokPartyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersNewsController : ControllerBase
    {
        private readonly IRepository _repository;

        public OrdersNewsController(IRepository repository)
        {
            _repository = repository;
        }

        #region snippet
        [HttpGet]
        public IActionResult List()
        {
            return Ok(_repository.AllNews);
        }
        #endregion
    }
}

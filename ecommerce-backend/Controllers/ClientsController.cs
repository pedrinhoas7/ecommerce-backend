using Backend.Application.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ClientsController : ControllerBase
    {

        private readonly IClientService _service;


        public ClientsController(IClientService service)
        {
            _service = service;
        }

        [HttpGet]
        public bool Get()
        {
            return _service.GetClients();
        }
    }
}

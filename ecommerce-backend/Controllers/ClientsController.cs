using Backend.Apllication.DTO;
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
        [AllowAnonymous]
        public List<ClientDTO> Get()
        {
            return _service.GetClients();
        }

        [HttpPost]
        [AllowAnonymous]
        public void Create(ClientDTO client)
        {
            _service.CreateClient(client);
        }

        [HttpPut("/Clients/{id}")]
        [AllowAnonymous]
        public void Update([FromQuery]string id, ClientDTO client)
        {
           _service.UpdateClient(client);
        }
    }
}

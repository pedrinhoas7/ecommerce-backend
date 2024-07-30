using Backend.Apllication.DTO;
using Backend.Application.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Sockets;

namespace ecommerce_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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

        [HttpGet("{id}")]
        [AllowAnonymous]
        public ClientDTO GetById([FromRoute] string id)
        {
            return _service.GetById(id);
        }


        [HttpPost]
        [AllowAnonymous]
        public void Create(ClientDTO client)
        {
            _service.CreateClient(client);
        }

        [HttpPut("{id}")]
        [AllowAnonymous]
        public void Update([FromRoute] string id, ClientDTO client)
        {
           _service.UpdateClient(id, client);
        }
    }
}

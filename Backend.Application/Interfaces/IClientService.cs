using Backend.Application.DTO;
using Backend.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.Interfaces
{
    public interface IClientService
    {
        IEnumerable<ClientEntity> GetClients();
    }
}

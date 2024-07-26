using Backend.Domain.Atributes;
using Backend.Domain.Base;

namespace Backend.Core.Entities
{
    [Document]
    public class ClientEntity : EntityNoSql
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsBlocked { get; set; }
    }
}

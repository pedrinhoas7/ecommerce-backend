﻿using Backend.Domain.Atributes;
using Backend.Domain.Base;
using Backend.Core.enums;

namespace Backend.Core.Entities
{
    [Document]
    public class ClientEntity : EntityNoSql
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsBlocked { get; set; }
        public TypeClient TypeClient { get; set; }
        public string Password { get; set; }
        public string DocumentName { get; set; }
        public string DocumentIdentifier { get; set; }
        public string InscricaoEstadual { get; set; }
        public TypeGender TypeGender { get; set; }
        public DateTime BirthDate { get; set; }
    }
}

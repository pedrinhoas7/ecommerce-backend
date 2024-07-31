using MongoDB.Bson;
using MongoDB.Driver;
using Backend.Domain.enums;

namespace Backend.Domain.Migrations
{
    public class Migration
    {
        public void Down(IMongoDatabase database)
        {
            var collection = database.GetCollection<BsonDocument>("ClientEntity");
            collection.DeleteMany(x => true); // Remove todos os documentos da coleção
        }

        public void Up(IMongoDatabase database)
        {
            var collection = database.GetCollection<BsonDocument>("ClientEntity");

            var clients = new List<BsonDocument>
{
    new BsonDocument
    {
        { "Name", "Carlos Silva" },
        { "Email", "carlos.silva@example.com" },
        { "Phone", "(83) 9 2345-8910" },
        { "IsBlocked", false },
        { "CreationDate", DateTime.UtcNow },
        { "DeletedFlag", false },
        { "TypeClient", TypeClient.Fisica },
        { "Password", BsonNull.Value },
        { "DocumentName", "CPF" },
        { "DocumentIdentifier", "12345678900" },
        { "InscricaoEstadual", "" },
        { "TypeGender", TypeGender.Masculino },
        { "BirthDate", new DateTime(1985, 5, 15) }
    },
    new BsonDocument
    {
        { "Name", "Ana Pereira" },
        { "Email", "ana.pereira@example.com" },
        { "Phone", "(83) 9 2345-8910" },
        { "IsBlocked", false },
        { "CreationDate", DateTime.UtcNow },
        { "DeletedFlag", false },
        { "TypeClient", TypeClient.Fisica },
        { "Password", BsonNull.Value },
        { "DocumentName", "CPF" },
        { "DocumentIdentifier", "12345678901" },
        { "InscricaoEstadual", "" },
        { "TypeGender", TypeGender.Feminino },
        { "BirthDate", new DateTime(1990, 8, 25) }
    },
    new BsonDocument
    {
        { "Name", "João Souza" },
        { "Email", "joao.souza@example.com" },
        { "Phone", "(83) 9 2345-8910" },
        { "IsBlocked", true },
        { "CreationDate", DateTime.UtcNow },
        { "DeletedFlag", false },
        { "TypeClient", TypeClient.Fisica },
        { "Password", BsonNull.Value },
        { "DocumentName", "CPF" },
        { "DocumentIdentifier", "12345678902" },
        { "InscricaoEstadual", "" },
        { "TypeGender", TypeGender.Masculino },
        { "BirthDate", new DateTime(1978, 12, 20) }
    },
    new BsonDocument
    {
        { "Name", "Maria Oliveira" },
        { "Email", "maria.oliveira@example.com" },
        { "Phone", "(83) 9 2345-8910" },
        { "IsBlocked", false },
        { "CreationDate", DateTime.UtcNow },
        { "DeletedFlag", false },
        { "TypeClient", TypeClient.Fisica },
        { "Password", BsonNull.Value },
        { "DocumentName", "CPF" },
        { "DocumentIdentifier", "12345678903" },
        { "InscricaoEstadual", "" },
        { "TypeGender", TypeGender.Feminino },
        { "BirthDate", new DateTime(1995, 3, 10) }
    },
    new BsonDocument
    {
        { "Name", "Lucas Costa" },
        { "Email", "lucas.costa@example.com" },
        { "Phone", "(83) 9 2345-8910" },
        { "IsBlocked", false },
        { "CreationDate", DateTime.UtcNow },
        { "DeletedFlag", false },
        { "TypeClient", TypeClient.Fisica },
        { "Password", BsonNull.Value },
        { "DocumentName", "CPF" },
        { "DocumentIdentifier", "12345678904" },
        { "InscricaoEstadual", "" },
        { "TypeGender", TypeGender.Masculino },
        { "BirthDate", new DateTime(1988, 7, 18) }
    },
    new BsonDocument
    {
        { "Name", "Juliana Lima" },
        { "Email", "juliana.lima@example.com" },
        { "Phone", "(83) 9 2345-8910" },
        { "IsBlocked", true },
        { "CreationDate", DateTime.UtcNow },
        { "DeletedFlag", false },
        { "TypeClient", TypeClient.Fisica },
        { "Password", BsonNull.Value },
        { "DocumentName", "CPF" },
        { "DocumentIdentifier", "12345678905" },
        { "InscricaoEstadual", "" },
        { "TypeGender", TypeGender.Feminino },
        { "BirthDate", new DateTime(1992, 11, 30) }
    },
    new BsonDocument
    {
        { "Name", "Gabriel Almeida" },
        { "Email", "gabriel.almeida@example.com" },
        { "Phone", "(83) 9 2345-8910" },
        { "IsBlocked", false },
        { "CreationDate", DateTime.UtcNow },
        { "DeletedFlag", false },
        { "TypeClient", TypeClient.Fisica },
        { "Password", BsonNull.Value },
        { "DocumentName", "CPF" },
        { "DocumentIdentifier", "12345678906" },
        { "InscricaoEstadual", "" },
        { "TypeGender", TypeGender.Masculino },
        { "BirthDate", new DateTime(1983, 9, 5) }
    },
    new BsonDocument
    {
        { "Name", "Fernanda Souza" },
        { "Email", "fernanda.souza@example.com" },
        { "Phone", "(83) 9 2345-8910" },
        { "IsBlocked", false },
        { "CreationDate", DateTime.UtcNow },
        { "DeletedFlag", false },
        { "TypeClient", TypeClient.Fisica },
        { "Password", BsonNull.Value },
        { "DocumentName", "CPF" },
        { "DocumentIdentifier", "12345678907" },
        { "InscricaoEstadual", "" },
        { "TypeGender", TypeGender.Feminino },
        { "BirthDate", new DateTime(1980, 2, 28) }
    },
    new BsonDocument
    {
        { "Name", "Ricardo Ribeiro" },
        { "Email", "ricardo.ribeiro@example.com" },
        { "Phone", "(83) 9 2345-8910" },
        { "IsBlocked", false },
        { "CreationDate", DateTime.UtcNow },
        { "DeletedFlag", false },
        { "TypeClient", TypeClient.Fisica },
        { "Password", BsonNull.Value },
        { "DocumentName", "CPF" },
        { "DocumentIdentifier", "12345678908" },
        { "InscricaoEstadual", "" },
        { "TypeGender", TypeGender.Masculino },
        { "BirthDate", new DateTime(1976, 6, 22) }
    },
    new BsonDocument
    {
        { "Name", "Patricia Santos" },
        { "Email", "patricia.santos@example.com" },
        { "Phone", "(83) 9 2345-8910" },
        { "IsBlocked", false },
        { "CreationDate", DateTime.UtcNow },
        { "DeletedFlag", false },
        { "TypeClient", TypeClient.Fisica },
        { "Password", BsonNull.Value },
        { "DocumentName", "CPF" },
        { "DocumentIdentifier", "12345678909" },
        { "InscricaoEstadual", "" },
        { "TypeGender", TypeGender.Feminino },
        { "BirthDate", new DateTime(1993, 4, 14) }
    },
        new BsonDocument
    {
        { "Name", "Empresa Alpha" },
        { "Email", "contato@alpha.com" },
        { "Phone", "(83) 9 2345-8910" },
        { "IsBlocked", false },
        { "CreationDate", DateTime.UtcNow },
        { "DeletedFlag", false },
        { "TypeClient", TypeClient.Juridica },
        { "Password", BsonNull.Value },
        { "DocumentName", "CNPJ" },
        { "DocumentIdentifier", "12345678000101" },
        { "InscricaoEstadual", "123456789" },
        { "TypeGender", TypeGender.Outro },
        { "BirthDate", new DateTime(2005, 4, 12) }
    },
    new BsonDocument
    {
        { "Name", "Beta Corporation" },
        { "Email", "info@betacorp.com" },
        { "Phone", "(83) 9 2345-8910" },
        { "IsBlocked", true },
        { "CreationDate", DateTime.UtcNow },
        { "DeletedFlag", false },
        { "TypeClient", TypeClient.Juridica },
        { "Password", BsonNull.Value },
        { "DocumentName", "CNPJ" },
        { "DocumentIdentifier", "12345678000202" },
        { "InscricaoEstadual", "987654321" },
        { "TypeGender", TypeGender.Outro },
        { "BirthDate", new DateTime(2010, 8, 22) }
    },
    new BsonDocument
    {
        { "Name", "Gamma Industries" },
        { "Email", "contact@gammaind.com" },
        { "Phone", "(83) 9 2345-8910" },
        { "IsBlocked", false },
        { "CreationDate", DateTime.UtcNow },
        { "DeletedFlag", false },
        { "TypeClient", TypeClient.Juridica },
        { "Password", BsonNull.Value },
        { "DocumentName", "CNPJ" },
        { "DocumentIdentifier", "12345678000303" },
        { "InscricaoEstadual", "192837465" },
        { "TypeGender", TypeGender.Outro },
        { "BirthDate", new DateTime(2015, 3, 5) }
    },
    new BsonDocument
    {
        { "Name", "Delta Services" },
        { "Email", "support@deltaservices.com" },
        { "Phone", "(83) 9 2345-8910" },
        { "IsBlocked", false },
        { "CreationDate", DateTime.UtcNow },
        { "DeletedFlag", false },
        { "TypeClient", TypeClient.Juridica },
        { "Password", BsonNull.Value },
        { "DocumentName", "CNPJ" },
        { "DocumentIdentifier", "12345678000404" },
        { "InscricaoEstadual", "564738291" },
        { "TypeGender", TypeGender.Outro },
        { "BirthDate", new DateTime(2000, 11, 17) }
    },
    new BsonDocument
    {
        { "Name", "Epsilon Solutions" },
        { "Email", "sales@epsilonsolutions.com" },
        { "Phone", "(83) 9 2345-8910" },
        { "IsBlocked", true },
        { "CreationDate", DateTime.UtcNow },
        { "DeletedFlag", false },
        { "TypeClient", TypeClient.Juridica },
        { "Password", BsonNull.Value },
        { "DocumentName", "CNPJ" },
        { "DocumentIdentifier", "12345678000505" },
        { "InscricaoEstadual", "675849302" },
        { "TypeGender", TypeGender.Outro },
        { "BirthDate", new DateTime(2008, 7, 30) }
    },
    new BsonDocument
    {
        { "Name", "Zeta Enterprises" },
        { "Email", "admin@zetaenterprises.com" },
        { "Phone", "(83) 9 2345-8910" },
        { "IsBlocked", false },
        { "CreationDate", DateTime.UtcNow },
        { "DeletedFlag", false },
        { "TypeClient", TypeClient.Juridica },
        { "Password", BsonNull.Value },
        { "DocumentName", "CNPJ" },
        { "DocumentIdentifier", "12345678000606" },
        { "InscricaoEstadual", "384756201" },
        { "TypeGender", TypeGender.Outro },
        { "BirthDate", new DateTime(2012, 1, 25) }
    },
    new BsonDocument
    {
        { "Name", "Theta Technologies" },
        { "Email", "info@theta-tech.com" },
        { "Phone", "(83) 9 2345-8910" },
        { "IsBlocked", false },
        { "CreationDate", DateTime.UtcNow },
        { "DeletedFlag", false },
        { "TypeClient", TypeClient.Juridica },
        { "Password", BsonNull.Value },
        { "DocumentName", "CNPJ" },
        { "DocumentIdentifier", "12345678000707" },
        { "InscricaoEstadual", "938475610" },
        { "TypeGender", TypeGender.Outro },
        { "BirthDate", new DateTime(2003, 9, 14) }
    },
    new BsonDocument
    {
        { "Name", "Iota Innovations" },
        { "Email", "contact@iotainnovations.com" },
        { "Phone", "(83) 9 2345-8910" },
        { "IsBlocked", true },
        { "CreationDate", DateTime.UtcNow },
        { "DeletedFlag", false },
        { "TypeClient", TypeClient.Juridica },
        { "Password", BsonNull.Value },
        { "DocumentName", "CNPJ" },
        { "DocumentIdentifier", "12345678000808" },
        { "InscricaoEstadual", "182736495" },
        { "TypeGender", TypeGender.Outro },
        { "BirthDate", new DateTime(2018, 6, 10) }
    },
    new BsonDocument
    {
        { "Name", "Kappa Logistics" },
        { "Email", "logistics@kappa.com" },
        { "Phone", "(83) 9 2345-8910" },
        { "IsBlocked", false },
        { "CreationDate", DateTime.UtcNow },
        { "DeletedFlag", false },
        { "TypeClient", TypeClient.Juridica },
        { "Password", BsonNull.Value },
        { "DocumentName", "CNPJ" },
        { "DocumentIdentifier", "12345678000909" },
        { "InscricaoEstadual", "273849501" },
        { "TypeGender", TypeGender.Outro },
        { "BirthDate", new DateTime(2006, 2, 19) }
    },
    new BsonDocument
    {
        { "Name", "Lambda Manufacturing" },
        { "Email", "info@lambda-mfg.com" },
        { "Phone", "(83) 9 2345-8910" },
        { "IsBlocked", false },
        { "CreationDate", DateTime.UtcNow },
        { "DeletedFlag", false },
        { "TypeClient", TypeClient.Juridica },
        { "Password", BsonNull.Value },
        { "DocumentName", "CNPJ" },
        { "DocumentIdentifier", "12345678001010" },
        { "InscricaoEstadual", "564738291" },
        { "TypeGender", TypeGender.Outro },
        { "BirthDate", new DateTime(2016, 11, 29) }
    }
};


            collection.InsertMany(clients);
        }
    }
}

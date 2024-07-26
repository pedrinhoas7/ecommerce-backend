using MongoDB.Bson;
using MongoDB.Driver;

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
                    { "Name", "Client 1" },
                    { "Email", "client1@example.com" },
                    { "Phone", "123-456-7890" },
                    { "IsBlocked", false },
                    { "CreationDate", DateTime.UtcNow },
                    { "LastUpdateDate", BsonNull.Value },
                    { "DeletedFlag", false }
                },
                new BsonDocument
                {
                    { "Name", "Client 2" },
                    { "Email", "client2@example.com" },
                    { "Phone", "123-456-7891" },
                    { "IsBlocked", false },
                    { "CreationDate", DateTime.UtcNow },
                    { "LastUpdateDate", BsonNull.Value },
                    { "DeletedFlag", false }
                },
                new BsonDocument
                {
                    { "Name", "Client 3" },
                    { "Email", "client3@example.com" },
                    { "Phone", "123-456-7892" },
                    { "IsBlocked", false },
                    { "CreationDate", DateTime.UtcNow },
                    { "LastUpdateDate", BsonNull.Value },
                    { "DeletedFlag", false }
                },
                new BsonDocument
                {
                    { "Name", "Client 4" },
                    { "Email", "client4@example.com" },
                    { "Phone", "123-456-7893" },
                    { "IsBlocked", false },
                    { "CreationDate", DateTime.UtcNow },
                    { "LastUpdateDate", BsonNull.Value },
                    { "DeletedFlag", false }
                },
                new BsonDocument
                {
                    { "Name", "Client 5" },
                    { "Email", "client5@example.com" },
                    { "Phone", "123-456-7894" },
                    { "IsBlocked", false },
                    { "CreationDate", DateTime.UtcNow },
                    { "LastUpdateDate", BsonNull.Value },
                    { "DeletedFlag", false }
                },
                new BsonDocument
                {
                    { "Name", "Client 6" },
                    { "Email", "client6@example.com" },
                    { "Phone", "123-456-7895" },
                    { "IsBlocked", false },
                    { "CreationDate", DateTime.UtcNow },
                    { "LastUpdateDate", BsonNull.Value },
                    { "DeletedFlag", false }
                },
                new BsonDocument
                {
                    { "Name", "Client 7" },
                    { "Email", "client7@example.com" },
                    { "Phone", "123-456-7896" },
                    { "IsBlocked", false },
                    { "CreationDate", DateTime.UtcNow },
                    { "LastUpdateDate", BsonNull.Value },
                    { "DeletedFlag", false }
                },
                new BsonDocument
                {
                    { "Name", "Client 8" },
                    { "Email", "client8@example.com" },
                    { "Phone", "123-456-7897" },
                    { "IsBlocked", false },
                    { "CreationDate", DateTime.UtcNow },
                    { "LastUpdateDate", BsonNull.Value },
                    { "DeletedFlag", false }
                },
                new BsonDocument
                {
                    { "Name", "Client 9" },
                    { "Email", "client9@example.com" },
                    { "Phone", "123-456-7898" },
                    { "IsBlocked", false },
                    { "CreationDate", DateTime.UtcNow },
                    { "LastUpdateDate", BsonNull.Value },
                    { "DeletedFlag", false }
                },
                new BsonDocument
                {
                    { "Name", "Client 10" },
                    { "Email", "client10@example.com" },
                    { "Phone", "123-456-7899" },
                    { "IsBlocked", false },
                    { "CreationDate", DateTime.UtcNow },
                    { "LastUpdateDate", BsonNull.Value },
                    { "DeletedFlag", false }
                },
                new BsonDocument
                {
                    { "Name", "Client 11" },
                    { "Email", "client11@example.com" },
                    { "Phone", "123-456-7900" },
                    { "IsBlocked", false },
                    { "CreationDate", DateTime.UtcNow },
                    { "LastUpdateDate", BsonNull.Value },
                    { "DeletedFlag", false }
                },
                new BsonDocument
                {
                    { "Name", "Client 12" },
                    { "Email", "client12@example.com" },
                    { "Phone", "123-456-7901" },
                    { "IsBlocked", false },
                    { "CreationDate", DateTime.UtcNow },
                    { "LastUpdateDate", BsonNull.Value },
                    { "DeletedFlag", false }
                },
                new BsonDocument
                {
                    { "Name", "Client 13" },
                    { "Email", "client13@example.com" },
                    { "Phone", "123-456-7902" },
                    { "IsBlocked", false },
                    { "CreationDate", DateTime.UtcNow },
                    { "LastUpdateDate", BsonNull.Value },
                    { "DeletedFlag", false }
                },
                new BsonDocument
                {
                    { "Name", "Client 14" },
                    { "Email", "client14@example.com" },
                    { "Phone", "123-456-7903" },
                    { "IsBlocked", false },
                    { "CreationDate", DateTime.UtcNow },
                    { "LastUpdateDate", BsonNull.Value },
                    { "DeletedFlag", false }
                },
                new BsonDocument
                {
                    { "Name", "Client 15" },
                    { "Email", "client15@example.com" },
                    { "Phone", "123-456-7904" },
                    { "IsBlocked", false },
                    { "CreationDate", DateTime.UtcNow },
                    { "LastUpdateDate", BsonNull.Value },
                    { "DeletedFlag", false }
                },
                new BsonDocument
                {
                    { "Name", "Client 16" },
                    { "Email", "client16@example.com" },
                    { "Phone", "123-456-7905" },
                    { "IsBlocked", false },
                    { "CreationDate", DateTime.UtcNow },
                    { "LastUpdateDate", BsonNull.Value },
                    { "DeletedFlag", false }
                },
                new BsonDocument
                {
                    { "Name", "Client 17" },
                    { "Email", "client17@example.com" },
                    { "Phone", "123-456-7906" },
                    { "IsBlocked", false },
                    { "CreationDate", DateTime.UtcNow },
                    { "LastUpdateDate", BsonNull.Value },
                    { "DeletedFlag", false }
                },
                new BsonDocument
                {
                    { "Name", "Client 18" },
                    { "Email", "client18@example.com" },
                    { "Phone", "123-456-7907" },
                    { "IsBlocked", false },
                    { "CreationDate", DateTime.UtcNow },
                    { "LastUpdateDate", BsonNull.Value },
                    { "DeletedFlag", false }
                },
                new BsonDocument
                {
                    { "Name", "Client 19" },
                    { "Email", "client19@example.com" },
                    { "Phone", "123-456-7908" },
                    { "IsBlocked", false },
                    { "CreationDate", DateTime.UtcNow },
                    { "LastUpdateDate", BsonNull.Value },
                    { "DeletedFlag", false }
                },
                new BsonDocument
                {
                    { "Name", "Client 20" },
                    { "Email", "client20@example.com" },
                    { "Phone", "123-456-7909" },
                    { "IsBlocked", false },
                    { "CreationDate", DateTime.UtcNow },
                    { "LastUpdateDate", BsonNull.Value },
                    { "DeletedFlag", false }
                },
                new BsonDocument
                {
                    { "Name", "Client 21" },
                    { "Email", "client21@example.com" },
                    { "Phone", "123-456-7910" },
                    { "IsBlocked", false },
                    { "CreationDate", DateTime.UtcNow },
                    { "LastUpdateDate", BsonNull.Value },
                    { "DeletedFlag", false }
                }
            };

            collection.InsertMany(clients);
        }
    }
}

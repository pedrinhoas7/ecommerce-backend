using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Backend.Domain.Base
{
    public class EntityNoSql
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public DateTime CreationDate { get; set; }
        public Nullable<DateTime> LastUpdateDate { get; set; }
        public bool DeletedFlag { get; set; }
    }
}

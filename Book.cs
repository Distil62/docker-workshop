using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace docker_workshop.Entity
{
    public class Book
    {

        public Book(string name, decimal price)
        {
            BookName = name;
            Price = price;
        }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string BookName { get; set; }

        [BsonElement("Price")]
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Name : {BookName}, Price : {Price}";
        }
    }
}
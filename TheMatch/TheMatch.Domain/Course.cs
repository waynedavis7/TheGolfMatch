using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace TheMatch.Domain
{
    public class Course
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CourseId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        //public List<Hole> Holes { get; set; }

        public List<Tee> Tees { get; set; }
        
    }
}

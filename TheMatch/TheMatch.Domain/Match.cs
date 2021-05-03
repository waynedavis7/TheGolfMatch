using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace TheMatch.Domain
{
    public class Match
    {     

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string MatchId { get; set; }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Course Course { get; set; }
        public List<MatchPlayer> Players { get; set; }
    }
}

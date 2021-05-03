using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using TheMatch.Domain;

namespace TheMatch.Infrastructure.SampleData
{
    public class MatchRepository : IMatchRepository
    {
        private MongoClient _client;
        private IMongoDatabase _db;
        private IMongoCollection<Match> _collection;

        public MatchRepository()
        {
            LoadData();
        }

        private void LoadData()
        {
            _client = new MongoClient("mongodb://thematchapp:1OAq9FB8ewPmnies@cluster0-shard-00-00.aq0bp.mongodb.net:27017,cluster0-shard-00-01.aq0bp.mongodb.net:27017,cluster0-shard-00-02.aq0bp.mongodb.net:27017/THEMATCHDB?ssl=true&replicaSet=atlas-o2xpxe-shard-0&authSource=admin&retryWrites=true&w=majority");
            _db = _client.GetDatabase("thematchapp");
            _collection = _db.GetCollection<Match>("Match");
        }

        public void Add(Match match)
        {
            var sort = Builders<Match>.Sort.Descending("Id"); //build sort object   
            FilterDefinition<Match> filterMatchData = Builders<Match>.Filter.Gt("Id", -1);
            var lastMatch = _collection.Find(filterMatchData).Sort(sort).FirstOrDefault();

            if (lastMatch != null)
            {
                match.Id = lastMatch.Id + 1;
            }

            _collection.InsertOne(match);
        }

        public Match GetMatch(int matchid)
        {
            FilterDefinition<Match> filterMatchData = Builders<Match>.Filter.Eq("Id", matchid);
            return _collection.Find(filterMatchData).FirstOrDefault();
        }

        public List<Match> GetMatches()
        {
            return _collection.Find(_ => true).ToList();
        }

        public void Save()
        {
            //FilterDefinition<Match> filterMatchData = Builders<Match>.Filter.Eq("Id", );
            //_collection.DeleteOne(filterMatchData);
        }

        public void Delete(Match match)
        {
            FilterDefinition<Match> filterMatchData = Builders<Match>.Filter.Eq("Id", match.Id);
            _collection.DeleteOne(filterMatchData);
        }

        public void Save(Match match)
        {
            FilterDefinition<Match> filterMatchData = Builders<Match>.Filter.Eq("Id", match.Id);
            _collection.ReplaceOne(filter: g => g.Id == match.Id, replacement: match);
        }
    }
}

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using TheMatch.Domain;
using MongoDB.Driver;

namespace TheMatch.Infrastructure.SampleData
{
    public class CourseRepository : ICourseRepository
    {
        //private readonly List<Course> _courses;
        private readonly MongoClient _client;
        private readonly IMongoDatabase _db;
        private readonly IMongoCollection<Course> _collection;

        public CourseRepository()
        {
            _client = new MongoClient("mongodb://thematchapp:1OAq9FB8ewPmnies@cluster0-shard-00-00.aq0bp.mongodb.net:27017,cluster0-shard-00-01.aq0bp.mongodb.net:27017,cluster0-shard-00-02.aq0bp.mongodb.net:27017/THEMATCHDB?ssl=true&replicaSet=atlas-o2xpxe-shard-0&authSource=admin&retryWrites=true&w=majority");
            _db = _client.GetDatabase("thematchapp");
            _collection = _db.GetCollection<Course>("Course");

            //var jsonString = File.ReadAllText(@"SampleData\\courses.json");
            //_courses = JsonSerializer.Deserialize<List<Course>>(jsonString);

            //mongocourses.InsertMany(_courses);
            //foreach (var c in _courses)
            //{
                
            //}
        }

        public void AddCourse(Course course)
        {
            //_courses.Add(course);             
            //var sort = Builders<Match>.Sort.Descending("Id"); //build sort object   
            //FilterDefinition<Match> filterMatchData = Builders<Match>.Filter.Gt("Id", -1);
            //var lastMatch = _collection.Find(filterMatchData).Sort(sort).FirstOrDefault();

            //if (lastMatch != null)
            //{
            //    match.Id = lastMatch.Id + 1;
            //}

            //_collection.InsertOne(match);
        }

        public void DeleteCourse(Course course)
        {
            //_courses.Remove(course);
        }

        public Course GetCourse()
        {
            throw new System.NotImplementedException();
        }

        public Course GetCourse(int CourseId)
        {
            FilterDefinition<Course> filterCourseData = Builders<Course>.Filter.Eq("Id", CourseId);
            return _collection.Find(filterCourseData).FirstOrDefault();
        }


        public List<Course> GetCourses()
        {
            return _collection.Find(_ => true).ToList();
        }

        public async Task<List<Course>> GetCoursesAsync()
        {
            var courses = await _collection.FindAsync(_ => true);           
            return courses.ToList<Course>();
        }
    }
}

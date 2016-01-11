using MongoDB.Bson.Serialization.Attributes;

namespace Students.DataModel.Models
{
    public class Student
    {
        [BsonElement("_id")]
        public int StudentID { get; set; }
        public string RollNo { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        
    }
}

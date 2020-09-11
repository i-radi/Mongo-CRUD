using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MongoDBDemo
{
    public class Student
    {
        [BsonId]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address PrimaryAddress { get; set; }
        [BsonElement("dob")]
        public DateTime DateOfBitrth { get; set; }
    }
}

using System;

namespace MongoDBDemo
{
    class Program
    {
        [Obsolete]
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("UserInfo");
            /*
            Student student = new Student
             {
                 Id = 10100,
                 FirstName = "Mohamed",
                 LastName = "Ahmed",
                 PrimaryAddress = new Address
                 {
                     Street = "Dr.Ali Ahmed",
                     City = "ALexandria",
                     State = "Egypt",
                     ZipCode = "21934"
                 }
             };
             db.InsertRecord("Users", student);
            */
            /*
            var recs = db.GetRecords<Student>("Users");
            foreach (var rec in recs)
            {
                Console.WriteLine($"{rec.Id}:{rec.FirstName} {rec.LastName}");
                if (rec.PrimaryAddress!=null)
                {
                    Console.WriteLine(rec.PrimaryAddress.City + "\n");
                }
            }
            */
            /*
            var rec = db.GetRecordsById<Student>("Users", 10100);
            Console.WriteLine($"{rec.Id}:{rec.FirstName} {rec.LastName}");
            */
            /*
            var rec = db.GetRecordsById<Student>("Users", 10100);
            rec.DateOfBitrth = new DateTime(1995, 3, 4, 5, 6, 7, DateTimeKind.Local);
            db.UpdateRecord("Users", rec.Id, rec);
            */
            //db.DeleteRecord<Student>("Users", rec.Id);
            

            Console.ReadKey();
        }
    }
}

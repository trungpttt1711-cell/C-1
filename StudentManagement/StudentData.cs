using System.Collections.Generic;
using ExampleCAdvance.Entities;

namespace ExampleCAdvance
{
    public static class StudentData
    {
        public static List<Student> GetSampleStudents()
        {
            return new List<Student>
            {
               new Student { StuID = "SV001", Name = "Pham Thi A", MidPoint = 9.5, FinalPoint = 8.5, Email = "a.pham@example.com" },
                new Student { StuID = "SV002", Name = "Nguyen Van B",  MidPoint = 6.5, FinalPoint = 7.5, Email = "b.nguyen@example.com" },
                new Student { StuID = "SV003", Name = "Do Thi C",    MidPoint = 9.0, FinalPoint = 9.0, Email = "c.do@example.com" },
                new Student { StuID = "SV004", Name = "Hoang Thanh D",  MidPoint = 8.0, FinalPoint = 7.5, Email = "d.hoang@example.com" },
                new Student { StuID = "SV005", Name = "Vo Hoang E",  MidPoint = 6.5, FinalPoint = 6.5, Email = "e.vo@example.com" }
            };
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cross_Join
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<Student> GetAllStudnets()
        {
            return new List<Student>()
            {
                new Student { ID = 1, Name = "Preety"},
                new Student { ID = 2, Name = "Priyanka"},
                new Student { ID = 3, Name = "Anurag"},
                new Student { ID = 4, Name = "Pranaya"},
                new Student { ID = 5, Name = "Hina"}
            };
        }
    }
}

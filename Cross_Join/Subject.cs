using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cross_Join
{
    public class Subject
    {
        public int ID { get; set; }
        public string SubjectName { get; set; }
        public static List<Subject> GetAllSubjects()
        {
            return new List<Subject>()
            {
                new Subject { ID = 1, SubjectName = "ASP.NET"},
                new Subject { ID = 2, SubjectName = "SQL Server" },
                new Subject { ID = 5, SubjectName = "Linq"}
            };
        }
    }
}

#region Right Outer Join using Linq Query  
using Right_Outer_Join;

Developer[] developers = new Developer[] {
    new Developer {
        Id = 1, SkillID = 6, Name = "Gnanavel Sekar"
    },
    new Developer {
        Id = 2, SkillID = 2, Name = "Subash S"
    },
    new Developer {
        Id = 3, SkillID = 1, Name = "Ammaiyappan I"
    },
    new Developer {
        Id = 4, SkillID = 12, Name = "Robert B"
    },
    new Developer {
        Id = 3, SkillID = 10, Name = "Ramar A"
    },
};
Skill[] skills = new Skill[] {
    new Skill {
        Id = 1, Name = "ASP.NET"
    },
    new Skill {
        Id = 2, Name = "C#"
    },
    new Skill {
        Id = 3, Name = "LINQ"
    },
    new Skill {
        Id = 4, Name = "ORCHARD CMS"
    },
    new Skill {
        Id = 5, Name = "Entity Framework"
    },
    new Skill {
        Id = 6, Name = "ASP.NET MVC"
    },
    new Skill {
        Id = 7, Name = "ASP.NET WEB API"
    },
    new Skill {
        Id = 8, Name = "JQUERY"
    },
    new Skill {
        Id = 9, Name = "DOCUSIGN"
    },
    new Skill {
        Id = 10, Name = "KENDO UI"
    },
    new Skill {
        Id = 11, Name = "ASP.NET AJAX"
    },
    new Skill {
        Id = 12, Name = "HTML5"
    },
};

//Defered Query Execution  
var rightJoin = from skill in skills
                join deve in developers
                on skill.Id equals deve.SkillID into joinDeptEmp
                from employee in joinDeptEmp.DefaultIfEmpty()
                select new
                {
                    EmployeeName = employee != null ? employee.Name : null,
                    SkillName = skill.Name
                };
//Immediate Query Exectuion  
foreach (var item in rightJoin)
{
    Console.WriteLine("Skill : " + item.SkillName + " , Developer Name : " + item.EmployeeName);
}
#endregion
using Cross_Join;

var CrossJoinResult = from employee in Student.GetAllStudnets()
                      from subject in Subject.GetAllSubjects()
                      select new
                      {
                          Name = employee.Name,
                          SubjectName = subject.SubjectName
                      };
foreach (var item in CrossJoinResult)
{
    Console.WriteLine($"Name : {item.Name}, Subject: {item.SubjectName}");
}
Console.ReadLine();
// Create a list of students.

using Composite_Key_Join;

List<Student> students = new List<Student> {

new Student { FirstName = "Gregory", LastName = "Croft", StudentID = 444123 },

new Student { FirstName = "Bill", LastName = "Yack", StudentID = 194568 },

new Student { FirstName = "Jeremy", LastName = "Little", StudentID = 902011 },

new Student { FirstName = "Phil", LastName = "Winstanley", StudentID = 347812 } };



// Create a list of tennis players .

List<TennisPlayer> tennisplayers = new List<TennisPlayer> {

new TennisPlayer { FirstName = "Scott", LastName = "Gate", PlayerID = 5543 },

new TennisPlayer { FirstName = "Jeremy", LastName = "Little", PlayerID = 7091 },

new TennisPlayer {FirstName = "Phil", LastName = "Winstanley", PlayerID = 8867 } } ;


// Join the two data sources based on a composite key consisting of first and last name,

// to determine which students are also tennis players.

IEnumerable<string> query = from student in students

                            join tennisplayer in tennisplayers

                            on new { student.FirstName, student.LastName }

                            equals new { tennisplayer.FirstName, tennisplayer.LastName }

                            select student.FirstName + " " + student.LastName;



Console.WriteLine("The following people are both students and tennis players:");

foreach (string name in query)

    Console.WriteLine(name);
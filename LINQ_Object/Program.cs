using System;

namespace LINQ_Object
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The options for this program are: {0} 1- Operator Select. {0} " +
                "2- Operator SelectMany. {0} ", Environment.NewLine);
            Console.WriteLine("Insert one of the previous options: ");
            String option = Console.ReadLine();

            Employee employee = new Employee();
            switch (option)
            {
                case "1":
                    // Query using Select()
                    employee.runSelect();
                    break;
                case "2":
                    // Query using SelectMany()
                    employee.runSelectMany();
                    break;                
                default:
                    Console.WriteLine("The option is not valid.");
                    break;
            }
                        
        }
    }
}

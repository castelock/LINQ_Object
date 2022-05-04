using System.Linq;
using System;
namespace Left_Outer_Join
{
    class Program
    {
        static void Main(string[] args)
        {
            var QSOuterJoin = from emp in Employee.GetAllEmployees()
                              join add in Address.GetAddress()
                              on emp.AddressId equals add.ID
                              into EmployeeAddressGroup
                              from address in EmployeeAddressGroup.DefaultIfEmpty()
                              select new { emp, address };

            foreach (var item in QSOuterJoin)
            {
                Console.WriteLine($"Name : {item.emp.Name}, Address : {item.address?.AddressLine} ");
            }
            Console.ReadLine();
        }
    }
}
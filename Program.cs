using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Valera", 24, true, "sadsa", "+380111111111", "Matan", 4, "Vyshae ne polnoe");
            Student student = new Student("Valera", 7, true, "+380111111111", "+380111111111", 5, "cD541", 8);
            SecurityGuard guard = new SecurityGuard("Valera", 60, true, "+380111111111", "+380111111111", 5, 15000, 8);


            Community schoolCommunity = new Community();
            schoolCommunity.AddPerson(teacher);
            schoolCommunity.AddPerson(student);
            schoolCommunity.AddPerson(guard);

            foreach (var member in schoolCommunity.SchoolCommunity)
            {
                 Console.WriteLine("--------------------------------------------\n" + member);
            }
            Console.WriteLine("\n\nDelete element #2\n\n");
            schoolCommunity.DeletePerson(1);
            foreach (var member in schoolCommunity.SchoolCommunity)
            {
                Console.WriteLine("--------------------------------------------\n" + member);
            }
            /*Console.WriteLine("////////////////////////////////////////////////////////////");
            Console.WriteLine("Edit element 1");
            Console.WriteLine("////////////////////////////////////////////////////////////");

            schoolCommunity.EditSchoolCommunityMember(0, "NUOP", "Edit name");
            Console.WriteLine(schoolCommunity.SchoolCommunity[0]);*/

            Console.ReadLine();
        }
    }
}

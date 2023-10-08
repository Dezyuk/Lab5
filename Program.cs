using System;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Ivanov Ivan Ivanovich", 25, true, "Address", "+380151655154", "Mathematics", 4, "Highest");
            Student student = new Student("Ivanova Ivanna Ivanovna", 15, false, "Address", "+380151655154", 11, "cD541", 8);
            SecurityGuard guard = new SecurityGuard("Ivanov Ivan Ivanovich", 60, true, "Address", "+380151655154", 5, 15000, 8);


            Community schoolCommunity = new Community();
            schoolCommunity.AddPerson(teacher);
            schoolCommunity.AddPerson(student);
            schoolCommunity.AddPerson(guard);

            foreach (var community in schoolCommunity.SchoolCommunity)
            {
                 Console.WriteLine(community);
            }
            Console.WriteLine("\n\nDelete element #2\n\n");
            schoolCommunity.DeletePerson(1);
            foreach (var community in schoolCommunity.SchoolCommunity)
            {
                Console.WriteLine(community);
            }
            Console.WriteLine("\n\nEdit element 1\n\n");

            //если необходимо изменить параметр у объекта
            teacher.ExperienceYears = 5;

            //если необходимо заменить один элемент в массиве другим
            schoolCommunity.EditCommunity(1, student);

            foreach (var community in schoolCommunity.SchoolCommunity)
            {
                Console.WriteLine(community);
            }

            Console.ReadLine();
        }
    }
}

using PersonManager.Models;

namespace PersonManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonManager<Student> studentManager = new();
            PersonManager<Teacher> teacherManager = new();

            PersonManager<Person> personManager = new();

            // Ajouter des étudiants à la liste des étudiants
            studentManager.AddPerson(new Student("Alex", 14, "E123"));

            // Ajouter des profs à la liste des profs
            teacherManager.AddPerson(new Teacher("Quentin", 27, "T123"));
            teacherManager.AddPerson(new Teacher("Willy", 27, "T126"));
            teacherManager.AddPerson(new Teacher("Arnold", 27, "T123"));
            teacherManager.AddPerson(new Teacher("Béber", 27, "T124"));
            teacherManager.AddPerson(new Teacher("Test", 27, "T125"));

            // Ajouter des persons
            personManager.AddPerson(new Person("Test", 1));

            // Afficher les informations des étudiants
            Console.WriteLine("Informations des étudiants : ");
            studentManager.DisplayInformation();

            // Afficher les informations des profs
            Console.WriteLine("Informations des profs: ");
            teacherManager.DisplayInformation();

            Console.WriteLine("Informations des personnes: ");
            personManager.DisplayInformation();
        }
    }
}
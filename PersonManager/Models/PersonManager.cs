
namespace PersonManager.Models
{
    public class PersonManager<Toto> where Toto : Person
    {
        private readonly List<Toto> _personList = new(); // Type inférence

        // Méthode pour ajouter des personnes à la liste
        public void AddPerson(Toto person)
        {
            _personList.Add(person);
        }

        public void DisplayInformation ()
        {
            foreach (Toto person in _personList) 
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
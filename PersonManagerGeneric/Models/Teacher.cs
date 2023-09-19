
namespace PersonManager.Models
{
    internal class Teacher : Person
    {
        public Teacher(string name, int age, string id) : base(name, age)
        {
            TeacherId = id;
        }

        public string TeacherId { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Identifiant prof : {TeacherId}";
        }
    }
}

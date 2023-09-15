namespace PersonManager.Models
{
    internal class Student : Person
    {
        public Student(string name, int age, string id) : base(name, age)
        {
            StudentId = id;
        }

        public string StudentId { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Identifiant étudiant : {StudentId}";
        }
    }
}
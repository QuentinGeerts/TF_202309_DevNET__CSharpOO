namespace FuncActionGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> addFunc = Add;
            // var addFunc2 = Add;
         
            Action<string> addAction = PrintMessage;

            addAction += PrintMessage;
            addAction += PrintMessage;
            addAction += PrintMessage;
            addAction += PrintMessage;
            addAction += PrintMessage;
            addAction += PrintMessage;

            addAction = addAction + PrintMessage;

            addAction("Coucou");


            Action<int, string> action2 = delegate (int x, string str) { Console.WriteLine($"Valeur de x : {x} et de str : {str}"); };

            action2(42, "Quentin");

            Action<int, string, double, bool, Test> action3;
        }

        // Func : Addition 2 nombres et renvoi le résultat+
        static int Add (int x, int y)
        {
            return x + y;
        }

        // Action : Ne renvoie rien prends un paramètre
        static void PrintMessage (string message)
        {
            Console.WriteLine(message);
        }

    }


    public class Test
    {
        public Test()
        {
            
        }
    }
}
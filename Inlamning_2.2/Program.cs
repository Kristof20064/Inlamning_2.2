using System; 

namespace Inlamning_2._2
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur långt hoppade Elin? (Svara i meter)");
            int Elin = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur långt hoppade Alma? (Svara i meter)");
            int Alma = int.Parse(Console.ReadLine());

            int skillnad = Elin - Alma;

            Console.WriteLine("Elin hoppade " + skillnad + " meter längre.");
        }
    }
}
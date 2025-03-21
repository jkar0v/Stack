using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace zad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число от 10 до 100");
            int n = int.Parse(Console.ReadLine());

            Random random = new Random();
            List<int> chisla = new List<int>();
            while(n > 0)
            {
                chisla.Add(random.Next(1, 101));
                n--;
            }
            Stack<int> nechetni = new Stack<int>();
            Queue<int> chetni = new Queue<int>();
            Console.WriteLine("Числата са:");
            foreach (int chislo in chisla)
            {
                Console.Write(chislo + " ");
            }
            Console.WriteLine();
            foreach (var chislo in chisla)
            {
                if (chislo % 2 == 0)
                {
                    chetni.Enqueue(chislo);
                }
                else
                {
                    nechetni.Push(chislo);
                }
            }
            Console.WriteLine("След модифациите, числата са:");
            foreach (var chislo in chetni)
            {
                Console.Write(chislo + " ");
            }
            foreach (var chislo in nechetni)
            {
                Console.Write(chislo + " ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsStrongAsFuck
{
    class Program
    {
        public static Worker Worker { get; set; }
        public static void Main(string[] args)
        {
            Console.WriteLine("Modified AsStrongAsFuck by moneydev");
            Console.Write("Input an assembly (drag and drop to input path): ");
            string path = Console.ReadLine();
            Worker = new Worker(path);
            Console.WriteLine("Choose options to obfuscate: ");
            Console.WriteLine("I use 589127 preset.");
            for (int i = 0; i < Worker.Obfuscations.Count; i++)
            {
                Console.WriteLine(i + 1 + ") " + Worker.Obfuscations[i]);
            }
            string opts = Console.ReadLine();
            Worker.ExecuteObfuscations(opts);
            Worker.Save();
            Console.ReadLine();
        }
    }
}

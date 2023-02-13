using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewApp
{
    internal class Candidate
    {
        public string[] Onomata = { "Agapi", "Barbara", "Christina", "Dionisis", "Elias", "Florentia", "George", "Iasonas", "Jack", "Kelly" };

        public string RandomPick()
        {
            Random rnd = new Random();
            int randomindex = rnd.Next(0, Onomata.Length);
            return Onomata[randomindex];

        }
        public void PrintCandidateNames()
        {
            var rng = new Random();
            var keys = Onomata.Select(e => rng.NextDouble()).ToArray();

            Array.Sort(keys, Onomata);
            for (int i = 0; i < Onomata.Length; i++)
            {
                Console.WriteLine(Onomata[i]);
            }
        }
    }

}

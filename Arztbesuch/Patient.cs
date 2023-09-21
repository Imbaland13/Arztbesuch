using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arztbesuch
{
    internal class Patient
    {
        public string Name { get; set; }
        public string Nachname { get; set; }
        public DateTime DateTime { get; set; }
        public int KrankenkasseID { get; set; }

        public void Print(Patient pat)
        {
            Console.WriteLine(pat.Name);
            Console.WriteLine(pat.Nachname);
            Console.WriteLine(pat.KrankenkasseID);
            Console.WriteLine(pat.DateTime.ToShortDateString());
        }
        public void PrintQueue(Queue<Patient> queue)
        {
            foreach(Patient pat in  queue)
            {
                Console.WriteLine(pat.Name);
                Console.WriteLine(pat.Nachname);
                Console.WriteLine(pat.KrankenkasseID);
                Console.WriteLine(pat.DateTime.ToShortDateString());
            }
        }
    }
}

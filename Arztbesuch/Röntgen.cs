using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arztbesuch
{
    internal class Röntgen
    {
        public Queue<Patient> Röntgenqueue { get; set; } = new Queue<Patient>();
        public void AddRöntgen(Patient patient)
        {
            Röntgenqueue.Enqueue(patient);
        }
        public void PrintRöntgen()
        {
            foreach(Patient pat in Röntgenqueue)
            {
                Console.WriteLine(pat.Name);
                Console.WriteLine(pat.Nachname);
                Console.WriteLine(pat.KrankenkasseID);
                Console.WriteLine(pat.DateTime.ToShortDateString());
            }
        }
    }
}

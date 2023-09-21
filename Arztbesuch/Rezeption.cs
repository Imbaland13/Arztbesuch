using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arztbesuch
{
    internal class Rezeption
    {
        public List<string> Rezept { get; set; } = new List<string>();
        public Queue<Patient> Queue { get; set;} = new Queue<Patient> ();
        public void SetPatient(Patient p) { Queue.Enqueue(p); }
        public void SetQueue(Queue<Patient> pqueue)
        {
            foreach (Patient pat in pqueue)
            {
                Queue.Enqueue(pat);
            }
        }
        public Patient GetPatient() { return Queue.Peek(); }  
        public void PrintQueue()
        {
            foreach(Patient pat in Queue)
            {
                Console.WriteLine(pat.Name);
                Console.WriteLine(pat.Nachname);
                Console.WriteLine(pat.KrankenkasseID);
                Console.WriteLine(pat.DateTime.ToShortDateString());
            }
        }
    }
}

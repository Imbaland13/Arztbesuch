using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arztbesuch
{
    internal class Arzt
    {
        public Praxis Praxis { get; set; }
        public Röntgen Röntgen { get; set; }
        public Rezeption Rezeption { get; set; }
        public string Name {  get; set; }
        public string Nachname {  get; set; }
        public void Treatment()
        {
            Random rng = new Random();
            Patient pat;
            int zahl;
            zahl = rng.Next(0, 10);
            pat = this.Praxis.Rezeption.Queue.Dequeue();
            if(zahl > 7)
            {
                Console.WriteLine("Sie müssen zum Röntgen.");
                this.Praxis.Röntgen.Röntgenqueue.Enqueue(pat);
            }
            else if(zahl > 3)
            {
                RezeptAusstellen();
            }
            else
            {
                Console.WriteLine("Alles in Ordnung.");
            }
        }
        public void RezeptAusstellen()
        {
            Random rng = new Random();
            int index = rng.Next(0, Praxis.Rezeption.Rezept.Count);
            Console.WriteLine($"Der Patient braucht das Rezept: {Praxis.Rezeption.Rezept[index]}"); 
        }
    }
}

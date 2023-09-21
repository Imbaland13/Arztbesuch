using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Arztbesuch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient patient = new Patient() 
            {
                Name = "Naeem", Nachname = "Baz",
                KrankenkasseID = 1, DateTime = new DateTime(1992, 01, 01)
            };
            Patient patient1 = new Patient()
            {
                Name = "Süle",
                Nachname = "Süle",
                KrankenkasseID = 1,
                DateTime = new DateTime(2015, 01, 01)
            }; 
            Patient patient2 =   new Patient()
            {
                Name = "bla",
                Nachname = "blabla",
                DateTime = new DateTime(1990, 01, 01)
            };
            Praxis praxis = new Praxis();
            praxis.Arzt = new Arzt() { Name = "Steve", Nachname = "Erkel", Praxis = praxis };
            praxis.Rezeption.Rezept.Add("Aspirin");
            praxis.Rezeption.Rezept.Add("Arschlecken350");
            praxis.Rezeption.SetPatient(patient);
            praxis.Rezeption.SetPatient(patient1);
            praxis.Rezeption.SetPatient(patient2);
            Queue<Patient> test = new Queue<Patient>();
            while (praxis.Rezeption.Queue.Count > 0)
            {
                praxis.Arzt.Treatment();
                Thread.Sleep(3);
            }
            praxis.Röntgen.PrintRöntgen();
            Console.WriteLine("==================================================");
            praxis.Rezeption.PrintQueue();
        }
    }
}

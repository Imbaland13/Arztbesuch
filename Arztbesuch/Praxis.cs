using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arztbesuch
{
    internal class Praxis
    {
        public Arzt Arzt { get; set; } = new Arzt();
        public Patient Patient { get; set; }
        public Röntgen Röntgen { get; set; } = new Röntgen();      
        public Rezeption Rezeption { get; set; } = new Rezeption ();
    }
}

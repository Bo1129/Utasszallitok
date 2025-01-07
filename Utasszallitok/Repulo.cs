using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utasszallitok
{
    internal class Repulo
    {
        public string tipus { get; set; }
        public string ev { get; set; }
        public string utas { get; set; }
        public int szemelyzet { get; set; }
        public int utazosebesseg { get; set; }
        public int felszallotomeg { get; set; }
        public int fesztav { get; set; }
        public Repulo(string sor)
        {
            string[] s = sor.Split(';');
            tipus = s[0];
            ev = s[1];
            utas = s[2];
            szemelyzet = int.Parse(s[3]);
            utazosebesseg = int.Parse(s[4]);
            felszallotomeg = int.Parse(s[5]);
            fesztav = int.Parse(s[6]);
        }
    }
}

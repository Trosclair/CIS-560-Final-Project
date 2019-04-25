using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_560_Final_Project
{
    public class Ailment
    {
        public int AilmentId { get; }
        public string Name { get; }
        public string Symptoms { get; }

        internal Ailment(int ailmentId, string name, string symptoms)
        {
            AilmentId = ailmentId;
            Name = name;
            Symptoms = symptoms;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_560_Final_Project
{
    public class Vet
    {
        public int VetId { get; }
        public int VisitId { get; }
        public string Name { get; }

        internal Vet(int vetId, int visitId, string name)
        {
            VetId = vetId;
            VisitId = visitId;
            Name = name;
        }
    }
}

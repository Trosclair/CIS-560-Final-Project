using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_560_Final_Project
{
    public class Visit
    {
        public int VisitId { get; }
        public int PetId { get; }
        public int VetId { get; }
        public DateTime VisitedOn { get; }
        public float Weight { get; }

        internal Visit(int visitId, int petId, int vetId, DateTime visitedOn, float weight)
        {
            VisitId = visitId;
            PetId = petId;
            VetId = vetId;
            VisitedOn = visitedOn;
            Weight = weight;
        }
    }
}

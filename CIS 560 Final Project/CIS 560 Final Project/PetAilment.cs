using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_560_Final_Project
{
    public class PetAilment
    {
        public int PetAilmentId { get; }
        public int AilmentId { get; }
        public int PetId { get; }
        public bool IsActive { get; }

        internal PetAilment(int petAilmentId, int ailmentId, int petId, bool isActive)
        {
            PetAilmentId = petAilmentId;
            AilmentId = ailmentId;
            PetId = petId;
            IsActive = isActive;
        }
    }
}

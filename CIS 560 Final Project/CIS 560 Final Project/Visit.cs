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

/*public class Address
   {
      public int PersonId { get; }
      public AddressType AddressType { get; }
      public string Line1 { get; }
      public string Line2 { get; }
      public string City { get; }
      public string StateCode { get; }
      public string ZipCode { get; }
      
      internal Address(int personId, AddressType addressType,
         string line1, string line2, string city, string stateCode, string zipCode)
      {
         PersonId = personId;
         AddressType = addressType;
         Line1 = line1;
         Line2 = line2 ?? string.Empty;
         City = city;
         StateCode = stateCode;
         ZipCode = zipCode;
      }
   }*/


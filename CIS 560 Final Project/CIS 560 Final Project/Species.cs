using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_560_Final_Project
{
    public class Species
    {
        public int SpeciesId { get; }
        public string Breed { get; }

        internal Species(int speciesId, string breed)
        {
            SpeciesId = speciesId;
            Breed = breed;
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

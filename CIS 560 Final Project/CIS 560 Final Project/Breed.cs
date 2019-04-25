using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_560_Final_Project
{
    public class Breed
    {
        public int BreedId { get; }
        public string Species { get; }

        internal Breed(int breedId, string species)
        {
            BreedId = breedId;
            Species = species;
        }
    }
}
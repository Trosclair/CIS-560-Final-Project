using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_560_Final_Project
{
    public class Pet
    {
        public int PetId { get; }
        public int OwnerId { get; }
        public int BreedId { get; }
        public string FirstName { get; }
        public DateTime Birthdate { get; }

        internal Pet(int petId, int ownerId, int breedId, string firstName, DateTime birthDate)
        {
            PetId = petId;
            OwnerId = ownerId;
            BreedId = breedId;
            FirstName = firstName;
            Birthdate = birthDate;
        }
    }
}
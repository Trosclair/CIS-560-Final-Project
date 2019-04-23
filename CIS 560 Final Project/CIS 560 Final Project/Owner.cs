using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_560_Final_Project
{
    public class Owner
    {
        public int OwnerId { get; }
        public int ClinicId { get; }
        public string PhoneNumber { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public int HappinessPercent { get; }

        internal Owner(int ownerId, int clinicId, string phoneNumber, string firstName, string lastName, int happinessPercent)
        {
            OwnerId = ownerId;
            ClinicId = clinicId;
            PhoneNumber = phoneNumber;
            FirstName = firstName;
            LastName = lastName;
            HappinessPercent = happinessPercent;
        }
    }
}
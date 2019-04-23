using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_560_Final_Project
{
    public class Clinic
    {
        public int ClinicId { get; }
        public string Name { get; }

        internal Clinic(int clinicId, string name)
        {
            ClinicId = clinicId;
            Name = name;
        }
    }
}

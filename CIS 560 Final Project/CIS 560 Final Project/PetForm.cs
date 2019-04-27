using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_560_Final_Project
{
    public partial class uxPetForm : Form
    {
        private string OwnerPhoneNumber { get; set; }
        public uxPetForm(string ownerPhoneNumber)
        {
            InitializeComponent();
            OwnerPhoneNumber = ownerPhoneNumber;
        }
    }
}

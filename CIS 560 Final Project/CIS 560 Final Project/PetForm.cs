using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_560_Final_Project
{
    public partial class uxPetForm : Form
    {
        private string OwnerPhoneNumber { get; set; }
        private readonly SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4QRV3VKE;Initial Catalog=Clinic;Integrated Security=True;Pooling=False");
        private SqlDataReader rdr = null;
        public uxPetForm(string ownerPhoneNumber)
        {
            InitializeComponent();
            OwnerPhoneNumber = ownerPhoneNumber;
            uxPetListBox.MouseDoubleClick += new MouseEventHandler(uxPetListBox_DoubleClick);
            PopulateListBox();
        }

        private void UxAddOwnerButton_Click(object sender, EventArgs e)
        {
            uxPetContainer.Enabled = true;
        }

        private void PopulateListBox()
        {
            conn.Open();
            List<string> listOfClinics = null;
            try
            {
                listOfClinics = ExecuteQuery("SELECT P.[Name], P.BirthDate FROM Clinic.Pet P INNER JOIN Clinic.Owner O ON O.OwnerId = P.OwnerId WHERE O.PhoneNumber = N'" + OwnerPhoneNumber + "'");
            }
            finally
            {
                CloseConnection();
            }
            uxPetListBox.Items.Clear();
            foreach (string s in listOfClinics)
            {
                uxPetListBox.Items.Add(s);
            }
        }


        private List<string> ExecuteQuery(string query)
        {
            List<string> queryResults = new List<string>();
            SqlCommand cmd = new SqlCommand(query, conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < rdr.FieldCount; i++)
                {
                    sb.Append(rdr[i].ToString());
                    if (i + 1 != rdr.FieldCount) sb.Append(", ");
                }
                queryResults.Add(sb.ToString());
            }
            return queryResults;
        }

        private void CloseConnection()
        {

            if (rdr != null)
            {
                rdr.Close();
            }
            if (conn != null)
            {
                conn.Close();
            }
        }

        private void uxPetListBox_DoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.uxPetListBox.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                uxPetForm petForm = new uxPetForm(uxPetListBox.SelectedItem.ToString().Split(',')[0]);
                new Thread(RunPetForm).Start(petForm);
            }
        }

        static void RunPetForm(Object ob)
        {
            Application.Run((Form)ob);
        }

        private void UxAddButton_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            if (!string.IsNullOrWhiteSpace(uxNameTextBox.Text) && !string.IsNullOrWhiteSpace(uxBreedTextBox.Text) && !string.IsNullOrWhiteSpace(uxBreedTextBox.Text))
            {
                List<string> ListOfSpecies = new List<string>();
                try
                {
                    ListOfSpecies = ExecuteQuery("SELECT S.[Name] FROM Clinic.Species S WHERE S.[Name] = " + uxBreedTextBox.Text.Trim());
                    if (ListOfSpecies.Count == 0) ExecuteQuery("INSERT Clinic.Breed(Species) VALUES(N'" + uxBreedTextBox.Text.Trim() + "')");

                    ExecuteQuery
                        (
                            "INSERT Clinic.Pet(OwnerId, BreedId, [Name], BirthDate)" +
                            "SELECT O.OwnerId, B.BreedId, P.[Name], P.BirthDate" +
                            "FROM" +
                            "    (" +
                            "        VALUES" +
                            "            (N'"+ OwnerPhoneNumber +"', N'"+ uxBreedTextBox.Text.Trim() +"', N'"+ uxNameTextBox.Text.Trim() +"', '"+ CreateDateTime() +"')" +
                            "    ) P(PhoneNumber, Species, [Name], BirthDate)" +
                            "INNER JOIN Clinic.Owner O ON O.PhoneNumber = P.PhoneNumber" +
                            "INNER JOIN Clinic.Breed B ON B.Species = P.Species"
                        );
                }
                finally
                {
                    CloseConnection();
                }
            }
            uxPetContainer.Enabled = false;
            PopulateListBox();
        }

        private string CreateDateTime()
        {
            return uxYearNumericUpDown.ToString() + "-" + uxMonthNumericUpDown.ToString() + "-" + uxDayNumericUpDown.ToString() + " " + uxHourNumericUpDown.ToString() + ":00:00"; 
        }
    }
}

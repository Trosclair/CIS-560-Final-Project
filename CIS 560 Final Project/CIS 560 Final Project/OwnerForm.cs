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
    public partial class uxOwnerForm : Form
    {

        private string Clinic { get; set; }
        private readonly SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4QRV3VKE;Initial Catalog=Clinic;Integrated Security=True;Pooling=False");
        private SqlDataReader rdr = null;

        public uxOwnerForm(string clinic)
        {
            InitializeComponent();
            Clinic = clinic;
            uxOwnerListBox.MouseDoubleClick += new MouseEventHandler(uxOwnerListBox_DoubleClick);
            PopulateListBox();
        }

        private void UxAddOwnerButton_Click(object sender, EventArgs e)
        {
            uxOwnerContainer.Enabled = true;
        }

        private void UxAddButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (!string.IsNullOrWhiteSpace(uxPhoneTextBox.Text) && !string.IsNullOrWhiteSpace(uxFirstName.Text) && !string.IsNullOrWhiteSpace(uxLastNameTextBox.Text))
            {
                try
                {
                    ExecuteQuery
                        (
                        "INSERT Clinic.Owner(ClinicId, PhoneNumber, FirstName, LastName, HappinessPercent)" +
                        "SELECT C.ClinicId, O.PhoneNumber, O.FirstName, O.LastName, O.HappinessPercent" +
                        "FROM" +
	                    "    (" +
		                "       VALUES" +
			            "           (N'"+ Clinic +"', N'"+ uxPhoneTextBox.Text +"', N'"+ uxFirstName.Text +"', N'"+ uxLastNameTextBox.Text +"', "+ uxPercentNumericUpDown.Value.ToString()+")" +
	                    "   ) O([Name], PhoneNumber, FirstName, LastName, HappinessPercent)" +
                        "INNER JOIN Clinic.Clinic C ON C.[Name] = O.[Name]"
                        );
                }
                finally
                {
                    CloseConnection();
                }
            }
            uxOwnerContainer.Enabled = false;
            PopulateListBox();
        }

        private void PopulateListBox()
        {
            conn.Open();
            List<string> listOfClinics = null;
            try
            {
                listOfClinics = ExecuteQuery("SELECT O.PhoneNumber, O.FirstName, O.LastName, O.HappinessPercent FROM Clinic.Owner O INNER JOIN Clinic.Clinic C ON C.ClinicId = O.ClinicId WHERE C.[Name] = N'" + Clinic +"'");
            }
            finally
            {
                CloseConnection();
            }
            uxOwnerListBox.Items.Clear();
            foreach (string s in listOfClinics)
            {
                uxOwnerListBox.Items.Add(s);
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

        private void uxOwnerListBox_DoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.uxOwnerListBox.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                uxPetForm petForm = new uxPetForm(uxOwnerListBox.SelectedItem.ToString().Split(',')[0]);
                new Thread(RunPetForm).Start(petForm);
            }
        }

        static void RunPetForm(Object ob)
        {
            Application.Run((Form)ob);
        }
    }
}

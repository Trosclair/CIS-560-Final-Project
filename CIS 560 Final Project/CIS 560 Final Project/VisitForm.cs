using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_560_Final_Project
{
    public partial class uxVisitForm : Form
    {
        private string PetName { get; set; }
        private readonly SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4QRV3VKE;Initial Catalog=Clinic;Integrated Security=True;Pooling=False");
        private SqlDataReader rdr = null;

        public uxVisitForm(string petName)
        {
            InitializeComponent();
            PetName = petName;
            uxAilmentNameListBox.MouseDoubleClick += new MouseEventHandler(uxAilmentNameListBox_DoubleClick);
            uxIsActiveRadio.MouseClick += new MouseEventHandler(UxIsActiveRadio_Click);
            PopulateListBox();
            List<string> listOfAilments = new List<string>();
            conn.Open();
            try
            {
                listOfAilments = ExecuteQuery("SELECT A.[Name] FROM Clinic.Ailment A");
            }
            finally
            {
                CloseConnection();
            }
            uxAilmentNameListBox.Items.Clear();
            foreach (string s in listOfAilments)
            {
                uxAilmentNameListBox.Items.Add(s);
            }
        }

        private void PopulateListBox()
        {
            conn.Open();
            List<string> listOfVisits = null;
            try
            {
                listOfVisits = ExecuteQuery("SELECT V.VisitedOn, V.Weight, VET.[Name], A.[Name], PA.IsActive FROM Clinic.Visit V INNER JOIN Clinic.Vet VET ON VET.VetId = V.VetId INNER JOIN Clinic.PetAilment PA ON PA.PetId = V.PetId INNER JOIN Clinic.Ailment A ON A.AilmentId = PA.AilmentId INNER JOIN Clinic.Pet P ON P.PetId = V.PetId WHERE P.[Name] = N'"+ PetName +"'");
            }
            finally
            {
                CloseConnection();
            }
            uxVisitListBox.Items.Clear();
            uxVisitListBox.Items.Add("VISITED ON, WEIGHT, VET NAME, AILMENT NAME, AILMENT ACTIVE");
            foreach (string s in listOfVisits)
            {
                uxVisitListBox.Items.Add(s);
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

        private void uxAilmentNameListBox_DoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.uxAilmentNameListBox.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                uxAilmentNameTextBox.Text = uxAilmentNameListBox.SelectedItem.ToString().Trim();
            }
        }

        private void UxAddVisitButton_Click(object sender, EventArgs e)
        {
            uxVisitContainer.Enabled = true;
        }

        private void UxAddButton_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            if (!string.IsNullOrWhiteSpace(uxNameTextBox.Text) && !string.IsNullOrWhiteSpace(uxAilmentNameTextBox.Text))
            {
                List<string> listOfAilments = new List<string>();
                try
                {
                    int bit = uxIsActiveRadio.Checked ? 1 : 0;
                    
                    ExecuteQuery
                        (
                            "INSERT Clinic.PetAilment(AilmentId, PetId, IsActive) "+
                            "SELECT A.AilmentId, P.PetId, PA.IsActive "+
                            "FROM "+
                            "    ( "+
                            "        VALUES "+
                            "            (N'"+ uxAilmentNameTextBox.Text +"', N'"+ PetName +"', "+ bit.ToString() +") "+
                            "    ) PA([Name], PetName, IsActive) "+
                            "INNER JOIN Clinic.Ailment A ON A.[Name] = PA.[Name] "+
                            "INNER JOIN Clinic.Pet P ON P.[Name] = PA.PetName "
                        );

                    DateTime myDateTime = DateTime.Now;
                    string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                    CloseConnection();
                    conn.Open();

                    listOfAilments = ExecuteQuery("SELECT S.[Name] FROM Clinic.Vet S WHERE S.[Name] = N'" + uxNameTextBox.Text.Trim()+"'");
                    CloseConnection();
                    conn.Open();

                    if (listOfAilments.Count == 0) ExecuteQuery("INSERT Clinic.Vet([Name]) VALUES(N'" + uxNameTextBox.Text.Trim() + "')");
                    CloseConnection();
                    conn.Open();

                    ExecuteQuery
                        (
                            "INSERT Clinic.Visit(VetId, PetId, VisitedOn, [Weight]) "+
                            "SELECT VET.VetId, P.PetId, CV.VisitedOn, CV.[Weight] "+
                            "FROM "+
                            "    ( "+
                            "        VALUES "+
                            "            (N'"+ uxNameTextBox.Text +"', N'"+ PetName +"', '"+ sqlFormattedDate +"', "+ uxWeightNumericUpDown.Value.ToString() +") "+
                            "    ) CV([Name], PetName, VisitedOn, [Weight]) "+
                            "INNER JOIN Clinic.Vet VET ON VET.[Name] = CV.[Name] "+
                            "INNER JOIN Clinic.Pet P ON P.[Name] = CV.PetName "
                        );
                }
                finally
                {
                    CloseConnection();
                }
            }
            uxVisitContainer.Enabled = false;
            PopulateListBox();
        }

        bool isChecked = false;

        private void UxIsActiveRadio_Click(object sender, EventArgs e)
        {
            if (uxIsActiveRadio.Checked && !isChecked)
                uxIsActiveRadio.Checked = false;
            else
            {
                uxIsActiveRadio.Checked = true;
                isChecked = false;
            }
        }

        private void UxIsActiveRadio_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = uxIsActiveRadio.Checked;
        }
    }
}

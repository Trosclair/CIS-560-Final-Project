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
    public partial class uxClinicForm : Form
    {
        private readonly SqlConnection conn = new SqlConnection("Data Source=LAPTOP-4QRV3VKE;Initial Catalog=Clinic;Integrated Security=True;Pooling=False");
        private SqlDataReader rdr = null;

        public uxClinicForm()
        {
            InitializeComponent();
            uxClinicListBox.MouseDoubleClick += new MouseEventHandler(uxClinicListBox_DoubleClick);
            PopulateListBox();
        }

        private void UxAddClinicButton_Click(object sender, EventArgs e)
        {
            uxClinicContainer.Enabled = true;
        }

        private void UxAddButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (!string.IsNullOrWhiteSpace(uxClinicTextBox.Text))
            {
                try
                {
                    ExecuteQuery("INSERT Clinic.Clinic([Name]) VALUES(N'" + uxClinicTextBox.Text + "')");
                }
                finally
                {
                    CloseConnection();
                }
            }
            uxClinicContainer.Enabled = false;
            PopulateListBox();
        }

        private void PopulateListBox()
        {
            conn.Open();
            List<string> listOfClinics = null;
            try
            {
                listOfClinics = ExecuteQuery("SELECT C.[Name] FROM Clinic.Clinic C");
            }
            finally
            {
                CloseConnection();
            }
            uxClinicListBox.Items.Clear();
            foreach (string s in listOfClinics)
            {
                uxClinicListBox.Items.Add(s);
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

        private void uxClinicListBox_DoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.uxClinicListBox.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                MessageBox.Show(uxClinicListBox.SelectedItem.ToString()); ///////////////////////////// THIS WILL LAUNCH ANOTHER FORM THAT CONTINUES THE PROGRAM SO EDIT DIS
            }
        }
    }
}

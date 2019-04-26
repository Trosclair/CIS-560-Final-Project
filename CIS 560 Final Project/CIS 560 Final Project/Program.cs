using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_560_Final_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new uxClinicForm());
            SQLTest();
        }
        public static void SQLTest()
        {
            SqlConnection conn = new SqlConnection(
             "Data Source=LAPTOP-4QRV3VKE;Initial Catalog=Clinic;Integrated Security=True;Pooling=False");

            SqlDataReader rdr = null;

            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                SqlCommand cmd = new SqlCommand("SELECT P.[Name] FROM Clinic.Clinic P", conn);

                //
                // 4. Use the connection
                //

                // get query results
                rdr = cmd.ExecuteReader();

                // print the CustomerID of each record
                while (rdr.Read())
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < rdr.FieldCount; i++)
                    {
                        sb.Append(rdr[i].ToString());
                        if (i + 1 != rdr.FieldCount) sb.Append(", ");
                    }
                    MessageBox.Show(sb.ToString());
                }
            }
            finally
            {
                // close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                // 5. Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }


}
// Data Source=LAPTOP-4QRV3VKE;Initial Catalog=Clinic;Integrated Security=True;Pooling=False


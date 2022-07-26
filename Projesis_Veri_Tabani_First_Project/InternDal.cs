using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projesis_Veri_Tabani_First_Project
{
    public class InternDal
    {
        public DataTable GetAll()
        {
            SqlConnection sqlConnection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=Internship;integrated security=true");

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            SqlCommand sqlCommand = new SqlCommand("Select * from Intern", sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            sqlDataReader.Close();
            sqlConnection.Close();

            return dataTable;
        }
    }
}

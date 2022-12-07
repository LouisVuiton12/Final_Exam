using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_exam_ver2
{
    public class Connection
    {
        public static SqlConnection connection = null;

        public void CreateConnection()
        {
            connection = new SqlConnection("Data Source=QUOC-AN\\SQLEXPRESS;Initial Catalog=Functional_Foods;Integrated Security=True");
            connection.Open();
        }
    }
}

using System.Data;
using System.Data.SqlClient;

namespace Libary
{
    class DB
    {
        SqlConnection con;
        SqlCommand comnd;
        SqlDataAdapter da;
        DataTable dt;

        public DB()
        {
            con = new SqlConnection();
            comnd = new SqlCommand();
            da = new SqlDataAdapter();
            comnd.Connection = con;
            da.SelectCommand = comnd;
        }


        public void connect()
        {
            con.ConnectionString = "Data Source=.;Initial Catalog=Libary;Integrated Security=True";
            con.Open();
        }


        public void disconnect()
        {
            con.Close();
        }

        public DataTable Searchdb(string qy)
        {
            comnd.CommandText = qy;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void Perform(string qy)
        {
            comnd.CommandText = qy;
            comnd.ExecuteNonQuery();
        }
    }
}

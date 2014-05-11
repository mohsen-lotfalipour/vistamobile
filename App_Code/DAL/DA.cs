using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vistamobile.DAL
{
    public class DA
    {
        static SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\DB\mobile_hardware.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlDataAdapter da = new SqlDataAdapter("", con);
        DataSet ds = new DataSet();
        public DataSet db_ExecuteQuery(String CMD)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(CMD, con);
            con.Open();
            da.Fill(ds);
            con.Close();
            return ds;
        }

        public bool db_ExecuteNonQuery(string q)
        {
            SqlCommand cmd = new SqlCommand(q, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }


    }
}

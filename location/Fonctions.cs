using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace location
{
    internal class Fonctions
    {
        private SqlConnection Con;
        private SqlCommand cmd;
        private DataTable dt;
        private string ConStr;
        private SqlDataAdapter sda ;

        public Fonctions()
        {
            ConStr = @"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\Documents\\locationdb.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(ConStr);
            cmd = new SqlCommand();
            cmd.Connection = Con;

        } 
        public DataTable RecupererData(string Req)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Req, ConStr);
       

            return dt;

        }
        public int EnvoyerData(string Req)
        {
            int cnt = 0;
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            cmd.CommandText = Req;
            cnt = cmd.ExecuteNonQuery();
            Con.Close();
            return cnt;
        }
    }
}

using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class ResultExport
    {
        ResultExport(string login,string password, string dataS)
        {
            this.login = login;
            this.password = password;
            this.dataSource = dataS;
            constr =
            "User Id=" + this.login + ";" +
            "Password=" + this.password + ";" +
            "Data Source=" + this.dataSource;
            this.con = new OracleConnection(constr);
        }
        string login;
        string password;
        string dataSource;
        OracleConnection con;
        string constr;
        public bool ConnectToDB()
        {
            con.ConnectionString = constr;
            con.Open();
            return true;
        }
        public bool Export(int count,Result[] r)
        {
            DataTable dt = new DataTable();
            for (int i = 0; i < count; i++)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = r[i].getId();
                dr["NAME"] = r[i].getSignClass();
                dr["Data"] = r[i].getDate();
                dr["Long"] = r[i].getLongitude();
                dr["Lat"] = r[i].getLattitude();
                dt.Rows.Add(dr);
            }
            //
            try
            {
                using (var connection = new OracleConnection(con.ConnectionString))
                {
                    connection.Open();
                    int[] ids = new int[dt.Rows.Count];
                    string[] names = new string[dt.Rows.Count];
                    string[] date = new string[dt.Rows.Count];

                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        ids[j] = Convert.ToInt32(dt.Rows[j]["ID"]);
                        names[j] = Convert.ToString(dt.Rows[j]["NAME"]);
                        date[j] = Convert.ToString(dt.Rows[j]["ADDRESS"]);
                    }

                    OracleParameter id = new OracleParameter();
                    id.OracleDbType = OracleDbType.Int32;
                    id.Value = ids;

                    OracleParameter name = new OracleParameter();
                    name.OracleDbType = OracleDbType.Varchar2;
                    name.Value = names;

                    OracleParameter address = new OracleParameter();
                    address.OracleDbType = OracleDbType.Varchar2;
                    address.Value = date;

                    // create command and set properties  
                    OracleCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "INSERT INTO BULKINSERTTEST (ID, NAME, ADDRESS) VALUES (:1, :2, :3)";
                    cmd.ArrayBindCount = ids.Length;
                    cmd.Parameters.Add(id);
                    cmd.Parameters.Add(name);
                    cmd.Parameters.Add(address);
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //

            return false;
        }
        public bool Find()
        {
            return false;
        }
        public bool CloseConnection()
        {
            con.Close();
            con.Dispose();
            return true;
        }
    }
}
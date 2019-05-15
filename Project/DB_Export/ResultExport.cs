using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
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
        public bool Export()
        {
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
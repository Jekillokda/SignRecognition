using Oracle.ManagedDataAccess.Client;
using Project.MediaFolders;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project
{
     class ResultExport
    {
        public ResultExport(string login,string password, string dataS, string fpath)
        {
            this.login = login;
            this.password = password;
            this.dataSource = dataS;
            constr =
            "User Id=" + this.login + ";" +
            "Password=" + this.password + ";" +
            "Data Source=" + this.dataSource;
            this.con = new OracleConnection(constr);
            formatter = new XmlSerializer(typeof(Result[]));
            folderpath = fpath;
            xmlFolder = new XmlFolder();
        }
        string login;
        string password;
        string dataSource;
        string folderpath;
        XmlFolder xmlFolder;
        XmlSerializer formatter;
        OracleConnection con;
        Result[] results;
        string[] files;
        string constr;
        public bool Connect()
        {
            con.ConnectionString = constr;
            con.Open();
            return true;
        }
        public bool ExporttoDB(string path)
        {
                UploadFromFile(path);
                DataTable dt = new DataTable("Signs");

            DataColumn workCol = dt.Columns.Add("ID", typeof(int));
            workCol.AllowDBNull = false;
            workCol.Unique = true;
            dt.Columns.Add("NAME", typeof(string));
            dt.Columns.Add("DATE", typeof(DateTime));
            dt.Columns.Add("LONG", typeof(string));
            dt.Columns.Add("LAT", typeof(string));
            for (int i = 0; i < results.Length; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["ID"] = results[i].id;
                    dr["NAME"] = results[i].signClass;
                    dr["DATE"] = results[i].date;
                    dr["LONG"] = results[i].longitude;
                    dr["LAT"] = results[i].lattitude;
                    dt.Rows.Add(dr);
                }  
            //
            try
            {
               /* using (var connection = new OracleConnection(con.ConnectionString))
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

                }*/
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return false;
        }
        public bool ExportToFile(Result[] arr)
        {
            var name = "123";
            var filePath = Path.Combine(folderpath, name);
            filePath += ".xml";

            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
            formatter.Serialize(fs, arr);
            }
            return true;
        }

        public bool ExportFolder(string path)
        {
            xmlFolder.Load(path);
            files = xmlFolder.GetAll();
            foreach (string f in files)
            {
                ExporttoDB(f);
            }
                return true;
        }

        public bool UploadFromFile(string path)
        {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    results = (Result[])formatter.Deserialize(fs);

                    foreach (Result r in results)
                    {
                        Console.WriteLine("id: {0} --- Класс: {1}", r.id, r.signClass);
                    }
                    
                }
            return true;
        }
        public bool CloseConnection()
        {
            con.Close();
            con.Dispose();
            return true;
        }
    }
}
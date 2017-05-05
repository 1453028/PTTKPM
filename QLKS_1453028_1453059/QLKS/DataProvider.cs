using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace QLKS
{
    public class DataProvider
    {
        protected static string connectionString;

        protected OleDbConnection connection;
        protected OleDbDataAdapter adapter;
        protected OleDbCommand command;


        public static string ConnectionString
        {
            get{ return connectionString; }
            set{ connectionString = value; }
        }

        public void connect()
        {
            connection = new OleDbConnection(ConnectionString);
            connection.Open();
        }

        public void disconnect()
        {
            connection.Close();
        }

        public IDataReader executeQuery(string sqlString)
        {
            command = new OleDbCommand(sqlString, connection);
            return command.ExecuteReader();
        }

        public void executeNonQuery(string sqlString)
        {
            command = new OleDbCommand(sqlString, connection);
            command.ExecuteNonQuery();
        }

        public DataTable executeQueryToTable(string sqlString)
        {
            DataSet ds = new DataSet();
            adapter = new OleDbDataAdapter(sqlString, connection);
            adapter.Fill(ds);
            return ds.Tables[0];
        }
    }
}

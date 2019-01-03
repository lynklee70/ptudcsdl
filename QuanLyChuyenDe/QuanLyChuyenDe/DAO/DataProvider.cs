using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenDe.DAO
{
    class DataProvider
    {
        private static DataProvider instance; // Ctrl + R + E

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        SqlConnection Connection { get; set; }
        static string ConnectionString;
        //Open Connect
        public DataProvider()
        {
            ConnectionString = @"SERVER = DESKTOP-6Q96NN3\SQLEXPRESS; Database=DangKyChuyenDe1; Trusted_Connection=True;";

            Connection = new SqlConnection(ConnectionString);
        }
        //start open Connect
        public void Connect()
        {
            try
            {
                if (Connection == null)
                {
                    Connection = new SqlConnection(ConnectionString);
                }
                if (Connection.State != ConnectionState.Closed)
                {
                    Connection.Close();
                }
                Connection.Open();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        //End: Close connect
        public void Disconnect()
        {
            if (Connection != null && Connection.State == ConnectionState.Open)
                Connection.Close();
        }
        //Insert,Update,Delete
        //tra ve number,row or effects
        public int ExecuteNonQuery(CommandType cmdType, string strSql)
        {
            try
            {
                SqlCommand command = Connection.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmdType;

                int nRow = command.ExecuteNonQuery();
                return nRow;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        //Insert,Update,Delete
        //tra ve number,row or effects
        public int ExecuteNonQuery(CommandType cmdType, string strSql, params SqlParameter[] parameters)
        {
            try
            {
                SqlCommand command = Connection.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmdType;
                if (parameters != null && parameters.Length > 0)
                {
                    command.Parameters.AddRange(parameters);
                }
                int nRow = command.ExecuteNonQuery();
                return nRow;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        //select tra ve sqlDataReader
        public SqlDataReader GetReader(CommandType cmdType, string strSql)
        {
            try
            {
                SqlCommand command = Connection.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmdType;

                return command.ExecuteReader();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        //select tra ve datatable
        public DataTable Select(CommandType cmdType, string strSql, params SqlParameter[] parameters)
        {
            try
            {
                SqlCommand command = Connection.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmdType;
                if (parameters != null && parameters.Length > 0)
                {
                    command.Parameters.AddRange(parameters);
                }

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable db = new DataTable();
                da.Fill(db);
                return db;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}

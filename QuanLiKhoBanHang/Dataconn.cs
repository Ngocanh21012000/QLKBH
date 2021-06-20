
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data.Common;
using System.IO;
using System.Net.NetworkInformation;


namespace QuanLiKhoBanHang
{
    class Dataconn
    {
        public static string source;
        public static SqlConnection con = new SqlConnection();

        static Dataconn()
          
        {
            source = @"Data Source=DESKTOP-3PP3KKO;Initial Catalog=QLKBH_HK;Integrated Security=True";
            con = new SqlConnection(source);
            if (con.State == ConnectionState.Open)
            {
                con.Open();
            }
            else if (con.State == ConnectionState.Closed)
            {
                con.Close();
            }
        }
        public static void open()
        {
            try
            {
                con.Open();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Dispose();
            }
        }
        public static DataTable DataTable_Sql(string sql)
        {
            //try
            //{
            using (SqlConnection conn = new SqlConnection(source))
            {
                DataTable ds = new DataTable();
                SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
                dap.Fill(ds);
                conn.Close();
                conn.Dispose();
                return ds;
               
            }
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message);
            //}
        }

        public static int Execute_NonSQL(string sql)
        {
            SqlConnection conn = new SqlConnection(source);
            SqlCommand cmd = new SqlCommand(sql, conn);
            int row = 0;
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            row = cmd.ExecuteNonQuery();
            conn.Dispose();
            conn.Close();
            return row;
        }
        public static DataTable StoreFillDS(string StoreName, CommandType type, params object[] obj)
        {
            SqlConnection conn = new SqlConnection(source);
            conn.Open();
            SqlCommand cmd = new SqlCommand(StoreName, conn);
            cmd.CommandType = type;
            SqlCommandBuilder.DeriveParameters(cmd);

            for (int i = 1; i <= obj.Length; i++)
            {
                cmd.Parameters[i].Value = obj[i - 1];
            }
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            conn.Dispose();
            conn.Close();
            return ds.Tables[0];

        }
        public static int ExecuteStore(string query_object, CommandType type, params object[] obj)
        {
            int row = 0;
            SqlConnection conn = new SqlConnection(source);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query_object, conn);
            cmd.CommandType = type;
            SqlCommandBuilder.DeriveParameters(cmd);
            for (int i = 1; i <= obj.Length; i++)
            {
                cmd.Parameters[i].Value = obj[i - 1];
            }
            cmd.ExecuteNonQuery();
            conn.Dispose();
            conn.Close();
            return row;
        }

        // Hàm GetFieldValues, có tác dụng lấy dữ liệu từ một câu lệnh SQL
        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlConnection conn = new SqlConnection(source);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }


        //Lấy dữ liệu vào bảng
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter MyData = new SqlDataAdapter(); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            //Tạo đối tượng thuộc lớp SqlCommand
            MyData.SelectCommand = new SqlCommand();
            MyData.SelectCommand.Connection = Dataconn.con; //Kết nối cơ sở dữ liệu
            MyData.SelectCommand.CommandText = sql; //Lệnh SQL
            //Khai báo đối tượng table thuộc lớp DataTable
            DataTable table = new DataTable();
            MyData.Fill(table);
            return table;
        }

      
    }
}

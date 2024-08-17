using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_Minimarket.Entities;

namespace System_Minimarket.Data
{
    public class D_Users
    {
        public DataTable Listing_us(string cText)
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Connection.getInstance().CreateConection();
                SqlCommand Command = new SqlCommand("P_Listing_us", SQLCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@cText", SqlDbType.VarChar).Value = cText;
                SQLCon.Open();
                Result = Command.ExecuteReader();
                Table.Load(Result);
                return Table;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close();
            }
        }

        public string Save_us(int nOption, E_Users oUs)
        {
            string Rpt = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstance().CreateConection();
                SqlCommand Command = new SqlCommand("P_Save_us", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@nOption", SqlDbType.Int).Value = nOption;
                Command.Parameters.Add("@nId_us", SqlDbType.Int).Value = oUs.Id_us;
                Command.Parameters.Add("@cLogin_us", SqlDbType.VarChar).Value = oUs.Login_us;
                Command.Parameters.Add("@cPassword_us", SqlDbType.VarChar).Value = oUs.Password_us;
                Command.Parameters.Add("@cNames_us", SqlDbType.VarChar).Value = oUs.Names_us;
                Command.Parameters.Add("@cLocation_us", SqlDbType.VarChar).Value = oUs.Location_us;
                Command.Parameters.Add("@bAdmin", SqlDbType.Bit).Value = oUs.Admin;
                SqlCon.Open();
                Rpt = Command.ExecuteNonQuery() == 1 ? "OK" : "Could not delete data";
            }
            catch (Exception ex)
            {

                Rpt = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpt;
        }

        public string Delete_us(int Id_us)
        {
            string Rpt = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstance().CreateConection();
                SqlCommand Command = new SqlCommand("P_Delete_us", SqlCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@nId_us", SqlDbType.Int).Value = Id_us;
                SqlCon.Open();
                Rpt = Command.ExecuteNonQuery() == 1 ? "OK" : "Could not delete data";
            }
            catch (Exception ex)
            {

                Rpt = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpt;
        }

        public DataTable Login_us(string cLogin, string cPassword)
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Connection.getInstance().CreateConection();
                SqlCommand Command = new SqlCommand("P_Login_us", SQLCon);
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.Add("@cLogin_us", SqlDbType.VarChar).Value = cLogin;
                Command.Parameters.Add("@cPassword_us", SqlDbType.VarChar).Value = cPassword;
                SQLCon.Open();
                Result = Command.ExecuteReader();
                Table.Load(Result);
                return Table;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close();
            }
        }
    }
}

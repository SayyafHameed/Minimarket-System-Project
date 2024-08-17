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
    public class D_Suppliers
    {
        public DataTable Listing_su(string cText)
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Connection.getInstance().CreateConection();
                SqlCommand Comand = new SqlCommand("P_Listing_su", SQLCon);
                Comand.CommandType = CommandType.StoredProcedure;
                Comand.Parameters.Add("@cText", SqlDbType.VarChar).Value = cText;
                SQLCon.Open();
                Result = Comand.ExecuteReader();
                Table.Load(Result);
                return Table;
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching data: " + ex.Message);
            }
            finally
            {
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close();
            }
        }

        public string Save_su(int nOption, E_Suppliers oSu)
        {
            string Messg = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstance().CreateConection();
                SqlCommand Comand = new SqlCommand("P_Save_su", SqlCon);
                Comand.CommandType = CommandType.StoredProcedure;
                Comand.Parameters.Add("@nOption", SqlDbType.Int).Value = nOption;
                Comand.Parameters.Add("@nId_su", SqlDbType.Int).Value = oSu.Id_su;
                Comand.Parameters.Add("@nId_tdsc", SqlDbType.Int).Value = oSu.Id_tdsc;
                Comand.Parameters.Add("@cNoDocument_su", SqlDbType.VarChar).Value = oSu.NoDocument_su;
                Comand.Parameters.Add("@cCompanyName_su", SqlDbType.VarChar).Value = oSu.CompanyName_su;
                Comand.Parameters.Add("@cNumbers", SqlDbType.VarChar).Value = oSu.Numbers;
                Comand.Parameters.Add("@cSurNames", SqlDbType.VarChar).Value = oSu.SurNames;
                Comand.Parameters.Add("@nId_ge", SqlDbType.Int).Value = oSu.Id_ge;
                Comand.Parameters.Add("@nId_it", SqlDbType.Int).Value = oSu.Id_it;
                Comand.Parameters.Add("@cEmail_su", SqlDbType.VarChar).Value = oSu.Email_su;
                Comand.Parameters.Add("@cPhone_su", SqlDbType.VarChar).Value = oSu.Phone_su;
                Comand.Parameters.Add("@cMobile_su", SqlDbType.VarChar).Value = oSu.Mobile_su;
                Comand.Parameters.Add("@cAddress_su", SqlDbType.Text).Value = oSu.Address_su;
                Comand.Parameters.Add("@nId_di", SqlDbType.Int).Value = oSu.Id_di;
                Comand.Parameters.Add("@cObservation_su", SqlDbType.Text).Value = oSu.Observation_su;

                SqlCon.Open();
                Messg = Comand.ExecuteNonQuery() >= 1 ? "OK" : "Data could not be recorded";
            }
            catch (Exception ex)
            {

                Messg = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Messg;
        }

        public string Delete_su(int Id_su)
        {
            string Messg = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstance().CreateConection();
                SqlCommand Comand = new SqlCommand("P_Delete_su", SqlCon);
                Comand.CommandType = CommandType.StoredProcedure;
                Comand.Parameters.Add("@nId_su", SqlDbType.Int).Value = Id_su;
                SqlCon.Open();
                Messg = Comand.ExecuteNonQuery() == 1 ? "OK" : "Could not delete data";
            }
            catch (Exception ex)
            {

                Messg = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Messg;
        }

        public DataTable Listing_tdsc()
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Connection.getInstance().CreateConection();
                SqlCommand Comand = new SqlCommand("P_Listing_tdsc", SQLCon);
                Comand.CommandType = CommandType.StoredProcedure;
                SQLCon.Open();
                Result = Comand.ExecuteReader();
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

        public DataTable Listing_ge()
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Connection.getInstance().CreateConection();
                SqlCommand Comand = new SqlCommand("P_Listing_ge", SQLCon);
                Comand.CommandType = CommandType.StoredProcedure;
                SQLCon.Open();
                Result = Comand.ExecuteReader();
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

        public DataTable Listing_it_su(string cText)
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Connection.getInstance().CreateConection();
                SqlCommand Comand = new SqlCommand("P_Listing_it_su", SQLCon);
                Comand.CommandType = CommandType.StoredProcedure;
                Comand.Parameters.Add("@cText", SqlDbType.VarChar).Value = cText;
                SQLCon.Open();
                Result = Comand.ExecuteReader();
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

        public DataTable Listing_di_su(string cText)
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Connection.getInstance().CreateConection();
                SqlCommand Comand = new SqlCommand("P_Listing_di_su", SQLCon);
                Comand.CommandType = CommandType.StoredProcedure;
                Comand.Parameters.Add("@cText", SqlDbType.VarChar).Value = cText;
                SQLCon.Open();
                Result = Comand.ExecuteReader();
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

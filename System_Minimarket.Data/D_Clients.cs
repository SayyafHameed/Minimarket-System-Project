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
    public class D_Clients
    {
        public DataTable Listing_cl(string cText)
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Connection.getInstance().CreateConection();
                SqlCommand Comand = new SqlCommand("P_Listing_cl", SQLCon);
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

        public string Save_cl(int nOption, E_Clients oClient)
        {
            string Messg = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstance().CreateConection();
                SqlCommand Comand = new SqlCommand("P_Save_cl", SqlCon);
                Comand.CommandType = CommandType.StoredProcedure;
                Comand.Parameters.Add("@nOption", SqlDbType.Int).Value = nOption;
                Comand.Parameters.Add("@nId_cl", SqlDbType.Int).Value = oClient.Id_cl;
                Comand.Parameters.Add("@nId_tdsc", SqlDbType.Int).Value = oClient.Id_tdsc;
                Comand.Parameters.Add("@cNoDocument_cl", SqlDbType.VarChar).Value = oClient.NoDocument_cl;
                Comand.Parameters.Add("@cCompanyName_cl", SqlDbType.VarChar).Value = oClient.CompanyName_cl;
                Comand.Parameters.Add("@cNumbers", SqlDbType.VarChar).Value = oClient.Numbers;
                Comand.Parameters.Add("@cSurNames", SqlDbType.VarChar).Value = oClient.SurNames;
                Comand.Parameters.Add("@nId_ge", SqlDbType.Int).Value = oClient.Id_ge;
                Comand.Parameters.Add("@nId_it", SqlDbType.Int).Value = oClient.Id_it;
                Comand.Parameters.Add("@cEmail_cl", SqlDbType.VarChar).Value = oClient.Email_cl;
                Comand.Parameters.Add("@cPhone_cl", SqlDbType.VarChar).Value = oClient.Phone_cl;
                Comand.Parameters.Add("@cMobile_cl", SqlDbType.VarChar).Value = oClient.Mobile_cl;
                Comand.Parameters.Add("@cAddress_cl", SqlDbType.Text).Value = oClient.Address_cl;
                Comand.Parameters.Add("@nId_di", SqlDbType.Int).Value = oClient.Id_di;
                Comand.Parameters.Add("@cObservation_cl", SqlDbType.Text).Value = oClient.Observation_cl;

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

        public string Delete_cl(int Id_cl)
        {
            string Messg = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstance().CreateConection();
                SqlCommand Comand = new SqlCommand("P_Delete_cl", SqlCon);
                Comand.CommandType = CommandType.StoredProcedure;
                Comand.Parameters.Add("@nId_cl", SqlDbType.Int).Value = Id_cl;
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

        public DataTable Listing_it_cl(string cText)
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

        public DataTable Listing_di_cl(string cText)
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

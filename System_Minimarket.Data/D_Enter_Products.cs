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
    public class D_Enter_Products
    {
        public DataTable Listing_ep(string cText)
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Connection.getInstance().CreateConection();
                SqlCommand Comand = new SqlCommand("P_Listing_ep", SQLCon);
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

        public DataTable Listing_Detail_ep(int nId_ep)
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Connection.getInstance().CreateConection();
                SqlCommand Comand = new SqlCommand("P_Listing_Detail_ep", SQLCon);
                Comand.CommandType = CommandType.StoredProcedure;
                Comand.Parameters.Add("@nId_ep", SqlDbType.VarChar).Value= nId_ep;
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

        public string Save_ep(E_Enter_Products oEp, DataTable dTable)
        {
            string Rpt = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstance().CreateConection();
                SqlCommand Comand = new SqlCommand("P_Save_ep", SqlCon);
                Comand.CommandType = CommandType.StoredProcedure;
                Comand.Parameters.Add("@nId_tdi", SqlDbType.Int).Value = oEp.Id_tdi;
                Comand.Parameters.Add("@cNoDocument_ep", SqlDbType.VarChar).Value = oEp.noDocument_ep;
                Comand.Parameters.Add("@nId_su", SqlDbType.Int).Value = oEp.Id_su;
                Comand.Parameters.Add("@dDate_ep", SqlDbType.Date).Value = oEp.Data_ep;
                Comand.Parameters.Add("@nId_st", SqlDbType.Int).Value = oEp.Id_st;
                Comand.Parameters.Add("@cObservation", SqlDbType.Text).Value = oEp.Observation;
                Comand.Parameters.Add("@nSubtotal", SqlDbType.Decimal).Value = oEp.Subtotal;
                Comand.Parameters.Add("@nIgv", SqlDbType.Decimal).Value = oEp.igv;
                Comand.Parameters.Add("@nTotal_amount", SqlDbType.Decimal).Value = oEp.total_amount;
                Comand.Parameters.Add("@tDetail", SqlDbType.Structured).Value = dTable;

                SqlCon.Open();
                Rpt = Comand.ExecuteNonQuery() >= 1 ? "OK" : "Data could not be recorded";
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

        public string Delete_ep(int Id_ep)
        {
            string Messg = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstance().CreateConection();
                SqlCommand Comand = new SqlCommand("P_Delete_ep", SqlCon);
                Comand.CommandType = CommandType.StoredProcedure;
                Comand.Parameters.Add("@nId_ep", SqlDbType.Int).Value = Id_ep;
                SqlCon.Open();
                Messg = Comand.ExecuteNonQuery() >= 1 ? "OK" : "Could not delete data";
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
            

        public DataTable Listing_tdi()
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Connection.getInstance().CreateConection();
                SqlCommand Comand = new SqlCommand("P_Listing_tdi", SQLCon);
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

        public DataTable Listing_st_ep()
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Connection.getInstance().CreateConection();
                SqlCommand Comand = new SqlCommand("P_Listing_st_ep", SQLCon);
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

        public DataTable Listing_su_ep(string cText)
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Connection.getInstance().CreateConection();
                SqlCommand Comand = new SqlCommand("P_Listing_su_ep", SQLCon);
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

        public DataTable Listing_pr_ep(string cText)
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Connection.getInstance().CreateConection();
                SqlCommand Comand = new SqlCommand("P_Listing_pr_ep", SQLCon);
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

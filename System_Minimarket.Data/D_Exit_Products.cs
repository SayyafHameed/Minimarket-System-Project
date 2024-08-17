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
    public class D_Exit_Products
    {
        public DataTable Listing_exp(string cText)
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Connection.getInstance().CreateConection();
                SqlCommand Comand = new SqlCommand("P_Listing_op", SQLCon);
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

        public DataTable Listing_Detail_exp(int nId_ep)
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Connection.getInstance().CreateConection();
                SqlCommand Comand = new SqlCommand("P_Listing_Detail_op", SQLCon);
                Comand.CommandType = CommandType.StoredProcedure;
                Comand.Parameters.Add("@nId_op", SqlDbType.VarChar).Value = nId_ep;
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

        public string Save_exp(E_Exit_Products oEp, DataTable dTable)
        {
            string Rpt = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstance().CreateConection();
                SqlCommand Comand = new SqlCommand("P_Save_op", SqlCon);
                Comand.CommandType = CommandType.StoredProcedure;
                Comand.Parameters.Add("@nId_tdi", SqlDbType.Int).Value = oEp.Id_tdi;
                Comand.Parameters.Add("@cNoDocument_op", SqlDbType.VarChar).Value = oEp.noDocument_ep;
                Comand.Parameters.Add("@nId_cl", SqlDbType.Int).Value = oEp.Id_cl;
                Comand.Parameters.Add("@cNoDocument_cl", SqlDbType.VarChar).Value = oEp.NoDocument_cl;
                Comand.Parameters.Add("@cCompanyName", SqlDbType.VarChar).Value = oEp.CompanyName_cl;
                Comand.Parameters.Add("@dDate_op", SqlDbType.Date).Value = oEp.Data_ep;
                Comand.Parameters.Add("@cObservation", SqlDbType.Text).Value = oEp.Observation;
                Comand.Parameters.Add("@nSubtotal", SqlDbType.Decimal).Value = oEp.Subtotal;
                Comand.Parameters.Add("@nIgv", SqlDbType.Decimal).Value = oEp.igv;
                Comand.Parameters.Add("@nTotal_amount", SqlDbType.Decimal).Value = oEp.total_amount;
                Comand.Parameters.Add("@tDetail", SqlDbType.Structured).Value = dTable;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@nId_op";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                Comand.Parameters.Add(ParId);
                SqlCon.Open();
                Comand.ExecuteNonQuery();
                Rpt = Convert.ToString(ParId.Value);
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

        public string Delete_exp(int Id_ep)
        {
            string Messg = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstance().CreateConection();
                SqlCommand Comand = new SqlCommand("P_Delete_op", SqlCon);
                Comand.CommandType = CommandType.StoredProcedure;
                Comand.Parameters.Add("@nId_op", SqlDbType.Int).Value = Id_ep;
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
        
        public DataTable Listing_cl_exp(string cText)
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Connection.getInstance().CreateConection();
                SqlCommand Comand = new SqlCommand("P_Listing_cl_op", SQLCon);
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

        public DataTable Listing_pr_exp(string cText)
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Connection.getInstance().CreateConection();
                SqlCommand Comand = new SqlCommand("P_Listing_pr_op", SQLCon);
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

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
    public class D_Prands
    {
        public DataTable Listing_pr(string cText)
        {
            SqlDataReader Result;
            DataTable Table = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Connection.getInstance().CreateConection();
                SqlCommand Comand = new SqlCommand("P_Listing_pr", SQLCon);
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

        public string Save_pr(int nOption, E_Prands oPr)
        {
            string Messg = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstance().CreateConection();
                SqlCommand Comand = new SqlCommand("P_Save_pr", SqlCon);
                Comand.CommandType = CommandType.StoredProcedure;
                Comand.Parameters.Add("@nOption", SqlDbType.Int).Value = nOption;
                Comand.Parameters.Add("@nId_pr", SqlDbType.Int).Value = oPr.Id_pr;
                Comand.Parameters.Add("@cDescription_pr", SqlDbType.VarChar).Value = oPr.Description_pr;
                SqlCon.Open();
                Messg = Comand.ExecuteNonQuery() == 1 ? "OK" : "Data could not be recorded";
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

        public string Delete_pr(int Id_pr)
        {
            string Messg = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.getInstance().CreateConection();
                SqlCommand Comand = new SqlCommand("P_Delete_pr", SqlCon);
                Comand.CommandType = CommandType.StoredProcedure;
                Comand.Parameters.Add("@nId_pr", SqlDbType.Int).Value = Id_pr;
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
    }
}

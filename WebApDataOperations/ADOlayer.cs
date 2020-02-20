using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApDataOperations
{
    public class ADOlayer
    {
        string constr = "";
        DataSet ds = new DataSet();

        public ADOlayer()
        {
            constr = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;

        }
        public DataSet GetaStudent(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@sid", id);
                    cmd.CommandText = "PrGetaStudent";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);

                }
            }
            catch(Exception ex)
            {

            }
            return ds;

        }

        public DataSet Getallrecords()
        {
            DataSet ds = new DataSet();
            string selquery = "insert into Student values(125,'bhavana','cse','3-1-2020')";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(selquery, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                }

            }
            catch(Exception Ex)
            {

            }
            return ds;

        }

        public DataSet UpdateStudent(int id, string date)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@SId", id);
                    cmd.Parameters.AddWithValue("@StartDate", date);
                    cmd.CommandText = "UpdateDate";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);
                }


            }
            catch (Exception e)
            {

            }
            return ds;
        }




        public void Insertrow(int id,string name,string course,string startdate)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@sid", id);
                cmd.Parameters.AddWithValue("@sname", name);
                cmd.Parameters.AddWithValue("@Course", course);
                cmd.Parameters.AddWithValue("@StartDate",startdate);
                cmd.CommandText = "InsertRecord";
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                sda.Update(ds);

            }
        }

    }
}
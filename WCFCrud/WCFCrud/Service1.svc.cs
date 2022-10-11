using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFCrud
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);

        public bool DeleteCustomerDetails(CustomerDetails cDetails)
        {
            SqlCommand cmd = new SqlCommand("spDeleteCustomerDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@custid", cDetails.Id);
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public DataSet GetCustomerDetails(CustomerDetails cDetails)
        {
            SqlCommand cmd = new SqlCommand("spReadCustomerDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@custid", cDetails.Id);
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;

        }

        public string InsertCustomerDetails(CustomerDetails cDetails)
        {
            string Status;
            SqlCommand cmd = new SqlCommand("spInsertCustomerDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@first_name", cDetails.FName);
            cmd.Parameters.AddWithValue("@last_name", cDetails.LName);
            cmd.Parameters.AddWithValue("@email", cDetails.Email);
            cmd.Parameters.AddWithValue("@contactnumber", cDetails.ContactNumber);
            cmd.Parameters.AddWithValue("@address", cDetails.Address);
          if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            int result = cmd.ExecuteNonQuery();
            if(result==1)
            {
              Status ="Registered Successfully";

            }
            else
            {
                Status = "Could not be Registered Successfully";

            }

            con.Close();
            return Status;

            
        }

        public string UpdateCustomerDetails(CustomerDetails cDetails)
        {
            string Status;
            SqlCommand cmd = new SqlCommand("spUpdateCustomerDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@custid", cDetails.Id);
            cmd.Parameters.AddWithValue("@first_name", cDetails.FName);
            cmd.Parameters.AddWithValue("@last_name", cDetails.LName);
            cmd.Parameters.AddWithValue("@email", cDetails.Email);
            cmd.Parameters.AddWithValue("@contactnumber", cDetails.ContactNumber);
            cmd.Parameters.AddWithValue("@address", cDetails.Address);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Status =  "Registered Successfully";

            }
            else
            {
                Status =  "Could not be Registered Successfully";

            }

            con.Close();
            return Status;
        }
    }
}

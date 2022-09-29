using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CRUDWebService
{
    public partial class CustomerInfo : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public void DataLoad()
        {
            if (Page.IsPostBack)
            {
                dgViewCustomers.DataBind();
            }
        }

        public void ClearAllData()
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtEmail.Text = "";
            txtContact_Number.Text = "";
            txtAddress.Text = "";
            
           

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                con.Open();
                cmd = new SqlCommand("Insert into Customer(First_Name,Last_Name,Email,Contact_Number,Address)values(@first_name,@last_name,@email,@contact_number,@address)", con);
                cmd.Parameters.AddWithValue("@first_name", txtFName.Text);
                cmd.Parameters.AddWithValue("@last_name", txtLName.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@contact_number", txtContact_Number.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                DataLoad();
                ClearAllData();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                con.Open();
                cmd = new SqlCommand("Update into Customer set First_Name=@first_name,Last_Name=@last_name,Email=@email,Contact_Number=@contact_number,Address@address where Cust_Id=@Cust_Id", con);
                cmd.Parameters.AddWithValue("@first_name", txtFName.Text);
                cmd.Parameters.AddWithValue("@last_name", txtLName.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@contact_number", txtContact_Number.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Cust_Id", lblsID.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                DataLoad();
                ClearAllData();
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                con.Open();
                cmd = new SqlCommand("Delete from Customer where Cust_Id=@Cust_Id", con);
                cmd.Parameters.AddWithValue("@Cust_Id", lblsID.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                DataLoad();
                ClearAllData();
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllData();
        }

        protected void dgViewCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblsID.Text = dgViewCustomers.SelectedRow.Cells[1].Text;
            txtFName.Text = dgViewCustomers.SelectedRow.Cells[2].Text;
            txtLName.Text = dgViewCustomers.SelectedRow.Cells[3].Text;
            txtEmail.Text = dgViewCustomers.SelectedRow.Cells[4].Text;
            txtContact_Number.Text = dgViewCustomers.SelectedRow.Cells[5].Text;
            txtAddress.Text = dgViewCustomers.SelectedRow.Cells[6].Text;
            
            
        }
    }
}
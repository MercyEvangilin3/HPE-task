using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client_WCF_CRUD
{
    public partial class CRUD_WCF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        String cs = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public void DataLoad()
        {
            if(Page.IsPostBack)
            {
                GridView1.DataBind();
            }
        }

        public void ClearAllData()
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtEmail.Text = "";
            txtConNum.Text= "";
            txtaddress.Text = "";
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btn_insert_Click(object sender, EventArgs e)
        {
            using (con =new SqlConnection(cs))
            {
                con.Open();
                cmd = new SqlCommand("spInsertCustomerDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@firstname", txtFName.Text);
                cmd.Parameters.AddWithValue("@last_name", txtLName.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@contactnumber", txtConNum.Text);
                cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                cmd.ExecuteNonQuery();
            }
            
        }

        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            ClearAllData();
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                con.Open();
                cmd = new SqlCommand("spUpdateCustomerDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@first_name", txtFName.Text);
                cmd.Parameters.AddWithValue("@last_name", txtLName.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@contact_number", txtConNum.Text);
                cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                cmd.Parameters.AddWithValue("@custid", lblsID.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                DataLoad();
                ClearAllData();
            }
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                con.Open();
                cmd = new SqlCommand("spDeleteCustomerDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@custid", lblsID.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                DataLoad();
                ClearAllData();

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblsID.Text = GridView1.SelectedRow.Cells[1].Text;
            txtFName.Text = GridView1.SelectedRow.Cells[2].Text;
            txtLName.Text = GridView1.SelectedRow.Cells[3].Text;
            txtEmail.Text = GridView1.SelectedRow.Cells[4].Text;
            txtConNum.Text = GridView1.SelectedRow.Cells[5].Text;
            txtaddress.Text = GridView1.SelectedRow.Cells[6].Text;

        }
    }
}
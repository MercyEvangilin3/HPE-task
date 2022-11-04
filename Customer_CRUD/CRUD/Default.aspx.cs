using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
            if(!IsPostBack)
        {
            AllCustomerDetails();
        }
    }
    SqlConnection con = new SqlConnection("Data Source=LIN80027491\\SQLEXPRESS;Initial Catalog=Task_2;Integrated Security=True");

    protected void Button1_Click(object sender, EventArgs e)
    {
        
        con.Open();
        SqlCommand cmd = new SqlCommand("Insert into Customers values('"+int.Parse(TextBox1.Text)+"','"+TextBox2.Text+"','"+TextBox3.Text+"','"+TextBox4.Text+"','"+TextBox5.Text+"','"+DropDownList1.SelectedValue+"')",con);
        cmd.ExecuteNonQuery();
        con.Close();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Inserted');", true);
        AllCustomerDetails();
    }
    void AllCustomerDetails()
    {
        SqlCommand cmd = new SqlCommand("select * from Customers", con);
        SqlDataAdapter d = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        d.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

        con.Open();
        SqlCommand cmd = new SqlCommand("update Customers set First_Name='"+TextBox2.Text+"',Last_name='"+TextBox3.Text+"',Email='"+TextBox4.Text+"',Contact_Number='"+TextBox5.Text+"',Address='"+DropDownList1.SelectedValue+"'  where CustomerId='"+int.Parse(TextBox1.Text)+"'", con);
        cmd.ExecuteNonQuery();
        con.Close();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);
        AllCustomerDetails();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("Delete Customers   where CustomerId='" + int.Parse(TextBox1.Text) + "'", con);
        cmd.ExecuteNonQuery();
        con.Close();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Deleted');", true);
        AllCustomerDetails();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("select * from Customers where CustomerId='" + int.Parse(TextBox1.Text) + "'", con);
        SqlDataAdapter d = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        d.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}
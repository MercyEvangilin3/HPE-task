using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CRUDUsingADO.Models
{
    public class EmloyeeDBContext
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public List<Employee> GetEmployees()
        {
            List<Employee> EmployeeList = new List<Employee>();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("spGetEmployees",con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Employee emp = new Employee();
                emp.EId = Convert.ToInt32(dr.GetValue(0).ToString());
                emp.EmpName = dr.GetValue(1).ToString();
          
                emp.DId = Convert.ToInt32(dr.GetValue(2).ToString());
                emp.Gender = dr.GetValue(3).ToString();
                emp.Email = dr.GetValue(4).ToString();
                EmployeeList.Add(emp);

            }
            con.Close();

            return EmployeeList;
        }

        public bool AddEmployee(Employee emp)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("spAddEmployees", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EId", emp.EId);
            cmd.Parameters.AddWithValue("@EmpName", emp.EmpName);
            cmd.Parameters.AddWithValue("@DId", emp.DId);
            cmd.Parameters.AddWithValue("@Gender", emp.Gender);
            cmd.Parameters.AddWithValue("@Email", emp.Email);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if(i>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateEmployee(Employee emp)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("spUpdateEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EId", emp.EId);
            cmd.Parameters.AddWithValue("@EmpName", emp.EmpName);
            cmd.Parameters.AddWithValue("@DId", emp.DId);
            cmd.Parameters.AddWithValue("@Gender", emp.Gender);
            cmd.Parameters.AddWithValue("@Email", emp.Email);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteEmployee(int EId)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("spDeleteEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EId",EId);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
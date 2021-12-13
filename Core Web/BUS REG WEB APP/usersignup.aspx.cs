using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BUS_REG_WEB_APP
{
    public partial class Usersignup : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Submit_Click(object sender, EventArgs e)
        {

            if (checkUser())
            {
                Response.Write("<script> alert('User exist');</script>");

            }
            else
            {
                NewUser();
            }            
        }
        //check user method
        bool checkUser()
        {
            try
            {
                //check for open connections
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                //sql insert query
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE OwnerID = '"+IDnumber.Text.Trim()+"';", con);
                SqlDataAdapter da= new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if(dt.Rows.Count>= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {
                //exception message
                Response.Write("<script> alert('" + ex.Message + "');</script>");
                return false;

            }
            
        }
        //login method
        void NewUser()
        {
            //after clicking the register button.
            try
            {
                //check for open connections
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                string query = "INSERT INTO Users (OwnerID,Full_name,Email,Phone,Password) VALUES(@owner_id,@fullname,@email,@phone,@password)";
                //sql insert query
                SqlCommand cmd = new SqlCommand(query, con);
                //declare values from form
                cmd.Parameters.AddWithValue("@owner_id", IDnumber.Text.Trim());
                cmd.Parameters.AddWithValue("@fullname", fullname.Text.Trim());
                cmd.Parameters.AddWithValue("@email", Email.Text.Trim());
                cmd.Parameters.AddWithValue("@phone", phoneNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@password", Password.Text.Trim());

                //execute query
                cmd.ExecuteNonQuery();
                //close connection.
                con.Close();
                //successful signup message
                Response.Write("<script> alert('Sign Up successful. Login');</script>");

            }
            catch (Exception ex)
            {
                //exception message
                Response.Write("<script> alert('" + ex.Message + "');</script>");

            }

        }
    }
}
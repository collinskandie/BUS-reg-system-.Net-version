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
    public partial class WebForm1 : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void login_Click(object sender, EventArgs e)
        {

            //Response.Write("<script> alert('Test')</Script>");
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                SqlCommand cmd = new SqlCommand("Select * FROM Users WHERE Email='" + uemail.Text.Trim()+ "' AND Password ='" +password.Text.Trim() + "'", con);
                SqlDataReader dtr = cmd.ExecuteReader();

                //check if user available
                if (dtr.HasRows)
                {
                    while (dtr.Read())
                    {
                       Response.Write("<script> alert('Welcome Back" + dtr.GetValue(1).ToString() + "');</script>");
                        Session["username"] = dtr.GetValue(1).ToString();
                        Session["userId"] = dtr.GetValue(0).ToString();                       
                    }
                    //direct to userpanel.
                    Response.Redirect("userpanel.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Login failed')</script>");

                }


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert(" + ex.Message + ")</script>");


            }

        }
    }
}
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
    public partial class alldriversaspx : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //log out button
        protected void login_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["userID"] = "";
            Response.Redirect("adminlogin.aspx");
        }
        //method to check if the new driver exist
        bool checkdriver()
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM Driverstbl WHERE DriverID = '" + driversID.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
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

        protected void Save_Click(object sender, EventArgs e)
        {
            if (checkdriver())
            {
                Response.Write("<script> alert('Driver with the same id available')");
            }
            else
            {

            }

        }
        //
    }
}
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
            if (!IsPostBack)
            {
                GridviewBind();
            }
            

        }
        //log out button
        protected void login_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["userID"] = "";
            Response.Redirect("adminlogin.aspx");
        }
        //method to check if the new driver exist
       
        protected void Save_Click(object sender, EventArgs e)
        {
            
                AddnewDriver();
                GridviewBind();

            

        }
        //add new records
        void AddnewDriver()
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                SqlCommand sqlInsert = new SqlCommand("INSERT INTO Driverstbl(DriverID,DriverFullName,DriverEmail,DriverPhone) VALUES('"+driversID.Text.Trim()+"','"+Fullname.Text.Trim()+ "','" + email.Text.Trim() + "','" + phone.Text.Trim() + "') ", con);
                int tcmd = sqlInsert.ExecuteNonQuery();
                if (tcmd > 0)
                {
                    Response.Write("<script> alert('Drivers Saved successfully')</script>");
                    clear();
                }
                else
                {
                    Response.Write("<script> alert('Try Again')</script>");
                }

            } 
            void clear()
            {
                driversID.Text = "";
                Fullname.Text = "";
                email.Text = "";
                phone.Text = "";
            }

        }
        protected void GridviewBind()
        {
            using (SqlConnection con = new SqlConnection(strcon)) 
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Driverstbl", con);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows == true)
                {
                    all_drivers.DataSource= dataReader;
                    all_drivers.DataBind(); //bind data to gridview.
                }


            }
        }
        //edit update button.

        protected void all_drivers_RowEditing(object sender, GridViewEditEventArgs e)
        {
            all_drivers.EditIndex = e.NewEditIndex;
            GridviewBind();

        }

        protected void all_drivers_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
            string driverId = ((TextBox)all_drivers.Rows[e.AffectedRows].Cells[0].Controls[0]).Text;
            string name = ((TextBox)all_drivers.Rows[e.AffectedRows].Cells[1].Controls[0]).Text;
            string email = ((TextBox)all_drivers.Rows[e.AffectedRows].Cells[2].Controls[0]).Text;
            string phone = ((TextBox)all_drivers.Rows[e.AffectedRows].Cells[3].Controls[0]).Text;

            //connect to database
            using (SqlConnection con = new SqlConnection())
            {
                con.Open();
                SqlCommand editValue = new SqlCommand("UPDATE Driverstbl set DriverFullName='" + name + "',DriverEmail= '" + email + "',DriverPhone='" + phone + "' WHERE DriverID='" + driverId + "'");
                int exeQuery = editValue.ExecuteNonQuery();
                if (exeQuery > 0)
                {
                    Response.Write("<script> alert('Edited successful')</script>");
                    all_drivers.EditIndex = -1;
                    GridviewBind();
                }
            }

        }

        
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BUS_REG_WEB_APP
{
    public partial class udrivers : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridviewBind();
            }


        }
        protected void GridviewBind()
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Drivertbl", con);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows == true)
                {
                    all_drivers.DataSource = dataReader;
                    all_drivers.DataBind(); //bind data to gridview.
                }


            }
        }
        void AddnewBus()
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                SqlCommand sqlInsert = new SqlCommand("INSERT INTO Drivertbl VALUES('" + driversID.Text.Trim() + "','" + Fullname.Text.Trim() + "','" + email.Text.Trim() + "','" + phone.Text.Trim() + "') ", con);
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


        protected void Save_Click(object sender, EventArgs e)
        {
            AddnewBus();
            GridviewBind();

        }

        protected void all_vehicles_RowEditing(object sender, GridViewEditEventArgs e)
        {
            all_drivers.EditIndex = e.NewEditIndex;
            GridviewBind();

        }

        protected void all_vehicles_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string regno = ((TextBox)all_drivers.Rows[e.RowIndex].Cells[0].Controls[0]).Text;
            string name = ((TextBox)all_drivers.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            string ownerid = ((TextBox)all_drivers.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            string driverid = ((TextBox)all_drivers.Rows[e.RowIndex].Cells[3].Controls[0]).Text;

            //connect to database
            using (SqlConnection con = new SqlConnection())
            {
                con.Open();
                SqlCommand editValue = new SqlCommand("UPDATE BUStbl set BusName='" + name + "',OwnerID= '" + ownerid + "',DriverID='" + driverid + "' WHERE RegNo='" + regno + "'");
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
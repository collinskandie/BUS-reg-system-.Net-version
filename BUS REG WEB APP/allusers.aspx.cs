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
    public partial class allusers : System.Web.UI.Page
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM BUStbl", con);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows == true)
                {
                    all_vehicles.DataSource = dataReader;
                    all_vehicles.DataBind(); //bind data to gridview.
                }


            }
        }
        void AddnewBus()
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                SqlCommand sqlInsert = new SqlCommand("INSERT INTO BUStbl(RegNo,BusName,OwnerID,DriverID,SaccoID) VALUES('" + regNo.Text.Trim() + "','" + usName.Text.Trim() + "','" + ownerid.Text.Trim() + "','" + driverid.Text.Trim() + "','" + saccoID.Text.Trim() + "') ", con);
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
                regNo.Text = "";
                usName.Text = "";
                ownerid.Text = "";
                driverid.Text = "";
            }

        }


        protected void Save_Click(object sender, EventArgs e)
        {
            AddnewBus();
            GridviewBind();

        }

        protected void all_vehicles_RowEditing(object sender, GridViewEditEventArgs e)
        {
            all_vehicles.EditIndex = e.NewEditIndex;
            GridviewBind();

        }

        protected void all_vehicles_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string regno = ((TextBox)all_vehicles.Rows[e.RowIndex].Cells[0].Controls[0]).Text;
            string name = ((TextBox)all_vehicles.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            string ownerid = ((TextBox)all_vehicles.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            string driverid = ((TextBox)all_vehicles.Rows[e.RowIndex].Cells[3].Controls[0]).Text;

            //connect to database
            using (SqlConnection con = new SqlConnection())
            {
                con.Open();
                SqlCommand editValue = new SqlCommand("UPDATE BUStbl set BusName='" + name + "',OwnerID= '" + ownerid + "',DriverID='" + driverid + "' WHERE RegNo='" + regno + "'");
                int exeQuery = editValue.ExecuteNonQuery();
                if (exeQuery > 0)
                {
                    Response.Write("<script> alert('Edited successful')</script>");
                    all_vehicles.EditIndex = -1;
                    GridviewBind();
                }
            }
        }
    }
}
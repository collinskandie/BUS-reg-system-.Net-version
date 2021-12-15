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
    public partial class adminpanel : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                alldriversBind();
                allusersBind();
                allbusesBind();
                allSaccosBind();
            }

        }
        protected void alldriversBind()
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Driverstbl", con);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows == true)
                {
                    alldrivers.DataSource = dataReader;
                    alldrivers.DataBind(); //bind data to gridview.
                }


            }
        }
        protected void allusersBind()
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Driverstbl", con);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows == true)
                {
                   allusers.DataSource = dataReader;
                   allusers.DataBind(); //bind data to gridview.
                }


            }
        }
        protected void allbusesBind()
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Driverstbl", con);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows == true)
                {
                    allbuses.DataSource = dataReader;
                    allbuses.DataBind(); //bind data to gridview.
                }


            }
        }
        protected void allSaccosBind()
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Driverstbl", con);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows == true)
                {
                    allsaccos.DataSource = dataReader;
                    allsaccos.DataBind(); //bind data to gridview.
                }


            }
        }

    }
}
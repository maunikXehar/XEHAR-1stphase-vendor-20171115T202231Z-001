using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XEHAR2017
{
    public partial class MnkVendor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.BindGrid();
            }
            var 
        }

        private void BindGrid()
        {

            MySqlConnection con = new MySqlConnection(WebConfigurationManager.ConnectionStrings["Xehar"].ConnectionString);
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Vendors"))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                            
                        }
                    }
                }
            }

        }

        //Onrow

        protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            int productId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
            string s = (row.FindControl("txtStock") as TextBox).Text;
            int Stock;
            bool isParsed = Int32.TryParse(s,out Stock);




            MySqlConnection con = new MySqlConnection(WebConfigurationManager.ConnectionStrings["Xehar"].ConnectionString);
            {
                using (MySqlCommand cmd = new MySqlCommand("UPDATE Vendors SET Stock = @Stock WHERE PID = @PID"))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter())
                    {
                        cmd.Parameters.AddWithValue("@PID", productId);
                        cmd.Parameters.AddWithValue("@Stock", Stock);
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                } 
            }
            GridView1.EditIndex = -1;
            this.BindGrid();
        }

        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            this.BindGrid();
        }

        protected void OnRowCancelingEdit(object sender, EventArgs e)
        {
            GridView1.EditIndex = -1;
            this.BindGrid();
        }

        //public void PID_Click(object sender,  CommandEventArgs e)
        //{
        //    //Button btn = (Button)sender;
        //    //GridViewRow row = (GridViewRow)btn.NamingContainer;
        //   // GridViewRow row = GridView1.Rows[e.RowIndex];
        //    //int productId  = Int32.Parse((row.Cells[0]).ToString());
        //   // int productId2 = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
        //    int productId;
        //    bool b=Int32.TryParse(GridView1.SelectedDataKey.Value.ToString(), out productId);
        //    Server.Transfer("MnkVendorProduct.aspx");
        //   // Response.Redirect("MnkVendorProduct.aspx");
        //}

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            GridViewRow gvr = e.Row;
            switch (gvr.RowType)
            {
                case DataControlRowType.DataRow:
                    {
                        // Retrieve controls
                        LinkButton link1 = gvr.FindControl("link1") as LinkButton;
                        if (link1 != null)
                        {
                            link1.CommandArgument = gvr.RowIndex.ToString();
                        }
                        break;
                    }
            }
        }

        protected void link1Click(object sender, EventArgs e)
        {
            // Retrieve control
            LinkButton link1 = sender as LinkButton;
            var rowIndex = link1.CommandArgument;
            //
            Session["field1"] = rowIndex;
            Response.Redirect("MnkVendorProduct.aspx?productID="+rowIndex);
            Console.WriteLine("clicked");
        }



    }
}
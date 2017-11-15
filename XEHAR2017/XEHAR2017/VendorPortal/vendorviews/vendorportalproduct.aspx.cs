using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XEHAR2017.AdminUI.adminviews
{
    public partial class vendorportalproduct : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection(WebConfigurationManager.ConnectionStrings["Xehar"].ConnectionString);
        string pid = string.Empty;
        int Totalvalue;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                if (!String.IsNullOrEmpty(Request.QueryString["pid"]))
                {
                    pid = Request.QueryString["pid"].ToString();
                    this.BindData(pid);
                }


            }
        }
        private void BindData(string pid)
        {
           string strData = "SELECT p.Description, p.`Vendor Cost`, v.Totalvalue FROM Products p INNER JOIN  vendors v on p.PID=v.PId WHERE p.PID='" + pid + "'";
            
           MySqlCommand cmd = new MySqlCommand(strData, con);
           cmd.Connection = con;
           con.Open();

            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {                
                lblVendorDescription.InnerText = myReader["Description"].ToString();
                lblVendorPrice.InnerText = "$ "+myReader["Vendor Cost"].ToString();
                Session["Totalvalue"] = myReader["Totalvalue"].ToString();
            }
        }

        protected void Updateproducts(Object sender, EventArgs e)
        {
            try
            {
                string productid=Request.QueryString["pid"].ToString();
                int intsmall = Convert.ToInt32(txtSmall.Value.ToString());
                int intM = Convert.ToInt32(txtM.Value.ToString());
                int intL = Convert.ToInt32(txtL.Value.ToString());
                int Total = Convert.ToInt32(Session["Totalvalue"] )+ intsmall + intM + intL;

                StringBuilder strQuery=new StringBuilder();
                strQuery.Append("update vendors set Totalvalue = '" + Total + "' where PID ='" + productid + "';");
                //strQuery.AppendLine("INSERT INTO productclothingsize (CSID,PID,Totalcount) VALUES ('1','" + productid + "','" + txtSmall.Value + "') ON DUPLICATE KEY UPDATE Totalcount='" + txtSmall.Value + "';");
                //strQuery.AppendLine("INSERT INTO productclothingsize (CSID,PID,Totalcount) VALUES ('2','" + productid + "','" + txtM.Value + "') ON DUPLICATE KEY UPDATE Totalcount='" + txtM.Value + "';");
                //strQuery.AppendLine("INSERT INTO productclothingsize (CSID,PID,Totalcount) VALUES ('3','" + productid + "','" + txtL.Value + "') ON DUPLICATE KEY UPDATE Totalcount='" + txtL.Value + "';");                


                using (MySqlCommand cmd = new MySqlCommand(strQuery.ToString()))
                {
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                Response.Redirect("/VendorPortal/vendorviews/products.aspx?sid=1");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        protected void Cancelupdateproducts(Object sender, EventArgs e)
        {
            Response.Redirect("/VendorPortal/vendorviews/products.aspx?sid=1");
        }


    }
}
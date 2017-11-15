using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Odbc;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XEHAR2017.AdminUI.adminviews
{
    public partial class addproducts : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection(WebConfigurationManager.ConnectionStrings["Xehar"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!String.IsNullOrEmpty(Request.QueryString["sid"]))
                {
                    string successVal = Request.QueryString["sid"].ToString();
                    if (successVal == "1")
                    {
                        successBox.Visible = true;
                    }
                }
                
            }
        }

        protected void Addproducts(Object sender, EventArgs e)
        {
            try
            {
                DateTime date = DateTime.ParseExact(datepicker.Value.ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture);


                string endDate = date.ToString("yyyy-MM-dd hh:mm:ss");

                string cmdExeDetail = @"INSERT INTO products (SKU, `Product Name`, Description, `Model Number`, Department, `Tax Code`, Brand, Manufactuer, `Vendor Cost`,Gender, Warranty, Weight, EndDate, Qaulity, SupplierCost, CountryOrigin, Replinishable, Expeditable, `Reorder Time`, `Sold Quantity`) 
                                    VALUES ('" + txtSku.Value.ToString() + "', '" + txtProductname.Value.ToString() + "', '" + txtDescription.Value.ToString() + "','" + txtModelnumber.Value.ToString() + "', '" + txtDepartment.Value.ToString() + "', '" + txtTaxcode.Value.ToString() + "', '" + txtBrand.Value.ToString() + "', '" + txtManufactuer.Value.ToString() + "', '" + txtVendorcost.Value.ToString() + "', '" + ddlGender.Value.ToString() + "', '" + txtWarranty.Value.ToString() + "', '" + txtWeight.Value.ToString() + "', '" + endDate + "', '" + txtQuality.Value.ToString() + "', '" + txtSuppliercost.Value.ToString() + "', '" + txtCountryorigin.Value.ToString() + "', '" + txtReplinishable.Value.ToString() + "', '" + txtExpeditable.Value.ToString() + "', '" + txtReordertime.Value.ToString() + "', '" + txtSoldquantity.Value.ToString() + "')";

                using (MySqlCommand cmd = new MySqlCommand(cmdExeDetail))
                {
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                Response.Redirect("/AdminUI/adminviews/addproducts.aspx?sid=1");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
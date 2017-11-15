using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XEHAR2017
{
    public partial class page2 : System.Web.UI.Page
    {
        public static string userName = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                if (!string.IsNullOrEmpty(Request.Form["name"]) && !string.IsNullOrEmpty(Request.Form["technology"]))
                {
                    Response.Write("<u>Values using Form Post</u><br /><br />");
                    Response.Write("<b>Name:</b> " + Request.Form["name"] + " <b>Technology:</b> " + Request.Form["technology"]);
                }
            }
        }
            //if (!this.IsPostBack)
            //{
            //    if (!string.IsNullOrEmpty(Request.Form["name"]) && !string.IsNullOrEmpty(Request.Form["technology"]))
            //    {
            //        Response.Write("<u>Values using Form Post</u><br /><br />");
            //        Response.Write("<b>Name:</b> " + Request.Form["name"] + " <b>Technology:</b> " + Request.Form["technology"]);
            //    }
            //}

            
       
        [WebMethod]
        public static string getUserName(string name)
        {
            userName = "Welcome, " + name;
            return userName;


        }

        [WebMethod]
        public static string getUserNameToWelcome()
        {
            return userName;
        }
    }
 }

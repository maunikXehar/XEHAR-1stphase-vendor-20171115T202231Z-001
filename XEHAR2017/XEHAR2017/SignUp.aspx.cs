using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XEHAR2017
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        [WebMethod]
        public static string RegisterUser(string uzip, string uname, string uvin, string uemail, string uadd, string ucity, string ucountry)
        {

               string result = "user saved";
            

            return result;
        }
    }
}
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XEHAR2017.AdminUI.AdminUIPages
{
    public partial class AdminContent : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static string MyMethod(string Param1)
        {
            MySqlConnection con = new MySqlConnection(WebConfigurationManager.ConnectionStrings["Xehar"].ConnectionString);

            string strData = "SELECT p.`Product Name`,p.`Sold Quantity` FROM Products p inner join vendors v on p.VID=v.VID WHERE p.VID=1 ORDER BY p.`Sold Quantity` DESC LIMIT " + Param1 + "";

            MySqlCommand cmd = new MySqlCommand(strData, con);
            cmd.Connection = con;
            con.Open();

            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            var returndata = new List<ChartData>();
            string[] arrColor = new string[] { "#F44937", "#FFC200", "#F44937", "#16F27E", "#FC9775", "#5A69A6" };

            int counter = 0;
            while (myReader.Read())
            {
               

                returndata.Add(new ChartData
                {
                    value = myReader["Sold Quantity"].ToString(),
                    label = myReader["Product Name"].ToString(),
                    color = arrColor[counter]

                    
                });
                counter++;
            }
            JavaScriptSerializer json = new JavaScriptSerializer();
            return json.Serialize(returndata);


        }

        public class ChartData
        {
            public string label { get; set; }
            public string value { get; set; }
            public string color { get; set; }
            public string hightlight { get; set; }

        }
        
      

    }
}
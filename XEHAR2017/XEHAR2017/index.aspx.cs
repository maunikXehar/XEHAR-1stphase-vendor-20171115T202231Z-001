using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quicky
{
    public partial class index : System.Web.UI.Page
    {
        MySqlConnection k = new MySqlConnection(WebConfigurationManager.ConnectionStrings["Xehar"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            //CLT.InnerText = Customers();
        }
        public string Open()
        {

            string m = "";

            try
            {
                k.Open();
                return "The connection was successful";
            }
            catch (Exception s)
            {
                m = "Failure" + s.Message;
                return m;
            }

        }
        [WebMethod]
        public static string Customers()
        {
           // MySqlConnection k = new MySqlConnection(WebConfigurationManager.ConnectionStrings["Xehar"].ConnectionString);
           // k.Open();
            string query = "select  ProductName,  max(Sold) as s from products group by ProductName Order by s desc limit 5";

            DataTable DT_Results;

            DT_Results = RunSQL(query);
            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(DT_Results);
            
            return JSONString;

        }
        [WebMethod]
        private static DataTable RunSQL(string query)
        {
            MySqlConnection con = new MySqlConnection(WebConfigurationManager.ConnectionStrings["Xehar"].ConnectionString);

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    return dt;
                    
                }
                
            }
           

        }
    }

}
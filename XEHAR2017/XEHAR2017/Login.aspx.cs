using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace XEHAR2017
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

       

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
           
            MySqlConnection con = new MySqlConnection(WebConfigurationManager.ConnectionStrings["Xehar"].ConnectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM user WHERE username = @username AND password = @password", con);

            string username = txtUserName.Text.Trim().ToString();
            cmd.Parameters.AddWithValue("username", @username);
            string password = txtPwd.Text.Trim().ToString();
            cmd.Parameters.AddWithValue("password", @password);

            con.Open();
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (result >= 1)
            {
                lblMsg.Text = "welcome @username";
            }
            else
                lblMsg.Text = "Incorrect Username or Password";
           
            
            
            //string strCon = ConfigurationManager.ConnectionStrings["Xehar"].ConnectionString;
            //string strSelect = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";

            //SqlConnection con = new SqlConnection(strCon);
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = strSelect;



            // MySqlParameter username = new MySqlParameter("@username");

            //cmd.Parameters.Add(username);

            //cmd.Parameters.Add("pass", @pass)
            // SqlParameter password = new SqlParameter("@password");

            //cmd.Parameters.Add(password);
            //cmd.Parameters.Add("user", @username);




            //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //if (dt.Rows.Count >= 1)
            //{

            //    //Response.Redirect("welcome.aspx");
            //    lblMsg.Text = "correct Username or Password";
            //}
            //else
            //{
            //    con.Close();
            //    lblMsg.Text = "incorrect Username or Password";
            //    //ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Invalid Username and Password')</script>");
            //}
            //int result = (Int32)cmd.ExecuteScalar();
            //con.Close();

            //if (result >= 1)
            //{
            //    Response.Redirect("UpdateProfile.aspx");
            //}
            //else
            //    lblMsg.Text = "Incorrect Username or Password";

            /////////////////////////////////////////////////////////////////////////
            //string user = txt_userid.Text;
            //string pass = txt_pwd.Text;
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("select userid,password from tbllogin where userid=@user and password=@pass", conn);
            //cmd.Parameters.Add("user", @user);
            //cmd.Parameters.Add("pass", @pass);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //if (dt.Rows.Count > 0)
            //{
            //    conn.Close();
            //    Response.Redirect("welcome.aspx");
            //}
            //else
            //{
            //    conn.Close();
            //    ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Invalid Username and Password')</script>");
            //}
        }
    }
}
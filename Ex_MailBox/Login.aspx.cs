using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Ex_MailBox
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmdCheckUser;
        SqlDataReader reader;

        string email, password;

        protected void Page_Load(object sender, EventArgs e)
        {
            //****          CHANGE CONNECTION PATHS         ****//
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\Administrator\\Documents\\GitHub\\Ex_MailBox\\Ex_MailBox\\App_Data\\Database1.mdf';Integrated Security=True");

            try
            {
                con.Open();
            }
            catch (Exception exConnection)
            {
                Response.Write(exConnection.ToString());
            }

        }

        protected void ButtonLogIn_Click(object sender, EventArgs e)
        {
            email = TextBoxEmail.Text.ToString();
            password = TextBoxPassword.Text.ToString();

            cmdCheckUser = new SqlCommand();
            cmdCheckUser.Connection = con;

            cmdCheckUser.CommandText = "SELECT * FROM Users WHERE EmailAddress = '" + email + "' AND Password = '" + password + "'";

            reader = cmdCheckUser.ExecuteReader();

            if (reader.Read())
            {
                Session["EmailAddress"] = reader["EmailAddress"].ToString();
                Session["Name"] = reader["Name"].ToString();
                Session["Address"] = reader["Address"].ToString();
                reader.Close();
                Response.Redirect("Inbox.aspx");
            }
            else
            {
                Response.Write("Logins credentials invalid. Please retry");
                TextBoxPassword.Text = null;
            }

        }
    }
}
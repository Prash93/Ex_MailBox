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

        }
    }
}
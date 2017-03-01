using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Ex_MailBox
{
    public partial class ComposeMail : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmdInsertEmail;
        SqlDataReader reader;

        string toEmail, ccEmail, subject, body;
        //
        protected void Page_Load(object sender, EventArgs e)
        {
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

        protected void ButtonSend_Click(object sender, EventArgs e)
        {
            toEmail = TextBoxToAddress.Text.ToString();
            ccEmail = TextBoxCCAddress.Text.ToString();
            subject = TextBoxSubject.Text.ToString();
            body = TextBoxBody.Text.ToString();

            if (toEmail == "" || subject == "" || body == "")
            {
                Response.Write("Please enter the required fields: To, Subject, Body");
                Response.Write("<br />");
                Response.Write("<br />");
            }
            else
            {
                cmdInsertEmail = new SqlCommand();
                cmdInsertEmail.Connection = con;

                cmdInsertEmail.CommandText = "INSERT INTO Emails(FromEmail, ToEmail, CcEmail, Subject, Text) VALUES('" + Session["EmailAddress"].ToString() + "', '" + toEmail + "', '" + ccEmail + "', '" + subject + "', '" + body + "')";

                cmdInsertEmail.ExecuteNonQuery();
            }
        }
    }
}
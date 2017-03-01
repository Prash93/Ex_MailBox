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
        SqlCommand cmdInsertEmail, cmdCheckUser;
        SqlDataReader reader;

        string toEmail, ccEmail, subject, body, sqlToEmail, sqlCcEmail;
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
            cmdCheckUser = new SqlCommand();
            cmdCheckUser.Connection = con;
            cmdInsertEmail = new SqlCommand();
            cmdInsertEmail.Connection = con;

            if (toEmail == "" || subject == "" || body == "")
            {
                Response.Write("Please enter the required fields: To, Subject, Body");
                Response.Write("<br />");
                Response.Write("<br />");
            }
            else
            {
                cmdCheckUser.CommandText = "SELECT * FROM Users WHERE EmailAddress = '" + toEmail + "'";
                reader = cmdCheckUser.ExecuteReader();

                //**    check if To Email Address exists in DB   **//
                if (reader.Read())
                {
                    sqlToEmail = reader["EmailAddress"].ToString();
                    reader.Close();

                    //**    check if Cc Email is populated in the field     **//
                    if (ccEmail != "")
                    {
                        cmdCheckUser.CommandText = "SELECT * FROM Users WHERE EmailAddress = '" + ccEmail + "'";
                        reader = cmdCheckUser.ExecuteReader();

                        //**    check if Cc Email Address exists in DB    **//
                        if (reader.Read())
                        {
                            sqlCcEmail = reader["EmailAddress"].ToString();
                            reader.Close();

                            cmdInsertEmail.CommandText = "INSERT INTO Emails(FromEmail, ToEmail, CcEmail, Subject, Text) VALUES('" + Session["EmailAddress"].ToString() + "', '" + sqlToEmail + "', '" + sqlCcEmail + "', '" + subject + "', '" + body + "')";
                            cmdInsertEmail.ExecuteNonQuery();
                        }
                        else
                        {
                            Response.Write("The Cc Email Address does not exist in database. Please re-enter a valid Cc Email address or leave it blank.");
                            Response.Write("<br/>");
                            TextBoxCCAddress.Text = "";
                        }
                    }
                    else
                    {
                        //**    if To Email Address is entered and No Cc Email Address is entered
                        cmdInsertEmail.CommandText = "INSERT INTO Emails(FromEmail, ToEmail, Subject, Text) VALUES('" + Session["EmailAddress"].ToString() + "', '" + toEmail + "', '" + subject + "', '" + body + "')";
                        cmdInsertEmail.ExecuteNonQuery();
                    }
                }
                else
                {
                    Response.Write("The 'To' Email Address doesn't exist. Please re-enter a valid email address or create a new email adsress.");
                    Response.Write("<br/>");
                    TextBoxToAddress.Text = "";
                }
            }
        }
    }
}
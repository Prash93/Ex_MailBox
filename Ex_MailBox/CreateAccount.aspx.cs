using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Ex_MailBox
{
    public partial class CreateAccount : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmdInsertUser, cmdExistingUser;
        SqlDataReader reader;

        string newEmailAddress, newName, newAddress, newPassword, newReenterPassword, newSecQuest, newSecAns;

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

        protected void ButtonCreateAccount_Click(object sender, EventArgs e)
        {

            newEmailAddress = TextBoxEmailAdd.Text.ToString();
            newName = TextBoxName.Text.ToString();
            newAddress = TextBoxAddress.Text.ToString();
            newPassword = TextBoxPassword.Text.ToString();
            newReenterPassword = TextBoxReenterPass.Text.ToString();
            newSecQuest = TextBoxSecQuest.Text.ToString();
            newSecAns = TextBoxSecAns.Text.ToString();

            if (newEmailAddress == "" || newName == "" || newAddress == "" || newPassword == "" || newReenterPassword == "" || newSecQuest == "" || newSecAns == "")
            {
                Response.Write("You have not entered all the fields. Please enter the missing fields.");
                Response.Write("<br />");
                Response.Write("<br />");
            }
            else
            {
                cmdExistingUser = new SqlCommand();
                cmdExistingUser.Connection = con;
                cmdExistingUser.CommandText = "SELECT * FROM Users WHERE EmailAddress = '" + newEmailAddress  + "'";
                reader = cmdExistingUser.ExecuteReader();

                if (reader.Read())
                {
                    Response.Write("Email Address already exists. Please enter a new email address.");
                    Response.Write("<br />");
                    Response.Write("<br />");
                    TextBoxEmailAdd.Text = "";
                    TextBoxName.Text = "";
                    TextBoxAddress.Text = "";
                    TextBoxPassword.Text = "";
                    TextBoxReenterPass.Text = "";
                    TextBoxSecQuest.Text = "";
                    TextBoxSecAns.Text = "";

                    reader.Close();
                }
                else
                {
                    reader.Close();

                    if (TextBoxPassword.Text.ToString() == TextBoxReenterPass.Text.ToString())
                    {
                        cmdInsertUser = new SqlCommand();
                        cmdInsertUser.Connection = con;
                        cmdInsertUser.CommandText = "INSERT INTO Users VALUES('" + newEmailAddress + "', '" + newName + "', '" + newAddress + "', '" + newPassword + "', '" + newSecQuest + "', '" + newSecAns + "')";
                        cmdInsertUser.ExecuteNonQuery();
                        Response.Redirect("Login.aspx");
                    }
                    else
                    {
                        Response.Write("Your passwords don't match. Please re-enter.");
                        Response.Write("<br />");
                        Response.Write("<br />");
                        TextBoxPassword.Text = "";
                        TextBoxReenterPass.Text = "";
                        TextBoxSecQuest.Text = "";
                        TextBoxSecAns.Text = "";
                    }
                }

            }
        }
    }
}
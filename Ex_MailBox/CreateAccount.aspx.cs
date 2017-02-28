using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ex_MailBox
{
    public partial class CreateAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCreateAccount_Click(object sender, EventArgs e)
        {

            if (TextBoxPassword.Text.ToString() == TextBoxReenterPass.Text.ToString())
            {
                Session["NewEmailAdd"] = TextBoxEmailAdd.Text.ToString();
                Session["NewName"] = TextBoxName.Text.ToString();
                Session["NewAddress"] = TextBoxAddress.Text.ToString();
                Session["NewPassword"] = TextBoxPassword.Text.ToString();
                Session["NewReenterPassword"] = TextBoxReenterPass.Text.ToString();
                Session["NewSecQuest"] = TextBoxSecQuest.Text.ToString();
                Session["NewSecAns"] = TextBoxSecAns.Text.ToString();
            }
            else
            {
                Response.Write("Your passwords don't match. Please re-enter.");

                TextBoxPassword.Text = "";
                TextBoxReenterPass.Text = "";
                TextBoxSecQuest.Text = "";
                TextBoxSecAns.Text = "";
            }
        }
    }
}
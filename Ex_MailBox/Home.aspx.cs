using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ex_MailBox
{
    public partial class Home : System.Web.UI.Page
    {
        //HttpCookie colourCookie = new HttpCookie("colour");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCreateAccount_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateAccount.aspx");
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        /*
        protected void RadioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonBlue.Checked = false;
            RadioButtonGreen.Checked = false;
            RadioButtonYellow.Checked = false;
            Session["colour"] = "red";
        }

        protected void RadioButtonBlue_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonRed.Checked = false;
            RadioButtonGreen.Checked = false;
            RadioButtonYellow.Checked = false;
            Session["colour"] = "blue";
        }

        protected void RadioButtonGreen_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonBlue.Checked = false;
            RadioButtonRed.Checked = false;
            RadioButtonYellow.Checked = false;
            Session["colour"] = "green";
        }

        protected void RadioButtonYellow_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonBlue.Checked = false;
            RadioButtonGreen.Checked = false;
            RadioButtonRed.Checked = false;
            Session["colour"] = "yellow";
        }
        */
        protected void ButtonRed_Click(object sender, EventArgs e)
        {
            //Session["colour"] = "red";
            //colourCookie.Value["selectedColour"]
            Response.Cookies["colour"].Value = "red";

        }

        protected void ButtonBlue_Click(object sender, EventArgs e)
        {
            //Session["colour"] = "blue";
            Response.Cookies["colour"].Value = "blue";
        }

        protected void ButtonGreen_Click(object sender, EventArgs e)
        {
            //Session["colour"] = "green";
            Response.Cookies["colour"].Value = "green";
        }

        protected void ButtonYellow_Click(object sender, EventArgs e)
        {
            //Session["colour"] = "yellow";
            Response.Cookies["colour"].Value = "yellow";
        }
    }
}
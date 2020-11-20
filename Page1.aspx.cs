using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hadeel.Tqanat
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox2.Text = TextBox1.Text;
          //  TextBox1.Text = "";
            TextBox1.Text = string.Empty;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Page2.aspx?name=" + TextBox1.Text);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ViewState["name"] = TextBox1.Text;
            ViewState["age"] = TextBox1.Text;
            TextBox1.Text = TextBox1.Text = "";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Write("Name: " + ViewState["name"] + "Age:" + ViewState["age"]);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Session["ISBN"] = TextBox1.Text;
            Response.Redirect("~/Page2.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("MyCart", TextBox1.Text);
            cookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(cookie);
            Response.Redirect("~/Page2.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Application["WelcomeMessage"] = "Welcome to the Contoso site.";
        }
    }
}
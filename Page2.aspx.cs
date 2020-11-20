using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hadeel.Tqanat
{
    public partial class Page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hello " + Request.QueryString.Get("name"));
            Label1.Text = " Book is: " + Session["ISBN"];
            HttpCookieCollection cookies = Request.Cookies;
            Label1.Text = " Book is: " + cookies["MyCart"].Value;
        }

        protected void Checked(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == false)
            {
                CheckBox1.Checked = true;
                Button1.Text = "Click to UnChecked";
            }

            else
            {
                CheckBox1.Checked = false;
                Button1.Text = "Click to Checked";
            }
        }
    }
}
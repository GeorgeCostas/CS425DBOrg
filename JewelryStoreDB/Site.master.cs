using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SiteMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //String sFullURL = Request.Url.ToString();
        String sURL = System.IO.Path.GetFileName(Request.Path).ToString();
        if (Session["A_Email"] == null)
        {
            if (sURL != "Login.aspx" && sURL != "Register.aspx")
            { 
                Response.Redirect("~/Account/Login.aspx");
            }
            else
            {
                aLogin.Visible = true;
                aEmail.Visible = false;
            }
        }
        else
        {
            if (Session["A_Email"].ToString() == "")
            {
                if (sURL != "Login.aspx" && sURL != "Register.aspx")
                {
                    Response.Redirect("~/Account/Login.aspx");
                }
                else
                {
                    aLogin.Visible = true;
                    aEmail.Visible = false;
                }
            }
            else
            {
                aLogin.Visible = false;
                aEmail.InnerText = "Welcome," + Session["A_Email"].ToString();
                aEmail.Visible = true;
            }
        }
    }
}

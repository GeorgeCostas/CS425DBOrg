using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

public partial class Account_Login : System.Web.UI.Page
{
    #region define variables
    BLL.Account bAccount = new BLL.Account();
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LoginButton_Click(object sender, EventArgs e)
    {
        String sEmail = Email.Text.Trim();
        String sPassword = Password.Text.Trim();
        if (bAccount.IsExist(sEmail, sPassword))
        {
            if (Session["A_Email"] == null)
            {
                Session.Add("A_Email", sEmail);
            }
            else
            {
                Session["A_Email"] = sEmail;
            }
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script>location='../Default.aspx';</script>");
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('Email or password is incorrect, please check and try it again.');</script>");
        }
    }
}
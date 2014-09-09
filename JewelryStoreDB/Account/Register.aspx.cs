using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

public partial class Account_Register : System.Web.UI.Page
{
    #region define variables
    BLL.Account bAccount = new BLL.Account();
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void RegisterUser_CreatedUser(object sender, EventArgs e)
    {
        String sEmail = Email.Text.Trim();
        String sUserName = UserName.Text.Trim();
        String sPassword = Password.Text.Trim();
        bAccount.Insert(sEmail, sUserName, sPassword, "", "", "");
        ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('You registration is successful.');location='~/Default.aspx';</script>");
    }
}

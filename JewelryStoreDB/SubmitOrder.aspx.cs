using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;

public partial class SubmitOrder : System.Web.UI.Page
{
    #region define variables
    BLL.ObjectType bObjectType = new BLL.ObjectType();
    BLL.Orders bOrders = new BLL.Orders();
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bind();
        }
    }

    public void Bind()
    {
        DataSet dsObjectType = bObjectType.Select("select * from ObjectType");
        ddlObjectType.DataSource = dsObjectType;
        ddlObjectType.DataBind();
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        String sAccountId = "1";
        String sObjectType = ddlObjectType.SelectedItem.Text;
        String sAmount = txtAmount.Text.ToString();
        String sDescription = txtDescription.Text.ToString();
        bOrders.Insert(sAccountId, sObjectType, sAmount, sDescription);
        ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('Order has been accepted.'); location='Order.aspx';</script>");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;

public partial class View : System.Web.UI.Page
{
    #region define variables
    BLL.Orders bOrders = new BLL.Orders();
    String sId;
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            sId = Request.QueryString["id"];
            if (sId != null)
            {
                Bind(sId);
            }
        }
    }

    private void Bind(String sId)
    {
        DataSet dsOrders = bOrders.Select("select * from Orders where O_Id=" + sId);
        if (dsOrders.Tables[0].Rows.Count == 1)
        {
            labOrderId.Text = sId;
            labSubmitDate.Text = dsOrders.Tables[0].Rows[0]["O_SubmitDate"].ToString();
            labAccountId.Text = dsOrders.Tables[0].Rows[0]["O_AccountId"].ToString();
            labObjectType.Text = dsOrders.Tables[0].Rows[0]["O_ObjectType"].ToString();
            labAmount.Text = dsOrders.Tables[0].Rows[0]["O_Amount"].ToString();
            labDescription.Text = dsOrders.Tables[0].Rows[0]["O_Description"].ToString();
            labPartsList.Text = dsOrders.Tables[0].Rows[0]["O_PartsList"].ToString();
            labTotalCharges.Text = dsOrders.Tables[0].Rows[0]["O_TotalCharges"].ToString();
            labState.Text = dsOrders.Tables[0].Rows[0]["O_State"].ToString();
            labIsPaid.Text = dsOrders.Tables[0].Rows[0]["O_IsPaid"].ToString();
        }
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        ClientScript.RegisterStartupScript(this.GetType(), "", "<script>location='Order.aspx';</script>");
    }
}
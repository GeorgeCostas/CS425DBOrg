using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Order : System.Web.UI.Page
{
    #region define variables
    BLL.Orders bOrders = new BLL.Orders();
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        Bind();
    }

    #region Bind
    public void Bind()
    {
        DataSet dsOrder = bOrders.Select("select * from Orders");
        gvOrder.DataSource = dsOrder;
        gvOrder.DataBind();
    }
    #endregion

    #region PageIndexChanging
    protected void gvOrder_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvOrder.PageIndex = e.NewPageIndex;
        Bind();
    }
    #endregion

    #region RowCommand
    protected void gvOrder_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        string sCommandName = e.CommandName;
        int iID = Convert.ToInt32(e.CommandArgument);
        String sSQL = "";
        switch (sCommandName)
        {
            case "view":
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>location='View.aspx?id=" + iID.ToString() + "';</script>");
                break;
            case "accept":
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>location='Accept.aspx?id=" + iID.ToString() + "';</script>");
                break;
            case "repair":
                sSQL = "update Orders set O_State='repairing'" + " where O_Id=" + iID.ToString();
                bOrders.Update(sSQL);
                Bind();
                break;
            case "complete":
                sSQL = "update Orders set O_State='completed'" + " where O_Id=" + iID.ToString();
                bOrders.Update(sSQL);
                Bind();
                break;
            case "remove":
                sSQL = "delete * from Orders where O_Id=" + iID.ToString();
                bOrders.Update(sSQL);
                Bind();
                break;
            default:
                break;
        }
        //Bind();
    }
    #endregion
}
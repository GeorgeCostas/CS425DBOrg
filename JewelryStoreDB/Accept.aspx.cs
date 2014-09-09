using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;

public partial class Accept : System.Web.UI.Page
{
    #region define variables
    BLL.Orders bOrders = new BLL.Orders();
    BLL.Parts bParts = new BLL.Parts();
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
            labObjectType.Text = dsOrders.Tables[0].Rows[0]["O_ObjectType"].ToString();
            labAmount.Text = dsOrders.Tables[0].Rows[0]["O_Amount"].ToString();
            labDescription.Text = dsOrders.Tables[0].Rows[0]["O_Description"].ToString();
            labState.Text = dsOrders.Tables[0].Rows[0]["O_State"].ToString();
            labIsPaid.Text = dsOrders.Tables[0].Rows[0]["O_IsPaid"].ToString();

            DataSet dsParts = bParts.Select("select * from Parts where P_RemainNumber>0");
            ddlParts.DataSource = dsParts;
            ddlParts.DataBind();
            BindlabTotalCharges();
        }
    }

    private void BindlabTotalCharges()
    {
        try
        {
            DataSet dsParts = bParts.Select("select * from Parts where P_Id=" + ddlParts.SelectedItem.Value);
            double dSinglePrice = Convert.ToDouble(dsParts.Tables[0].Rows[0]["P_SinglePrice"]);
            labTotalCharges.Text = (dSinglePrice * Convert.ToInt32(ddlAmount.SelectedItem.Value)).ToString();
        }
        catch (Exception)
        { }
    }

    protected void btnAccept_Click(object sender, EventArgs e)
    {
        try
        {
            DataSet dsParts = bParts.Select("select * from Parts where P_Id=" + ddlParts.SelectedItem.Value);
            if (dsParts.Tables[0].Rows.Count > 0)
            {
                if (Convert.ToInt32(dsParts.Tables[0].Rows[0]["P_RemainNumber"]) >= Convert.ToInt32(ddlAmount.SelectedItem.Value))
                {
                    String sSQL = "update Parts set P_RemainNumber=P_RemainNumber-" + ddlAmount.SelectedItem.Value + " where P_Id=" + ddlParts.SelectedItem.Value;
                    bParts.Update(sSQL);
                    sSQL = "update Orders set O_State='waiting parts'";
                    sSQL += ",O_PartsList='" + ddlParts.SelectedItem.Value + "'";
                    sSQL += ",O_TotalCharges=" + labTotalCharges.Text.ToString();
                    sSQL += " where O_Id=" + labOrderId.Text;
                    bOrders.Update(sSQL);
                    ClientScript.RegisterStartupScript(this.GetType(), "", "<script>location='Order.aspx';</script>");
                }
            }
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('" + ex.Message.ToString() + "');</script>");
        }
    }

    protected void ddlParts_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindlabTotalCharges();
    }

    protected void ddlAmount_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindlabTotalCharges();
    }
}
<%@ Page Title="Accept" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Accept.aspx.cs" Inherits="Accept" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Accept
    </h2>
    <table>
        <tr>
            <td>
                <label>Order Id:</label>
            </td>
            <td>
                <asp:Label ID="labOrderId" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <label>Submit date:</label>
            </td>
            <td>
                <asp:Label ID="labSubmitDate" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <label>Object type:</label>
            </td>
            <td>
                <asp:Label ID="labObjectType" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <label>Amount:</label>
            </td>
            <td>
                <asp:Label ID="labAmount" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <label>Description:</label>
            </td>
            <td>
                <asp:Label ID="labDescription" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <label>Select Parts:</label>
            </td>
            <td>
                <asp:DropDownList ID="ddlParts" runat="server" DataTextField="P_Name" DataValueField="P_Id" AutoPostBack="true" OnSelectedIndexChanged="ddlParts_SelectedIndexChanged"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <label>Select Amount:</label>
            </td>
            <td>
                <asp:DropDownList ID="ddlAmount" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlAmount_SelectedIndexChanged">
                    <asp:ListItem Text="1" Value="1" Selected="True"></asp:ListItem>
                    <asp:ListItem Text="2" Value="2"></asp:ListItem>
                    <asp:ListItem Text="3" Value="3"></asp:ListItem>
                    <asp:ListItem Text="4" Value="4"></asp:ListItem>
                    <asp:ListItem Text="5" Value="5"></asp:ListItem>
                    <asp:ListItem Text="6" Value="6"></asp:ListItem>
                    <asp:ListItem Text="7" Value="7"></asp:ListItem>
                    <asp:ListItem Text="8" Value="8"></asp:ListItem>
                    <asp:ListItem Text="9" Value="9"></asp:ListItem>
                    <asp:ListItem Text="10" Value="10"></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <label>Total charges:</label>
            </td>
            <td>
                $<asp:Label ID="labTotalCharges" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <label>State:</label>
            </td>
            <td>
                <asp:Label ID="labState" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <label>Is paid:</label>
            </td>
            <td>
                <asp:Label ID="labIsPaid" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="btnAccept" runat="server" Text="Accept" OnClick="btnAccept_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

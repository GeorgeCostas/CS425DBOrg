<%@ Page Title="Order" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="SubmitOrder.aspx.cs" Inherits="SubmitOrder" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Submit Order
    </h2>
    <table>
        <tr>
            <td>
                <label>Select what you want to repair:</label>
            </td>
            <td>
                <asp:DropDownList ID="ddlObjectType" Width="300px" runat="server" DataTextField="T_Name" DataValueField="T_Id"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <label>Input objects amount:</label>
            </td>
            <td>
                <asp:TextBox ID="txtAmount" Width="300px" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <label>Input description and requirements:</label>
            </td>
            <td>
                <asp:TextBox ID="txtDescription" TextMode="MultiLine" Height="100px" Width="300px" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" onclick="btnSubmit_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

<%@ Page Title="View" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="View.aspx.cs" Inherits="View" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>View
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
                <label>Account Id:</label>
            </td>
            <td>
                <asp:Label ID="labAccountId" runat="server"></asp:Label>
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
                <label>Parts List:</label>
            </td>
            <td>
                <asp:Label ID="labPartsList" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <label>Total charges:</label>
            </td>
            <td>
                <asp:Label ID="labTotalCharges" runat="server"></asp:Label>
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
            <td colspan="2">
                <asp:Button ID="btnReturn" runat="server" Text="Return" OnClick="btnReturn_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

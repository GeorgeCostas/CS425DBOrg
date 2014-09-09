<%@ Page Title="Order" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Order.aspx.cs" Inherits="Order" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Order
    </h2>
    <p>
        <a href="#" onclick="window.open('SubmitOrder.aspx')">submit order</a>
        <asp:GridView ID="gvOrder" runat="server" DataKeyNames="O_Id" AutoGenerateColumns="false"
            Width="100%" AllowPaging="true" PageSize="10" OnRowCommand="gvOrder_RowCommand"
            OnPageIndexChanging="gvOrder_PageIndexChanging" CssClass="GridViewStyle">
            <Columns>
                <asp:TemplateField HeaderText="No">
                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Width="50px" />
                    <ItemTemplate>
                        <%#Container.DataItemIndex + 1%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Date">
                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Width="110px" />
                    <ItemTemplate>
                        <%#Eval("O_SubmitDate") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Order Id">
                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Width="50px" />
                    <ItemTemplate>
                        <%#Eval("O_Id") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Object Type">
                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Width="80px"/>
                    <ItemTemplate>
                        <%#Eval("O_ObjectType") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Total Charges">
                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Width="60px" />
                    <ItemTemplate>
                        <%#Eval("O_TotalCharges") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="State">
                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Width="60px"/>
                    <ItemTemplate>
                        <%#Eval("O_State") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Execute">
                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Width="200px" />
                    <ItemTemplate>
                        <asp:LinkButton runat="server" CommandArgument='<%#Eval("O_Id")%>'
                            CommandName="view">view</asp:LinkButton>
                        <asp:LinkButton runat="server" CommandArgument='<%#Eval("O_Id")%>'
                            CommandName="accept">accept</asp:LinkButton>
                        <asp:LinkButton runat="server" CommandArgument='<%#Eval("O_Id")%>'
                            CommandName="repair">repair</asp:LinkButton>
                        <asp:LinkButton runat="server" CommandArgument='<%#Eval("O_Id")%>'
                            CommandName="complete">complete</asp:LinkButton>
                        <asp:LinkButton runat="server" CommandArgument='<%#Eval("O_Id")%>'
                            CommandName="remove" OnClientClick="return confirm('Are you sure you want to delete this order?');">remove</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle CssClass="GridViewFooterStyle" />
            <RowStyle CssClass="GridViewRowStyle" />
            <PagerStyle CssClass="GridViewPagerStyle" />
            <HeaderStyle CssClass="GridViewHeaderStyle" />
            <AlternatingRowStyle CssClass="GridViewAlternatingRowStyle" />
        </asp:GridView>
    </p>
</asp:Content>

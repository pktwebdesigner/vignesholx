<%@ Page Title="" Language="C#" MasterPageFile="~/OLXMASTER.Master" AutoEventWireup="true" CodeBehind="HOME.aspx.cs" Inherits="OLXRESALEFE.HOME" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            color:black;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" RepeatColumns="3" RepeatDirection="Horizontal" style="margin-left: 350px" CellPadding="10" CellSpacing="20" GridLines="Both">
        <ItemTemplate>
            <table class="auto-style1" style="border-color:black;">
                <tr>
                    <td>
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="187px" ImageUrl='<%# "data:image/jpg;base64,"+Convert.ToBase64String((byte[])Eval("Images")) %>' Width="249px" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblamount" runat="server" Text='<%#"₹."+ Eval("Amount") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblyear" runat="server" Text='<%# Eval("YearofUsage") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td >
                        <asp:Label ID="lblname" runat="server" Text='<%# Eval("ItemName") %>'></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <br />
        </ItemTemplate>
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OLXRESALEConnectionString %>" SelectCommand="SELECT * FROM [Insert_Items]"></asp:SqlDataSource>
    </asp:Content>

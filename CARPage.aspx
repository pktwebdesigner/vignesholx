<%@ Page Title="" Language="C#" MasterPageFile="~/OLXMASTER.Master" AutoEventWireup="true" CodeBehind="CarPage.aspx.cs" Inherits="OLXRESALEFE.CarPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1">
        <ItemTemplate>
            <asp:ImageButton ID="Image1" runat="server" Height="245px" ImageUrl='<%# "data:image/jpg;base64,"+Convert.ToBase64String((byte[])Eval("Images")) %>' Width="293px" />
            <br />
            <br />
        </ItemTemplate>
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OLXRESALEConnectionString %>" SelectCommand="SELECT * FROM [Insert_Items] WHERE ([Categoryname] = @Categoryname)">
        <SelectParameters>
            <asp:Parameter DefaultValue="Cars" Name="Categoryname" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>

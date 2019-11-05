<%@ Page Title="" Language="C#" MasterPageFile="~/OLXMASTER.Master" AutoEventWireup="true" CodeBehind="SELLPAGE.aspx.cs" Inherits="OLXRESALEFE.SELLPAGE" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="http://code.jquery.com/jquery-1.10.2.min.js"></script>
   <script type="text/javascript">
        function imagepreview(input) {
            if (input.files && input.files[0]) {
                var fildr = new FileReader();
                fildr.onload = function (e) {
                    $('#<%=imgprw.ClientID%>').prop('src', e.target.result);
                };
                fildr.readAsDataURL(input.files[0]);
            }
        }
    </script>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 637px;
            margin-left:300px;
        }
        .auto-style2 {
            width: 50%;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" autopostback="false">
    
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblitemname" runat="server" Text="Item Name"></asp:Label>
                <br />
                <br />
                <asp:TextBox ID="txtitemname" runat="server" Height="38px" Width="324px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label1" runat="server" Text="Item Id"></asp:Label>
                <br />
                <br />
                <asp:TextBox ID="txtitemid" runat="server" Height="38px" Width="324px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblyearofusage" runat="server" Text="Year Of Usage"></asp:Label>
                <br />
                <br />
                <asp:TextBox ID="txtyearofusage" runat="server"  Height="38px" Width="324px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label2" runat="server" Text="Category Name"></asp:Label>
                <br />
                <br />
                <asp:DropDownList ID="ddcategory" runat="server" Height="38px" Width="324px">
                    <asp:ListItem Value="0">Select Category</asp:ListItem>
                    <asp:ListItem Value="1">Cars</asp:ListItem>
                    <asp:ListItem Value="2">Bkes</asp:ListItem>
                    <asp:ListItem Value="3">Furnitures</asp:ListItem>
                    <asp:ListItem Value="4">Mobiles&amp;Mobiles Accesories</asp:ListItem>
                    <asp:ListItem Value="5">Electronics &amp; Home Appliances</asp:ListItem>
                    <asp:ListItem Value="6">Books,Sports &amp; Hobbies</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblamount" runat="server" Text="Amount"></asp:Label>
                <br />
                <br />
                <asp:TextBox ID="txtamount" runat="server" Height="38px" Width="324px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lbluid" runat="server" Text="User ID"></asp:Label>
                <br />
                <br />
                <asp:TextBox ID="txtuid" runat="server" Height="38px" Width="324px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <br />
                <asp:FileUpload ID="fuimg" runat="server" Height="38px" Width="324px" onchange="imagepreview(this);" EnableViewState="true"/><br />
                
                <asp:Button ID="btnupload" runat="server" Text="Upload" OnClick="btnupload_Click" AutoPostBack="false"/>
                
                
                      
            </td>
            <td>
                <asp:Image ID="imgprw" runat="server" Height="177px" Width="234px" />
                <asp:Label ID="lblmessage" runat="server" Text="Label"></asp:Label>
            </td>
            </table >
              <table>
            <tr style="background-color:antiquewhite">
                <td class="auto-style2">
                    <asp:Button ID="btnpostnow" runat="server" BackColor="#33CCFF" style="margin-left: 484px" Text="Post Now" Width="500px" Height="52px" OnClick="btnpostnow_Click"/>
                </td>
        </tr>
    </table>
   
    

   
</asp:Content>

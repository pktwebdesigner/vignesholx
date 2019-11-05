<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LOGINPAGE.aspx.cs" Inherits="OLXRESALEFE.LOGINPAGE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width:400px;
            height:200px;
            border-collapse:collapse;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
            <table class="auto-style1" align="center">
                <tr>
                   
                    <td>
                        <asp:TextBox ID="txtuid" runat="server" placeholder="User Id" style="text-align: left; margin-left: 64px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*field is required" ForeColor="Red" ControlToValidate="txtuid"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtpass" runat="server" placeholder="Password" style="margin-left: 62px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*field is required" ForeColor="Red" ControlToValidate="txtpass"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnlogin" runat="server" OnClick="btnlogin_Click1" Text="LOGIN" style="margin-left: 65px" />
                        <asp:Label ID="lblMessage" runat="server"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                </table>
    </form>
</body>
</html>

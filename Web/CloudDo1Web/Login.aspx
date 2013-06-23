<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CloudDo1Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            width: 110px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 282px; width: 564px; margin:120px;margin-left:250px;background-color:#808080">

            <table style="width: 60%;">
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">UserMail</td>
                    <td>
                        <asp:TextBox ID="txtbxMail" runat="server" Width="186px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>
                        <asp:Label ID="Lblmsg" runat="server"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>

        </div>
    </form>
  
</body>
</html>

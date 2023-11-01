<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Assigment2_39909476.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 166px;
        }
        .auto-style3 {
            text-align: left;
            width: 237px;
        }
        .auto-style4 {
            width: 166px;
            text-align: center;
        }
        .auto-style5 {
            text-align: center;
            width: 237px;
        }
        .auto-style6 {
            width: 237px;
        }
        .auto-style7 {
            margin-left: 15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <link rel="stylesheet" href="style3.css" />
        <div class="muzieknootjes">
          <div class="noot-1">
          &#9835; &#9833;
        </div>
        <div class="noot-2">
          &#9833;
        </div>
        <div class="noot-3">
          &#9839; &#9834;
        </div>
        <div class="noot-4">
          &#9834;
        </div>
        </div>
        <br />
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<table style="width:100%;">
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style3">
        <asp:Calendar ID="Calendar1" runat="server" BackColor="Black" BorderColor="Black" BorderStyle="Solid" CellPadding="1" Font-Bold="True" ForeColor="White" CssClass="auto-style7" Width="828px"></asp:Calendar>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <br />
            <asp:Button ID="btnBack" runat="server" BorderColor="White" BorderStyle="Solid" ForeColor="White" Text="Back" OnClick="btnBack_Click" Width="234px" Height="39px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Label" style="text-align: center"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Label" Font-Bold="True"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>

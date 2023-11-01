<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PresentationButtons.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 163px;
        }
        .auto-style3 {
            margin-left: 0px;
        }
        .auto-style4 {
            width: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" ForeColor="Black" Text="Choose a music instrument:"></asp:Label>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Violin" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="Button2" runat="server" CssClass="auto-style3" OnClick="Button2_Click" Text="Viola" />
                </td>
                <td>&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Cello" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Book lesson:" Width="157px" />
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <p>
            <asp:Label ID="lblShow" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>

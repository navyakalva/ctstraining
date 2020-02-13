<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="aspdemopage.aspx.cs" Inherits="Aspwebform.aspdemopage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" />
        <br /><br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <br /><br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br /><br />
    </form>
    
    </body>

</html>

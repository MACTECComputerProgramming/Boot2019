<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color: #33CC33">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #FFFFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2>File Storage Application</h2>
        File Path:
        <asp:TextBox ID="txtBxFilePath" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btnCreate" runat="server" OnClick="btnCreateFile_Click" 
            Text="Create File" />
        &nbsp;<asp:Label ID="lblInstructions" runat="server"></asp:Label>
        <br />
        <br />
        First Name:<asp:TextBox ID="txtBxFirst" runat="server" 
            Enabled="False"></asp:TextBox>
        <br />
        <br />
        Last Name:<asp:TextBox ID="txtBxLast" runat="server" Enabled="False"></asp:TextBox>
        <br />
        <br />
        Email:<asp:TextBox ID="txtBxEmail" runat="server" 
            Enabled="False"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnStore" runat="server" style="text-align: center" 
            Text="Store Data in File" OnClick="btnStore_Click" Enabled="False"  />
    
        <br />
        <br />
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #FF0066;
            font-size: large;
            z-index: 1;
            left: 219px;
            top: 253px;
            position: absolute;
        }
        .auto-style2 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #00FF00">
    <div style="font-size: xx-large; font-weight: bold; color: #FFFFFF;">
    
        To Do... List Creator<br />
    
    </div>
        <p style="background-color: #00FF00">
            Enter your name to create your own personalized TO DO list!<br />
            <br />
            Name:
            <asp:TextBox ID="txtBxName" runat="server" Width="203px"></asp:TextBox>
        </p>
        <p style="background-color: #00FF00">
            Item for the list:
            <asp:TextBox ID="txtBxItem" runat="server"></asp:TextBox>
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" 
                Text="Add to my list" />
        </p>
        <p style="background-color: #00FF00">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <span class="auto-style2">To Do List</span></p>
        <asp:ListBox ID="lstBoxToDo" runat="server" AutoPostBack="True" 
            Font-Size="Medium" OnSelectedIndexChanged="lstBoxToDo_SelectedIndexChanged" 
            style="z-index: 1; left: 5px; top: -12px; position: relative; height: 87px; right: -199px" 
            Width="194px"></asp:ListBox>
&nbsp;<span class="auto-style1">Select items form list to remove them.</span><br />
        <asp:Label ID="lblOutput" runat="server" style="font-size: large"></asp:Label>
    </form>
</body>
</html>

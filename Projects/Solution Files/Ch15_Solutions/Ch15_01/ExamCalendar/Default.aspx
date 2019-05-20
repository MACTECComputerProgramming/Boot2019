<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color: #CCFF33">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #CCFF33">
    <div>
    
        <h2 class="auto-style1">Exam Scheduler</h2>
        <p class="auto-style1">
            <asp:Calendar ID="Calendar1" runat="server" Height="263px" 
                OnSelectionChanged="Calendar1_SelectionChanged" 
                style="z-index: 1; left: -3px; top: 5px; position: relative; height: 263px; width: 372px" 
                Width="372px"></asp:Calendar>
        </p>
        <p class="auto-style1">
            <asp:Label ID="lblResult" runat="server" 
                style="color: #009900; font-weight: 700">When is the Next Exam? Make Selection on Calendar...</asp:Label>
        </p>
        </div>
    </form>
</body>
</html>

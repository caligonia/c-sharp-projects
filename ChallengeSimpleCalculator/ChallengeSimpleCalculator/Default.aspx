<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-size: 18px">
            <h1>Simple Calculator</h1>
            <span class="auto-style1">First Value: </span>&nbsp;<asp:TextBox ID="firstNumberTextBox" runat="server"></asp:TextBox>
            <br />
            <span class="auto-style1">Second Value: </span>&nbsp;<asp:TextBox ID="secondNumberTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="plusButton" runat="server" BackColor="#CCCCCC" OnClick="plusButton_Click" Text="+" Width="30px" />
&nbsp;
            <asp:Button ID="subtractButton" runat="server" BackColor="#CCCCCC" OnClick="subtractButton_Click" Text="-" Width="30px" />
&nbsp;
            <asp:Button ID="multiplyButton" runat="server" BackColor="#CCCCCC" OnClick="multiplyButton_Click" Text="*" Width="30px" />
&nbsp;
            <asp:Button ID="divideButton" runat="server" BackColor="#CCCCCC" OnClick="divideButton_Click" Text="/" Width="29px" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server" BackColor="#3399FF" Font-Size="Larger"></asp:Label>
        </div>
    </form>
</body>
</html>

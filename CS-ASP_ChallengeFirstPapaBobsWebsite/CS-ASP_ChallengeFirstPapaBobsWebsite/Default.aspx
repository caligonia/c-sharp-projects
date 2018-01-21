<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_ChallengeFirstPapaBobsWebsite.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style3 {
            width: 200px;
            height: 200px;
        }
        .auto-style4 {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1><span class="auto-style2">
                <img alt="" class="auto-style3" src="PapaBob.png" />Papa Bob&#39;s Pizza and Software</span></h1>
        </div>
        <asp:RadioButton ID="smallRadioButton" runat="server" GroupName="sizeGroup" Text="Baby Bob Size (10&quot;) - $ 10" />
        <br />
        <asp:RadioButton ID="mediumRadioButton" runat="server" GroupName="sizeGroup" Text="Mama Bob Size (13&quot;) - $ 13" />
        <br />
        <asp:RadioButton ID="largeRadioButton" runat="server" GroupName="sizeGroup" Text="Papa Bob Size (13&quot;) - $ 16" />
        <br />
        <br />
        <asp:RadioButton ID="thinRadioButton" runat="server" GroupName="crustGroup" Text="Thin Crust" />
        <br />
        <asp:RadioButton ID="deepRadioButton" runat="server" GroupName="crustGroup" Text="Deep Dish (+$2)" />
        <br />
        <br />
        <asp:CheckBox ID="pepperoniCheckBox" runat="server" Text="Pepperoni (+$1.50)" />
        <br />
        <asp:CheckBox ID="onionsCheckBox" runat="server" Text="Onions (+$0.75)" />
        <br />
        <asp:CheckBox ID="greenPeppersCheckBox" runat="server" Text="Green Peppers (+$0.50)" />
        <br />
        <asp:CheckBox ID="redPeppersCheckBox" runat="server" Text="Red Peppers (+$0.75)" />
        <br />
        <asp:CheckBox ID="anchoviesCheckBox" runat="server" Text="Anchovies (+$2)" />
        <h3 class="auto-style2">Papa Bob&#39;s <span class="auto-style4">Special Deal</span></h3>
        Save $2.00 when you add Pepperoni, Green Peppers, and Anchovies OR Pepperoni, Red Peppers, and Onoins to your pizza.<br />
        <br />
        <asp:Button ID="purchaseButton" runat="server" OnClick="purchaseButton_Click" Text="Purchase" />
        <br />
        <br />
        Total:&nbsp;
        <asp:Label ID="totalLabel" runat="server" Text="$0.00"></asp:Label>
        <br />
        <br />
        Sorry, at this time you can only order one pizza, and pick-up only ... we need a better website!</form>
</body>
</html>

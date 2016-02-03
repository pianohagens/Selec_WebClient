<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SelectWebClient</title>
</head>
<body>
    <form id="form1" runat="server" >
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server" ></asp:DropDownList>
      
        <asp:GridView ID="GridView1" runat="server" ></asp:GridView>
       <asp:Button ID="Button1" runat="server" Text="Get Shows" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
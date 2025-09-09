<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My First App</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

          
            NAME:&nbsp;&nbsp;&nbsp;&nbsp; <input id="NameText" name="NameText" type="text" />
            <br />
          <%-- PASSWORD :
            <input id="Text2" type="text" /><br />
            <br />--%>
           Password: <asp:TextBox ID="PasswordText" runat="server" />
            <br/>
            
            <asp:Button ID="SubmitButton" runat="server"  Text="SUBMIT" />
            <input id="SaveButton" type="button" value="SAVE" /></div>
    </form>
</body>
</html>

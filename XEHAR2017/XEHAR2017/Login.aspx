<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="XEHAR2017.Login" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
  <form id="Form1" runat="server">
<fieldset>
<legend>Login</legend> 
<div class='container'>
<asp:Label ID="Name" runat="server" Text="UserName:" CssClass="lbl"/>
<br/>
<asp:TextBox ID="txtUserName" runat="server" Height="22px"/>
<asp:RequiredFieldValidator ID="RV1" runat="server" 
                            ControlToValidate="txtUserName" 
                            ErrorMessage="Please Enter User Name" 
                            SetFocusOnError="True">*
</asp:RequiredFieldValidator><br />
</div>
 
<div class='container'>
   
<asp:Label ID="lblPwd" runat="server" Text="Password:" CssClass="lbl"/>
<br/>
<asp:TextBox ID="txtPwd" runat="server" TextMode="Password" 
                         CssClass="pwd" Height="22px"/>
<asp:RequiredFieldValidator ID="RV2" runat="server" 
                            ControlToValidate="txtPwd" 
                            ErrorMessage="Your Password" 
                            SetFocusOnError="True">*
</asp:RequiredFieldValidator><br />
</div>
 
<div class='container'>
<asp:Button ID="btnLogIn" runat="server" Text="Sign In" 
                          onclick="btnLogIn_Click"/>
</div>
                       
<div class='container'>
<asp:HyperLink ID="HyperLink1" runat="server" 
NavigateUrl="~/ForgotPassword.aspx">Forgot Password ?</asp:HyperLink>
<br/>
</div>
<div class='short_explanation'>New User ? 
<asp:HyperLink ID="HyperLink2" runat="server" 
NavigateUrl="~/SignUp.aspx">SignUp !</asp:HyperLink></div>                       
<asp:ValidationSummary ID="ValidationSummary1" 
                       runat="server" CssClass="error"/>
<br /><br />
<asp:Label ID="lblMsg" runat="server" Text="" CssClass="lbl"/>
</fieldset>
</form>
</body>
</html>
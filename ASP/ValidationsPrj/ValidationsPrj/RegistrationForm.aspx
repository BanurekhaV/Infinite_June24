<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="ValidationsPrj.RegistrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 324px;
            margin-left: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <h1 style="color:blue;font-size:20px;text-align:center;">Registration Form</h1>
            <br />
            Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;  
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                ControlToValidate="txtname" ErrorMessage="Name Cannot be Blank" ForeColor="Red" ValidationGroup="R">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; 
            <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="txtpass" ErrorMessage="Please Enter Password" ForeColor="Red" ValidationGroup="R">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Confirm Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtconfpass" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
           ControlToValidate="txtconfpass" Display="Dynamic" ErrorMessage="Confirm password is a must" 
          ForeColor="Red" ValidationGroup="R">*</asp:RequiredFieldValidator>
&nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server"
    ControlToCompare="txtpass" ControlToValidate="txtconfpass" Display="Dynamic" ErrorMessage="Password and Confirm password mismatch" ForeColor="Red" ValidationGroup="R">*</asp:CompareValidator>
            <br /><br />
            Age &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
         ControlToValidate="txtAge" Display="Dynamic" ErrorMessage="Please give value for Age" ForeColor="Red" ValidationGroup="R">*</asp:RequiredFieldValidator>
&nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server" 
    ControlToValidate="txtAge" Display="Dynamic" ErrorMessage="Age should be between 21 and 40" ForeColor="Red" MaximumValue="40" MinimumValue="21" Type="Integer" ValidationGroup="R">*</asp:RangeValidator>
            <br /><br />
            Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtemail" Display="Dynamic" ErrorMessage="Email is Required" ForeColor="Red" ValidationGroup="R">*</asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtemail" Display="Dynamic" ErrorMessage="Invalid Email Format, Enter again" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="R">*</asp:RegularExpressionValidator>
            <br /><br />
            <asp:Button ID="BtnSubmit" runat="server" Text="Validate" OnClick="BtnSubmit_Click" ValidationGroup="R" />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="R"  />
        </div>
        <br />
        <br />

       <div>
           <h1 style="color:navy;font-size:20px;text-align:center;">Login Form</h1>

         
           <br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           Login Name  : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:TextBox ID="txtlogin" runat="server"></asp:TextBox>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Please Enter Login Name" ControlToValidate="txtlogin" ForeColor="Red" ValidationGroup="L">*</asp:RequiredFieldValidator>
           <br /><br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           Password  : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
           <asp:TextBox ID="txtpwd" runat="server"></asp:TextBox>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Password is required" ControlToValidate="txtpwd" ForeColor="Red" ValidationGroup="L">*</asp:RequiredFieldValidator>
           <br /><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:Button ID="BtnLogin" runat="server" Text="Login" OnClick="BtnLogin_Click" ValidationGroup="L" />
           <br />
           <br />
           <asp:ValidationSummary ID="ValidationSummary2" runat="server" ForeColor="Red" ValidationGroup="L"  />
       </div>
    </form>
</body>
</html>

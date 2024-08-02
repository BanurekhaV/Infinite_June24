<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Custom.aspx.cs" Inherits="ValidationsPrj.Custom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function IsEven(source, args) {
            if (args.Value == "") {
                args.IsValid = false;
            } else {
                if ((args.Value > 0) && (args.Value % 2 == 0)) {
                    args.IsValid = true;
                } else {
                    args.IsValid = false;
                }
            }
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Enter a Positive Even Number : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtnum" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtnum"
            ErrorMessage="Not a Positive or an Even Number" ForeColor="Red" 
           ClientValidationFunction="IsEven" OnServerValidate="CustomValidator1_ServerValidate" ValidateEmptyText="True"></asp:CustomValidator>
            <br />
            <br />
            <asp:Button ID="Btnsave" runat="server" Text="Save" OnClick="Btnsave_Click" />
            <br />
            <br />
            <asp:Label ID="lblmessage" runat="server" Text=" "></asp:Label>
        </div>
    </form>
</body>
</html>

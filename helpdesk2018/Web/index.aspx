<!DOCTYPE html>
<script runat="server">

    Protected Sub Login1_Authenticate(sender As Object, e As AuthenticateEventArgs)

    End Sub
</script>


<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title></title>
</head>
<body>
    <center>
    <form id="form1" runat="server">
&nbsp;<asp:Login ID="Login1" runat="server" BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" Height="299px" OnAuthenticate="Login1_Authenticate" Width="305px" LoginButtonText="Entrar" style="text-align: left; font-size: medium" TitleText="Help Desk - PIM4">
            <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
        </asp:Login>
    </form>
</center>
</body>
</html>
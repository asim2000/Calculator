<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="Calculator.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css"/>

    <title></title>
    <style>
        table{
           // background:repeating-linear-gradient(red,blue,green,black);
           box-shadow: 10px 5px 5px gray;
        }
        
    </style>
</head>
<body>
    <div class="container mt-5">
        <div class="row justify-content-center">
            <div class="col-4">
                <form runat="server">
                    <asp:TextBox ID="num1" Visible="false" runat="server"></asp:TextBox>
                    <asp:TextBox ID="num2" Visible="false" runat="server"></asp:TextBox>
                    <table class="table table-bordered bg-dark">
                       <thead>
                           <tr>
                               <th colspan="4"><asp:Label ID="label1" runat="server" CssClass="text-white" style="padding-left:200px;"></asp:Label> </th>
                           </tr>
                           <tr>
                               <th colspan="4">
                                   <asp:TextBox ID="textBox1" ReadOnly="true" CssClass="form-control text-right my-2 bg-muted" runat="server"></asp:TextBox>
                               </th>
                           </tr>
                       </thead>
                        <tbody>
                            <tr>
                                <td><asp:Button Text="C" runat="server" CssClass="btn btn-primary w-100" OnClick="Unnamed1_Click1" /></td>
                                <td><asp:Button Text="<" runat="server" CssClass="btn btn-primary w-100" OnClick="Unnamed2_Click" /></td>
                                <td><asp:Button Text="." runat="server" CssClass="btn btn-primary w-100" OnClick="Unnamed3_Click" /></td>
                                <td><asp:Button Text="+" runat="server" CssClass="btn btn-primary w-100" OnClick="Unnamed4_Click" /></td>
                            </tr>
                            <tr>
                                <td><asp:Button Text="1" runat="server" CssClass="btn btn-primary w-100" OnClick="Unnamed5_Click" /></td>
                                <td><asp:Button Text="2" runat="server" CssClass="btn btn-primary w-100" OnClick="Unnamed6_Click" /></td>
                                <td><asp:Button Text="3" runat="server" CssClass="btn btn-primary w-100" OnClick="Unnamed7_Click" /></td>
                                <td><asp:Button Text="/" runat="server" CssClass="btn btn-primary w-100" OnClick="Unnamed8_Click" /></td>
                            </tr>
                            <tr>
                                <td><asp:Button Text="4" runat="server" CssClass="btn btn-primary w-100" OnClick="Unnamed9_Click" /></td>
                                <td><asp:Button Text="5" runat="server" CssClass="btn btn-primary w-100" OnClick="Unnamed10_Click" /></td>
                                <td><asp:Button Text="6" runat="server" CssClass="btn btn-primary w-100" OnClick="Unnamed11_Click" /></td>
                                <td><asp:Button Text="X" runat="server" CssClass="btn btn-primary w-100" OnClick="Unnamed12_Click" /></td>
                            </tr>
                            <tr>
                                <td><asp:Button ID="yeddi" Text="7" runat="server" CssClass="btn btn-primary w-100" OnClick="Unnamed13_Click" /></td>
                                <td><asp:Button Text="8" runat="server" CssClass="btn btn-primary w-100" OnClick="Unnamed14_Click" /></td>
                                <td><asp:Button type="button" Text="9" runat="server" CssClass="btn btn-primary w-100" OnClick="Unnamed15_Click" /></td>
                                <td><asp:Button type="button" Text="-" runat="server" CssClass="btn btn-primary w-100" OnClick="Unnamed16_Click" /></td>
                            </tr>
                            <tr>
                                <td><asp:Button type="button" Text="+/-" runat="server" CssClass="btn btn-primary w-100" OnClick="Unnamed17_Click" /></td>
                                <td><asp:Button type="button" Text="0" runat="server" CssClass="btn btn-primary w-100" OnClick="Unnamed18_Click" /></td>
                                <td colspan="2"><asp:Button Text="=" runat="server" CssClass="btn btn-primary w-100" OnClick="Unnamed19_Click" /></td>
                                </tr>
                        </tbody>
                    </table>
                </form>
            </div>
            
        </div>
    </div>
    <script>
        //document.querySelector("table").addEventListener("click", (e) => {
        //    e.preventDefault();
        //});
    </script>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XmlTable.aspx.cs" Inherits="TodoASMXService.XmlTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ROI Staff Details</title>
</head>
<body>
    <div class="jumbotron">
        <h1 style="font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif; font-size:20px"><a href="TodoService.asmx">Navigate to admin menu</a></h1>
        <div style="margin:20px;border:2px solid black; display:inline-block">
        <asp:Xml ID ="StaffXML" runat ="server"></asp:Xml>
        </div>
        <div style="margin:20px; border:2px solid black; display:inline-block">
        <asp:Xml ID ="DepartmentXML" runat ="server"></asp:Xml>
        </div>
    </div>
</body>
</html>

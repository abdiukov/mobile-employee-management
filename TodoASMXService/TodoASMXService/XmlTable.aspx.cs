using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TodoASMXService
{
    public partial class XmlTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StaffXML.DocumentContent = File.ReadAllText(Server.MapPath("people.xml"));
            StaffXML.TransformSource = Server.MapPath("people.xslt");

            DepartmentXML.DocumentContent = File.ReadAllText(Server.MapPath("datadoc.xml"));
            DepartmentXML.TransformSource = Server.MapPath("datadoc.xslt");
        }
    }
}
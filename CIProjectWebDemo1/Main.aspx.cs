using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIProjectWebDemo1
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(GetLoadDate());
            Response.End();
        }

        public string GetLoadDate()
        {
            return "这是一个测试页面";
        }
    }
}
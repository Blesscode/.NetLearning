using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //capture name from html controllers
            String UserName= Request.QueryString["NameText"];

            //capture password from asp controllers
            String UserPassword = PasswordText.Text;


            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApDataOperations
{
    public partial class WebFormdata : System.Web.UI.Page
    {
        //Page_Load is event-handler.
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                ADOlayer al = new ADOlayer();
                var stlist = al.Getallrecords();
                GridView1.DataSource = stlist;
                GridView1.DataBind();

            }

        }
        public static void GetData()
        {

        }
    }
}
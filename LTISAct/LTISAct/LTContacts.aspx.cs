using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LTISAct
{
    public partial class LTContacts  : Act.Web.Framework.Page
    {
        protected override void OnPreInit(EventArgs e)
        {
            //change the Master Page affiliation
            //this.MasterPageFile = "/APFW/MasterPages/MasterPage.master";
            //base.OnPreInit(e);
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            //this.MasterPageFile = "~/MasterPages/ListViewMasterPage.master";
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write("Hello2");
        }

    }
}
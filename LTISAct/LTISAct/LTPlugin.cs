
using Act.Web.Framework;
using Act.Web.Framework.Core.Layouts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LTISAct
{
    public class LTPlugin : IWebPlugin
    {
        public void Init(ACTSessionManager session)
        {
            //string currentUserID = session.Framework.CurrentUser.ID.ToString();
            //string content = @"<input type=""hidden"" id=""LTCurrentUserID"" value=""" + currentUserID + @"""><span id=""spnCount"" style=""color: red; font-size: 12pt; font-weight: bold; text-decoration: underline;""></span>";
            //session.Menu.Items.Add("LTContacts", content, ActionType.None, "", true);

            session.NavBar.AddCustomNavBarItemProvider(new CustomNavBarItemProvider(this.ServeCustomTodayNavBarItem));

        }

        private bool ServeCustomTodayNavBarItem(ACTSessionManager session, out string id, out string action, out string cssclass, out string imageUrl, out string width, out string height, out string caption)
        {
            //adding a custom entry to the navigation bar

            //the custom navigation bar item id
            id = "LTC";
            //the action to perform when clicking on the custom navigation item
            action = "SaveAndNavigate(\"" + session.AppPath + "Plugins/LTContacts.aspx\");";
            //css class
            cssclass = "hand";
            //the URL to the image to use in the custom navigation bar item
            imageUrl = session.AppPath + "Plugins/LTIcon.ico";
            //dimensions
            width = "16";
            height = "16";
            //the caption on the item
            caption = @"Web Inquries <span id=""LTContactCount"" style=""color: red; font-size: 10pt; font-weight: bold;""></span>";
            //return true to tell the provider to process this info and generate the custom navigation bar item
            return true;
        }
    }
}
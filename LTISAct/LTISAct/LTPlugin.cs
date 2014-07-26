﻿using Act.Web.Framework;
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
            int newContacts = GetNewContactsCount();
            if (newContacts > 0)
            {
                string caption = @"<span style=""color: red; font-size: 12pt; font-weight: bold; text-decoration: underline;"" onclick=""location.href = '/APFW/plugins/LTContacts.aspx'"">YOU HAVE " + newContacts.ToString() + " UNFINISHED TASKS</span>";
                session.Menu.Items.Add("LTContacts", caption, ActionType.None, "", true);
            }

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
            caption = "Web Inquries";
            //return true to tell the provider to process this info and generate the custom navigation bar item
            return true;
        }

        private int GetNewContactsCount()
        {
            //getting the contact count from database
            string connectionString = ConfigurationManager.ConnectionStrings["LTConnectionString"].ConnectionString;
            string cmdText = "SELECT COUNT(*) FROM Contact";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}
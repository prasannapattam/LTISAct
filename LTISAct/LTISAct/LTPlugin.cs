using Act.Web.Framework;
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
//This is a source code or part of OpenMiracle project
//Copyright (C) 2013  Cybrosys Technologies Pvt.Ltd
//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.
//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.
//You should have received a copy of the GNU General Public License
//along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.ServiceProcess;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.Diagnostics;
using System.Threading;
using System.Configuration;

//<summary>    
//Summary description for DBConnection    
//</summary>    
namespace Profunia.Inventory.Desktop.ClassFiles.General
{
    public class DBConnection
    {
        protected SqlConnection sqlcon;

        protected string serverName = (ConfigurationManager.AppSettings["MsSqlServer"] == null || ConfigurationManager.AppSettings["MsSqlServer"].ToString() == string.Empty) ? null : ConfigurationManager.AppSettings["MsSqlServer"].ToString();

        protected string userId = (ConfigurationManager.AppSettings["MsSqlUserId"] == null || ConfigurationManager.AppSettings["MsSqlUserId"].ToString() == string.Empty) ? null : ConfigurationManager.AppSettings["MsSqlUserId"].ToString();

        protected string password = (ConfigurationManager.AppSettings["MsSqlPassword"] == null || ConfigurationManager.AppSettings["MsSqlPassword"].ToString() == string.Empty) ? null : ConfigurationManager.AppSettings["MsSqlPassword"].ToString();

        protected string ApplicationPath = (ConfigurationManager.AppSettings["ApplicationPath"] == null || ConfigurationManager.AppSettings["ApplicationPath"].ToString() == string.Empty) ? null : ConfigurationManager.AppSettings["ApplicationPath"].ToString();

        protected string isSqlServer = (ConfigurationManager.AppSettings["isServerConnection"] == null || ConfigurationManager.AppSettings["isServerConnection"].ToString() == string.Empty) ? null : ConfigurationManager.AppSettings["isServerConnection"].ToString();

        public DBConnection()
        {
            SqlConnection.ClearAllPools();
            string path = string.Empty;
            path = ((!(PublicVariables._decCurrentCompanyId > 0m)) ? ((!(PublicVariables._decCurrentCompanyId == 0m)) ? (ApplicationPath + "\\Data\\COMP\\DBOpenmiracle.mdf") : (ApplicationPath + "\\Data\\DBOpenmiracle.mdf")) : (ApplicationPath + "\\Data\\" + PublicVariables._decCurrentCompanyId + "\\DBOpenmiracle.mdf"));
            if (serverName != null)
            {
                if (isSqlServer != null)
                {
                    if (userId == null || password == null)
                    {
                        sqlcon = new SqlConnection("Data Source=" + serverName + ";AttachDbFilename=" + path + ";Integrated Security=True;Connect Timeout=120");
                    }
                    else
                    {
                        sqlcon = new SqlConnection("Data Source=" + serverName + ";AttachDbFilename=" + path + ";user id='" + userId + "';password='" + password + "'; Connect Timeout=120");
                    }
                }
                else if (userId == null || password == null)
                {
                    sqlcon = new SqlConnection("Data Source=" + serverName + ";AttachDbFilename=" + path + ";Integrated Security=True;Connect Timeout=120;User Instance=True");
                }
                else
                {
                    sqlcon = new SqlConnection("Data Source=" + serverName + ";AttachDbFilename=" + path + ";user id='" + userId + "';password='" + password + "'; Connect Timeout=120; User Instance=False");
                }
                try
                {
                    sqlcon.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

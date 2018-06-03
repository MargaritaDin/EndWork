using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2
{
    class LoginService
    {
        public bool Login(string login, string password)
        {
            if (IsValidUser(login, password))
            {
                ApplicationState.CurrentUser = DbCommunication.GetUser(login);
                return true;
            }
            return false;
        }

        public void LogOut()
        {
            ApplicationState.CurrentUser = null;
        }

        public bool IsValidUser(string login, string password)
        {
            string dbPassword = GetPasswordByUser(login);
            return dbPassword == password.GetHashCode().ToString();
        }

        public string GetPasswordByUser(string login)
        {
            if (string.IsNullOrWhiteSpace(login))
                return string.Empty;

            DataTable dataTable = DbCommunication.PullData(login);

            if (dataTable.Rows.Count == 0)
                return string.Empty;

            int firtstRowIndex = 0;
            int passwordColumnIndex = 0;
            return dataTable.Rows[firtstRowIndex][passwordColumnIndex].ToString();
        }
    }
}

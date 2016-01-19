using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;

namespace PCView
{
    class Usuario
    {
        public String getLoggedUserName()
        {

            DirectoryEntry directoryEntry = new DirectoryEntry("WinNT://" + Environment.UserDomainName + "/" + Environment.UserName);

            string loggedUserName = directoryEntry.Properties["fullName"].Value.ToString();

            return loggedUserName;
        }

        public String getLoggedUser()
        {
            string loggedUser = Environment.UserName;

            return loggedUser;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class User
    {
        private string user;
        private string password;

        public User(string user, string password)
        {
            this.user = user;
            this.password = password;
        }

        public string GetUser()
        {
            return this.user;
        }

        public bool CheckPassword(string password)
        {
            if (this.password == password)
            {
                return true;
            }

            return false;
        }

        public void SetUser(string user)
        {
            this.user = user;
        }

        public void SetPassword(string password)
        {
            this.password = password;
        }
    }
}

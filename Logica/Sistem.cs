using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class Sistem
    {
        static User[] registeredUsers;

        static Sistem()
        {
            registeredUsers = new User[8];
            HardcodeUsers();
        }

        private static void HardcodeUsers()
        {
            registeredUsers[0] = new User("XxXgonzaXxX", "gonza123");
            registeredUsers[1] = new User("ZLeandritoZ", "LEO");
            registeredUsers[2] = new User("Merce", "Merce2409");
            registeredUsers[3] = new User("Fort", "RicarditoFort");
            registeredUsers[4] = new User("Boyka", "Undisputed");
        }

        private static int FindEmptyPosition()
        {
            for (int i = 0; i < registeredUsers.Length; i++)
            {
                if (registeredUsers[i] == null)
                {
                    return i;
                }
            }

            return -1;
        }

        public static bool RegisterNewUser(string user, string password)
        {
            int i = FindEmptyPosition();

            if(i != -1)
            {
                registeredUsers[i] = new User(user, password);
                return true;
            }

            return false;
        }

        private static int MatchUser(string user, string password)
        {
            for (int i = 0; i < registeredUsers.Length; i++)
            {
                if (registeredUsers[i] != null && user.Trim() == registeredUsers[i].GetUser().Trim())
                {
                    if (registeredUsers[i].CheckPassword(password))
                    {
                        return 1;
                    }
                    return 0;
                }
            }

            return -1;
        }

        public static bool CheckAccess(string user, string password, out int status)
        {
            status = -1;
            if(string.IsNullOrEmpty(user.Trim()) || string.IsNullOrEmpty(password.Trim()))
            {
                return false;
            }

            status = MatchUser(user, password);
            if(status == 1)
            {
                return true;
            }

            return false;
        }

        public static bool ChangeUser(string user, string password)
        {
            if(CheckAccess(user, password))
            {

            }
        }





    }
}

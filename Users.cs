using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFromDemoExam
{
    public class Users
    {
        public string login;
        public string password;
        public string username;
        public string role;
    }
    public static class Lists
    {
        public static List<Users> Users = new List<Users>
        {
            new Users()
            {
                login = "Admin",
                password = "Admin",
                username = "Админов Админ Админович",
                role = "Admin"
            },
            new Users()
            {
                login = "Manager",
                password = "Manager",
                username = "Менеджеров Менеджер Менеджерович",
                role = "User"
            },
            new Users()
            {
                login = "User",
                password = "User",
                username = "Юрезов Юзер Юзерович",
                role = "User"
            }
        };
        
    }
}

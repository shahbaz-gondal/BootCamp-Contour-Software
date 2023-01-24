using LoginForm_with_mvc.Models;
using System.Reflection;

namespace LoginForm_with_mvc.Services
{
    public class Login_RegisterService
    {
        private static List<Login_RegisterModel> _LoginInfo = new List<Login_RegisterModel>();
        public static bool ValidateUser(Login_RegisterModel model)
        {
            bool found = false;
            foreach (var login in _LoginInfo)
            {
                if (login.Email == model.Email && login.Password == model.Password)
                {
                    found = true;
                    break;
                }
            }
            if (found == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Add(Login_RegisterModel model)
        {
            _LoginInfo.Add(model);
        }
        public static String FindPassword(String u_email)
        {
            foreach (var login in _LoginInfo)
            {
                if(login.Email == u_email)
                {
                    return login.Password;
                }
            }
            return "invalid";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcces;
using Common.Cache;

namespace Domain
{
    public class UserModel
    {
        User userData = new User();

        public bool LoginUser(string user, string pass)
        {
            return userData.Login(user, pass);
        }

        public void AnyMethod()
        {
            if(cacheUsuario.rol== "supervisor")
            {
                //code..
            }
            if(cacheUsuario.rol=="cajero")
            {
                //code...
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class user
    {
        public int idUser { get; set; }
        public string Login, Password;

        public user() { }



        public user (string Login,string Password)
        {
            this.Login = Login;
            this.Password = Password;
        }



    }
}

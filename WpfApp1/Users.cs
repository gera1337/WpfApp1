using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class users
    {
        private int idUser { get; set; }
        private int Idroles { get; set; }
        private string login;
        private string password;
        public users() { }

        public users( string login, string password)
        {
            
            this.login = login;
            this.password = password;
        }

    }
}

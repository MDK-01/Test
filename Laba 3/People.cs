using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApplicationExample
{
    public class People
    {
        private string login;
        private string password;
        private string email;
        private string phone;


        public People (string login, string password, string email, string phone)
        {
            this.login = login;
            this.password = password;
            this.email = email;
            this.phone = phone;
        }

        public string login1 { get => login; set => login = value; }
        public string password1 { get => password; set => password = value; }
        public string email1 { get => email; set => email = value;}
        public string phone1 { get => phone; set => phone = value; }


    }
}

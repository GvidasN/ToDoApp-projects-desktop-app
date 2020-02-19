using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lb_graphical_interface
{
    class Company : User
    {
        private String title;

        public Company(String login, String password, String email, String title) : base (login, password, email)
        {   
            this.title = title;
        }

        public override String ToString()
        {
            return getId() + ".;" + getLogin() + ";" + title + '\n';
        }
    }
}

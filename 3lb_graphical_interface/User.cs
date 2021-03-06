﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lb_graphical_interface
{
    class User
    {
        private int id;
        private String login, password, email;
        private static int idAdder = 1;
        private bool active = true;
        private List<Project> projects = new List<Project>();

        public User(String login, String password, String email)
        {
            this.login = login;
            this.password = password;
            this.email = email;
            this.id = idAdder;
            idAdder++;
        }
 
        public override String ToString()
        {
            return id + ". {" + login + ", " + password + "}, email = " + email;
        }

        public int getId()
        {
            return id;
        }

        public String getLogin()
        {
            return login;
        }

        public void setLogin(String login)
        {
            this.login = login;
        }
    }
}

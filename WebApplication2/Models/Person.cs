using System;

namespace _3lb_graphical_interface
{
    class Person : User
    {
        public String name { get; set; }
        public String surname { get; set; }

        public Person(String login, String password, String name, String surname, String email) : base(login, password, email)
        {
            this.name = name;
            this.surname = surname;
        }

        public override String ToString()
        {
            return getId() + ".;" + getLogin() + ";" + name + ";" + surname + "\n";
        }
    }
}

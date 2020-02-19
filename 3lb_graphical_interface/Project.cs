using System;

namespace _3lb_graphical_interface
{
    class Project
    {
        private String title;

        public Project(String title, string creator)
        {
            this.title = title;
        }
   
        public override String ToString()
        {
            return title;
        }
    }
}

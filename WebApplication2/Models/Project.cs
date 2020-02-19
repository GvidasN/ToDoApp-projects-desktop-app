using System;

namespace _3lb_graphical_interface
{
    class Project
    {
        public String title { get; set; }

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

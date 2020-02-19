using System;

namespace _3lb_graphical_interface
{
    class Task
    {
        private int id;
        private static int idAdder = 1;
        private String title;
        private string createdBy;
        private string project;

        public Task(String title, string createdBy, string p)
        {
            this.title = title;
            this.createdBy = createdBy;
            this.id = idAdder;
            idAdder++;
            this.project = p;
        }

    
        public override String ToString()
        {
            return title;
        }
    }
}

using System;

namespace _3lb_graphical_interface
{
    class Task
    {
        public int id { get; set; }
        private static int idAdder = 1;
        public String title { get; set; }
        public string createdBy { get; set; }
        public string project { get; set; }

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

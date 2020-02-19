using _3lb_graphical_interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WebApplication2
{
    public partial class About : Page
    {
        Form1 form;
        protected void Page_Load(object sender, EventArgs e)
        {
            form = new Form1();
            form.Show();
        }
    }
}
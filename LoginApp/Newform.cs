using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Newform : Form
    {

        public Newform()
        {
            InitializeComponent();
            

            foreach (Program.User user in Program.people)
            {
                string u = user.username; //u variable is the username enter each time someone logs in
                lboxLoggedIn.Items.Add(u + " " + DateTime.Now); //adds the user name and the time they logged in into the list box
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close(); //closes Newform
        }

    }
}

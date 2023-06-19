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
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            Program.User newUser = new Program.User(); // newUser object so "class user"  in program.cs can be used in this form

            newUser.username = txtuserid.Text; //sets whas entered in userid text box as username variable
            newUser.password = txtpassword.Text; //sets whas entered in password text box as password variable
            newUser.secQuestion = cboxsecurity.Text; //sets whas entered in security combo box as secQuestion variable
            newUser.secAnswer = txtsecurityanswer.Text; //sets whas entered in security answer text box as secAnswer variable

            if (txtuserid.Text.Length == 0)
            {
                //Debug: if nothing is entered in user ID box
                MessageBox.Show("Please enter a User ID."); 
            }
            else if (txtconfirmpass.Text != txtpassword.Text)
            {
                //Debug: if password text box and confirm password text box dont match
                MessageBox.Show("Your passwords do not match.");
                txtconfirmpass.Clear(); //clears confirm password text box
                txtpassword.Clear(); //clears password text box
            }
            else if (txtsecurityanswer.Text.Length == 0)
            {
                //Debug: if not answer is put in security question answer text box
                MessageBox.Show("Please give an answer to your security question.");
            }
            else
            {
                lboxuserid.Items.Add(txtuserid.Text + " " + DateTime.Now); //adds the userid and time logged in into the list box
                Program.people.Add(newUser); //adds the newUser variables to the people list in program.cs
                txtuserid.Clear(); //clears userid box
                txtconfirmpass.Clear(); //clears confirm password box
                txtpassword.Clear(); //clears password box
                cboxsecurity.Text = ""; //clears security question box
                txtsecurityanswer.Clear(); //clears securtiy answer box
                Newform newform = new Newform();
                

                newform.Show(); //opens "Newform" form
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Exits application
        }

        private void lboxuserid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxuserid.SelectedIndex >= 0)
            {
                btnremoveuser.Enabled = true; //remove button is enabled
                btnremoveuser.Visible = true; //remove button is visible
            }
        }

        private void btnremoveuser_Click(object sender, EventArgs e)
        {
            lboxuserid.Items.RemoveAt(lboxuserid.SelectedIndex); //removes selected item in list box
            btnremoveuser.Enabled = false; //remove button is disabled 
            btnremoveuser.Visible = false; //remove button is invisible
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        public class User
        {
            public string username; //creates username variable for all forms to use
            public string password; //creates password variable for all forms to use
            public string secQuestion; //creates secQuestion variable for all forms to use
            public string secAnswer; //creates secAnswer variable for all forms to use
        }
        public static List<User> people = new List<User>(); //creates List of logged in users for all forms to use

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}

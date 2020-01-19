using bhojarajsahu88.Programming_Utility.UtilityClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bhojarajsahu88.Programming_Utility.UIForms
{
    public partial class UserLogin : Form
    {
        AllMethodsClass AM = null;
        public UserLogin()
        {
            InitializeComponent();
        }

        private void linkLabelSignUp_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.lazzycoder.com/sign-up");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            reset();
        }
        public void reset()
        {
            textBoxUserId.Text = "";
            textBoxPassword.Text = "";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            AM = new AllMethodsClass();
            int userKey = 0;
            if (!string.IsNullOrEmpty(textBoxUserId.Text) && !string.IsNullOrEmpty(textBoxPassword.Text))
                if (AM.checkUserLogin(textBoxUserId.Text, textBoxPassword.Text, out userKey))
                {
                    UtilityClass.UtilityOperations.updateRegistryValue(textBoxUserId.Text, textBoxPassword.Text, userKey, true);
                    this.Close();
                    UtilityOperations.showMessage("User is set. Please restart the application");
                }
                else
                {
                    UtilityClass.UtilityOperations.updateRegistryValue(" ", " ", 0, false);
                    UtilityOperations.showMessage("User not found. Please signup");
                }
            else
                UtilityOperations.showMessage("Please enter userid and password");

            //UtilityClass.UtilityOperations.updateRegistryValue("", "", true);
            Cursor.Current = Cursors.Default;
        }
    }
}

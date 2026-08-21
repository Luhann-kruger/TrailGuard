using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrailGuard
{
    public partial class LoginForm : Form
    {
        //List of thee demo users that can login, it  user a custom User class

        List<User> users = new List<User>{
            new User("Randy", "Randy123", new List<string> { "Ranger" }),

            new User("Ben", "Ben123", new List<string> { "Admin", "Ranger" }),

            new User("Jack", "Jack123", new List<string> { "Rescuer", "Ranger" }),
            new User("Sam", "Sam123", new List<string> { "Rescuer", "Ranger", "Admin" })
        };

        Boolean passwordVisible;


        public LoginForm()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            passwordVisible = false;

        }

        private void lblModeTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblLoginTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            User loggedInUser = null;

            foreach (User user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    loggedInUser = user;
                    break;
                }
            }

            if (loggedInUser == null)
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Login Successful");
            //When login is successful
            ModesForm modesForm = new ModesForm(loggedInUser);

            this.Hide();

            modesForm.ShowDialog();

            this.Close();
        }

        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible;

            if (passwordVisible)
            {
                txtPassword.UseSystemPasswordChar = false;
                btnShowHidePassword.Text = "Hide";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                btnShowHidePassword.Text = "Show";
            }
        }

        private void btnLoginDetails_Click(object sender, EventArgs e)
        {
            string userInfo = "";

            foreach (User user in users)
            {
                userInfo += "Username: " + user.Username + Environment.NewLine;
                userInfo += "Password: " + user.Password + Environment.NewLine;
                userInfo += "Roles: " + string.Join(", ", user.Modes) + Environment.NewLine;
                userInfo += "------------------------" + Environment.NewLine;
            }

            MessageBox.Show(userInfo);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}

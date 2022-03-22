using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsRegistration.Data;

namespace WinFormsRegistration
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext context;
        public Form1()
        {
            InitializeComponent();
            this.context = new AppDbContext();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string cityName = comboBox1.Text;
            City city = context.Cities.FirstOrDefault(x=>x.Name==cityName);
            if (city==null)
            {
                city = new City() { Name = cityName };
            }
            User user = new User()
            {
                Username = tbUsernameRegister.Text,
                Password = tbPasswordRegister.Text,
                Firstname = tbFirstName.Text,
                Lastname = tbLastName.Text,
                Balance = decimal.Parse(tbBalance.Text),
                City=city
            };
            context.Users.Add(user);
            context.SaveChanges();
            MessageBox.Show($"You are now registered {user.Username} \n You have {user.Balance:f2} $");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            object[] cities = context.Cities.Select(x => x.Name).ToArray();
            ClearTextBox();
            comboBox1.Items.AddRange(cities);
            
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            tbPasswordRegister.UseSystemPasswordChar = true;
            tbPasswordLogin.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbUsernameLogin.Text)|| string.IsNullOrEmpty(tbUsernameLogin.Text))
                {
                    throw new Exception("Username can't be null or white space/s");
                }
                User username = context.Users.FirstOrDefault(x => x.Username == tbUsernameLogin.Text);
                string loginPassowrd = tbPasswordLogin.Text;
                if (username == null || loginPassowrd==null || loginPassowrd != username.Password)
                {
                    throw new Exception("This user doesn't exist or wrong password!");
                }
                MessageBox.Show($"Welcome back {username.Username} \n Your current balance is: {username.Balance:f2} $","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error" ,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }       
        }
        private void ClearTextBox()
        {
            tbUsernameLogin.Text = string.Empty;
            tbFirstName.Text = string.Empty;
            tbLastName.Text = string.Empty;
            tbPasswordLogin.Text = string.Empty;
            tbPasswordRegister.Text = string.Empty;
            comboBox1.Text = "--Select--";
            tbUsernameRegister.Text = string.Empty;
            tbBalance.Text = string.Empty;
            
        }
        private void Registerbtn_Click(object sender, EventArgs e)
        {
            
            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                tbPasswordRegister.UseSystemPasswordChar = false;
            }
            else
            {
                tbPasswordRegister.UseSystemPasswordChar=true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tbPasswordLogin.UseSystemPasswordChar = false;
            }
            else
            {
                tbPasswordLogin.UseSystemPasswordChar = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PM_Library;
using PMComponents;
using System.Data.SqlClient;

namespace Password_Manager
{
    public partial class New : Form
    {
        Accounts accounts;
        public New()
        {
            InitializeComponent();
        }

        private void edit1_Load(object sender, EventArgs e)
        {

        }

        private void New_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'passwordsDataSet.Accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter.Fill(this.passwordsDataSet.Accounts);
            panel1.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            accounts = new Accounts();
            accounts.Connect(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Projects\Visual Studio\2019\Password Manager\Password Manager\Passwords.mdf';Integrated Security=True;Connect Timeout=30");
            accounts.DB_Command = new System.Data.SqlClient.SqlCommand("SELECT * FROM Accounts WHERE Username='" + listBox1.Text + "'", accounts.DB_Connect);
            accounts.DB_Connect.Open();
            SqlDataReader sdr = accounts.DB_Command.ExecuteReader();

            while (sdr.Read())
            {
                edit1.Account_NameBox.Text = sdr["Name"].ToString();
                edit1.UsernameBox.Text = sdr["Username"].ToString();
                edit1.HostBox.Text = sdr["Host"].ToString();
                edit1.NoteBox.Text = sdr["Description"].ToString();
                edit1.PasswordBox.Text = sdr["Password"].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        
        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            edit1.SaveBtn.Enabled = false;
            panel1.Show();
            edit1.UpdateBtn.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            edit1.SaveBtn.Enabled = true;
            edit1.UpdateBtn.Enabled = false;
        }
    }
}

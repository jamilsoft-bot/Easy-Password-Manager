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
    public partial class Form1 : Form
    {
        Accounts accounts;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'passwordsDataSet.Accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter.Fill(this.passwordsDataSet.Accounts);
            panel1.Hide();
            delete1.Hide();
           // panel3.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //accounts = new Accounts();
            //accounts.Connect(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Projects\Visual Studio\2019\Password Manager\Password Manager\Passwords.mdf';Integrated Security=True;Connect Timeout=30");
            //String Stats = "";
            //accounts.Create_Table(ref Stats);

            //MessageBox.Show(Stats);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            accounts = new Accounts();
            accounts.Connect(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Projects\Visual Studio\2019\Password Manager\Password Manager\Passwords.mdf';Integrated Security=True;Connect Timeout=30");
            accounts.DB_Command = new System.Data.SqlClient.SqlCommand("SELECT * FROM Accounts WHERE Username='"+listBox1.Text+"'", accounts.DB_Connect);
            accounts.DB_Connect.Open();
            SqlDataReader sdr = accounts.DB_Command.ExecuteReader();

            while (sdr.Read())
            {
                AccountNameText.Text = sdr["Name"].ToString();
                UsernameText.Text = sdr["Username"].ToString();
                HostText.Text = sdr["Host"].ToString();
                NoteText.Text = sdr["Description"].ToString();
                DateText.Text = sdr["Date"].ToString();
                PasswordText.Text = sdr["Password"].ToString();
            }
            panel1.Show();


            // String Stats = "";


            //accounts.getRecord(ref Name, ref Username, ref Password, ref Host, ref Note, ref Date);

            //
            //



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            New Mynew = new New();
            Mynew.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            delete1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            New Mynew = new New();
            Mynew.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Help myhelp = new Help();
            myhelp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Abount about = new Abount();
            about.Show();
        }
    }
}

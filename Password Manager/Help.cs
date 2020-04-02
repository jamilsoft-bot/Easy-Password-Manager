using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }
        String Document = "";
        private void Help_Load(object sender, EventArgs e)
        {
            Document += "<!DOCTYPE html><html lang='en'><head><meta charset='UTF - 8'><meta name='viewport' content='width = device - width, initial - scale = 1.0'><title>Help</title></head>";
            Document += "<body><style>body{width: 50%;}dt{background-color: aqua;font-size: x-large;}li{list-style-type: none;display: inline;}</style>";
            Document += " <li><b>Email:</b> myakububauchi@gmail.com</li> <li><b> Phone:</b> +2349019221709</li> <li><b>whatsapp:</b> +2349011050365</li>";
            Document += "    <dl><dt> What is Password Manager?</dt><dd> Password Manager is a program that help internet users saving their account credentials. it solves the issue of over cramming too many accounts, by creating a better user experience and large storage ready to accept thausands of accounts</dd></dl>";
            Document += "    <dl><dt> Why is Password Manager?</dt><dd> You can use Password Manager to save your account credentials such as Passwords, usernames, and account names</dd></dl>";
            Document += "    <dl><dt> Is it free to use  Password Manager?</dt><dd> Its absolutely free, Password Manager is a free program, you are free to use it for any purpose</dd></dl>";
            Document += "    <dl><dt> Can I get the source code of Password Manager?</dt><dd> Yes off course, you can chat with the Developer, to make an agreement on how to get the source code</dd></dl>";
            Document += "    <dl><dt> Who design  Password Manager?</dt><dd> Muhammad Jamil is the Developer of Password Manager, a ten years experience Software developer with expertise in C/C++, Java, C#, PHP, Python and Javascript</dd></dl>";
            Document += "    <dl><dt> Is it save to add my account credentials to  Password Manager?</dt><dd> Its absolutely save, becouse, Password Manager was not design to collect user data</dd></dl>";
            Document += "    <dl><dt> Why should I trust Password Manager?</dt><dd> Becouse, Password Manager was not design to collect user data</dd></dl>";
            Document += "    <dl><dt> where should I Look for Help?</dt><dd> You can Contact the Developer of this Software at his email <a href='mailto: myakububauchi@gmail.com'>myakububauchi@gmail.com</a> , if you have any questions</dd></dl>";
            Document += "</body></html>";

            webBrowser1.DocumentText = Document;
        }
    }
}

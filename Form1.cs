using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace project_Banck_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       public struct stUser
        {
          public string UserName;
          public  string Password;                     
        };

        stUser curnt;
        
      static  string UsersFileName = @"C:\Users\Mohamed\source\repos\project Banck form\User.txt";

       




        public static stUser ConvertUserLineToRecord(string line, string separator = "#//#")
        {
            string[] userData = line.Split(new string[] { separator }, StringSplitOptions.RemoveEmptyEntries);

            if (userData.Length < 2)
                throw new FormatException("Invalid user data format!");

            return new stUser
            {
               Password = userData[0],
               UserName= userData[1],
               
            };
            
        }
        public static List<stUser> LoadUsersDataFromFile(string UsersFileName)
        {
            List<stUser> users = new List<stUser>();

            if (!File.Exists(UsersFileName))
                return users; // إرجاع قائمة فارغة إذا لم يكن الملف موجودًا

            using (StreamReader reader = new StreamReader(UsersFileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    stUser user = ConvertUserLineToRecord(line);
                    users.Add(user);
                }
            }

            return users;
        }
     public bool FindUserByUsernameAndPassword(string Username, string Password,ref stUser  User)
        {

            List<stUser> vUsers = LoadUsersDataFromFile(UsersFileName);

            foreach (stUser U in vUsers)
            {

                if (U.UserName == Username && U.Password == Password)
                {
                    User = U;
                    return true;
                }

            }
            return false;

        }
       public bool LoadUserInfo(string Username, string Password)
        {

            if (FindUserByUsernameAndPassword(Username, Password,ref curnt))
                return true;
            else
                return false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName="";
            string password = "";
            userName = textBox1.Text;
            password=textBox2.Text;
            if(LoadUserInfo(userName, password))
            {
               homeBank form = new homeBank();
               
                form.Show();
                this.Hide();

            }
            else
            {
                
                MessageBox.Show("Pasword And UserName Not Find Pless Tray Agen","err",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}

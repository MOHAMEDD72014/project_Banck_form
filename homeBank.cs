using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static project_Banck_form.Form1;
using static project_Banck_form.homeBank;

namespace project_Banck_form
{
    public partial class homeBank : Form
    {

       static string FileClints = @"C:\Users\Mohamed\source\repos\project Banck form\Clients.txt";
       public struct MyClint
        {
          public string name;
          public string AcauntNumber;
          public string PinCode;
          public string phoneclint;
          public double acuntBalance;
          public  double TotalacuntBalance;
          public  bool marck;
        };
        public homeBank()
        {
            InitializeComponent();
        }
       public MyClint info;
        public static MyClint ConvertUserLineToRecord(string line, string separator = "#//#")
        {
            string[] userData = line.Split(new string[] { separator }, StringSplitOptions.None);

            if (userData.Length < 5)
                throw new FormatException("Invalid user data format!");

            return new MyClint
            {
               name = userData[0],
               AcauntNumber= userData[1],
               PinCode= userData[2],
               phoneclint= userData[3],
               acuntBalance = double.Parse(userData[4])
            };

        }
       
        public static List<MyClint> LoadClientDataFromFile()
        {
            List<MyClint> clients = new List<MyClint>();

            if (File.Exists(FileClints))
            {
                foreach (string line in File.ReadAllLines(FileClints))
                {
                    if (line != "")
                    {
                        MyClint clien = ConvertUserLineToRecord(line);
                        clients.Add(clien);
                    }
                    
                   
                }
            }

            return clients;
        }

        void printClint(List<MyClint> clients)
        {

            listView1.Items.Clear();

            foreach (MyClint c in clients)
            {
                
                ListViewItem item = new ListViewItem(c.name);
                item.SubItems.Add(c.AcauntNumber);
                item.SubItems.Add(c.PinCode);
                item.SubItems.Add(c.phoneclint);
                item.SubItems.Add(c.acuntBalance.ToString()+"$");
                listView1.Items.Add(item);
            }
           
        }
        void printClintDelete(List<MyClint> clients)
        {
            
           
            listView2.Items.Clear();

            foreach (MyClint c in clients)
            {

                ListViewItem item = new ListViewItem(c.name);
                item.SubItems.Add(c.AcauntNumber);
                item.SubItems.Add(c.PinCode);
                item.SubItems.Add(c.phoneclint);
                item.SubItems.Add(c.acuntBalance.ToString() + "$");
                listView2.Items.Add(item);
            }

        }
        void ShowClint()
        {
            List<MyClint> clients = LoadClientDataFromFile();
            printClint(clients);
        }
        //---------------------------------------------------------------

        bool checkAcunt(ref string  acunt)
        {
            bool temp=true;
            List<MyClint> vclint = LoadClientDataFromFile();
            foreach (MyClint  i in vclint)
            {
                if (i.AcauntNumber == acunt)
                {
                    return temp=false;
                }
                return temp=true;
            }
            return temp;
        }



        MyClint InpotAddClint()
        {
            string aucwnt = txAcuntNumber.Text;
           


            if (!checkAcunt(ref aucwnt))
            {
                MessageBox.Show(aucwnt + " exset plees tray agne", "err", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                info.AcauntNumber = aucwnt;
                info.name = txName.Text;
                info.PinCode = txPin.Text;
                info.phoneclint = txphon.Text;
                info.acuntBalance = double.Parse(txAcuntBalance.Text);

            }
          
          
            return info;

        }
      static  string joinString(MyClint x, string dolm = "#//#")
        {
            string s1 = "";
            s1 += x.name + dolm;
            s1 += x.AcauntNumber + dolm;
            s1 += x.PinCode + dolm;
            s1 += x.phoneclint + dolm;
            s1 += x.acuntBalance.ToString() + dolm;
            return s1;
        }
        public static void AddNewClientToFile(string dataLine)
        {
            if (MessageBox.Show("you wont add new clint this", "add New clint", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(dataLine)) // التأكد من أن السطر ليس فارغًا
                {
                    using (StreamWriter writer = new StreamWriter(FileClints, true)) // فتح الملف بوضع الإضافة
                    {

                        writer.WriteLine(dataLine);
                    }
                    MessageBox.Show("new clint");
                }
            }
            else
            {
                return;
            }
        }

        void AddNewClint()
        {
            MyClint clint;
            clint = InpotAddClint();
            AddNewClientToFile(joinString(clint));
        }
        //----------------------------------------------------------
   bool check(string serchAuntNmuber, List<MyClint> vclint,ref MyClint clint)
        {
            foreach (MyClint i in vclint)
            {
                if (i.AcauntNumber == serchAuntNmuber)
                {
                    clint = i;
                    return true;
                }
            }
            return false;
        }
        bool markClintForDlete(string acuntNumber,ref List<MyClint>vclint)
        {

            for (int i =0; i<vclint.Count; i++)
            {
                if (vclint[i].AcauntNumber == acuntNumber)
                {
                    MyClint temp= vclint[i];
                    temp.marck = true;
                    vclint[i]=temp;
                    return true;
                }
            }
            return false;
        }
        public static List<MyClint> SaveFile(List<MyClint> vClint)
        {
            string Line;
            using (StreamWriter myFile = new StreamWriter(FileClints))
            {
                foreach (MyClint i in vClint)
                {
                    if (!i.marck)
                    {
                        Line = joinString(i);
                        myFile.WriteLine(Line);
                    }
                }
            }
            return vClint;
        }
        bool delateClintByAcuntNumber(string acuntNumber,ref List<MyClint> vclint)
        {
            MyClint clint=new MyClint();
            
            if (check(acuntNumber, vclint,ref clint))
            {
                printClintDelete(vclint);
                if (MessageBox.Show("do you wont delet this AcuntNumber "+acuntNumber+" Name:"+ clint.name,"Delete clint",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    markClintForDlete(acuntNumber,ref vclint);
                    SaveFile(vclint);
                   
                    vclint = LoadClientDataFromFile();
                   
                    return true;
                }
              
                   
                
            }
            
            
               
                return false;
            
        }
        void DleteClint()
        {
            List<MyClint> vclint = LoadClientDataFromFile();
           
            string acuntNumber = TxAcuntNumberDelete.Text;
           
            delateClintByAcuntNumber(acuntNumber,ref vclint);

        }
        //-------------------------------------------------------
        void printClintUpdate(List<MyClint> clients)
        {


            listView3.Items.Clear();

            foreach (MyClint c in clients)
            {

                ListViewItem item = new ListViewItem(c.name);
                item.SubItems.Add(c.AcauntNumber);
                item.SubItems.Add(c.PinCode);
                item.SubItems.Add(c.phoneclint);
                item.SubItems.Add(c.acuntBalance.ToString() + "$");
                listView3.Items.Add(item);
            }

        }
        MyClint getUpdate()
        {
            Update updateform = new Update();
            updateform.ShowDialog();
            info.AcauntNumber = updateform.AcuntNumber;
            info.name = updateform.NameClinte1;
            info.PinCode = updateform.PinNumber;
            info.phoneclint = updateform.phone;
            info.acuntBalance = double.Parse(updateform.AcuntBlunce);
            return info;
        }
       
        bool UpdateClientByAccountNumber(string AccountNumber,ref List<MyClint> vClients)
        {

            MyClint Client =new MyClint();
           

            if (check(AccountNumber, vClients,ref Client))
            {

                printClintUpdate(vClients);

                if (MessageBox.Show("you wont Update this Acunt","Update",MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)==DialogResult.Yes)
                {

                    for (int i=0;i<vClients.Count;i++)
                    {
                        if (vClients[i].AcauntNumber == AccountNumber)
                        {
                            vClients[i] = getUpdate();
                            break;
                        }

                    }

                    SaveFile(vClients);

                    MessageBox.Show("Clinte update secsafly","update",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return true;
                }

            }
            MessageBox.Show("this Acunt not find plase try agane", "Update", MessageBoxButtons.OK,
                     MessageBoxIcon.Exclamation);
                
                return false;
            

        }
        void updateClint()
        {
            List<MyClint> vclint = LoadClientDataFromFile();

            string acuntNumber = txUpdateSrch.Text;
            UpdateClientByAccountNumber(acuntNumber,ref vclint);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = TpShowClint;

            
                ShowClint();
           
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpAddNewClinte;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpDeleteClinte;
           
        }

        private void TpShowClint_Click(object sender, EventArgs e)
        {

        }

        private void TpAddClint_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
                AddNewClint();
            
          
        }

        private void btnUpdateClinte_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = TpUpdetClint;
        }

        private void btnSarch_Click(object sender, EventArgs e)
        {
            DleteClint();
        }

        private void txAcuntNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txAcuntNumber.Text))
            {
                e.Cancel = true;
                txAcuntNumber.Focus();
                errorProvider1.SetError(txAcuntNumber, "AcuntNumber should have a value!");
              
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txAcuntNumber, "");
             
            }
        }

        private void txName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txName.Text))
            {
                 e.Cancel = true;
                txName.Focus();
                errorProvider1.SetError(txName, "Name should have a value!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txName, "");

            }
        }

        private void txPin_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txPin.Text))
            {
                
                e.Cancel = true;
                txPin.Focus();
                errorProvider1.SetError(txPin, "Name should have a value!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txPin, "");

            }
        }

        private void txphon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txphon.Text))
            {
                e.Cancel = true;
                txphon.Focus();
                errorProvider1.SetError(txphon, "Name should have a value!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txphon, "");

            }
        }

        private void txAcuntBalance_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txAcuntBalance_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txAcuntBalance.Text))
            {
                e.Cancel = true;
                txAcuntBalance.Focus();
                errorProvider1.SetError(txAcuntBalance, "Name should have a value!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txAcuntBalance, "");

            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tpDeleteClinte_Click(object sender, EventArgs e)
        {

        }

        private void TxAcuntNumberDelete_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
       
        private void button3_Click_1(object sender, EventArgs e)
        {
            updateClint();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Tranactions frm = new Tranactions();
            frm.ShowDialog();
        }
    }
}

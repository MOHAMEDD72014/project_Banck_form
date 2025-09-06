using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static project_Banck_form.Form1;
using static project_Banck_form.homeBank;

namespace project_Banck_form
{
    public partial class Tranactions : Form
    {
        


        static string FileClints = @"C:\Users\Mohamed\source\repos\project Banck form\Clients.txt";
        public Tranactions()
        {
            InitializeComponent();
        }
       
        string AccountNumber = "";
        string AccountNumber2 = "";
        private void Tranactions_Load(object sender, EventArgs e)
        {

        }
        bool check2(string serchAuntNmuber, List<MyClint> vclint, ref MyClint clint)
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
        void printClintDesposet(List<MyClint> clients)
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
        void printClintWIthDrow(List<MyClint> clients)
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
        bool DepositBalanceToClientByAccountNumber(string AccountNumber, double Amount,ref List<MyClint> vClie)
        {
           
            if (MessageBox.Show("do you wont desposit this clinte mony", "Despoiset",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {

                for (int i=0;i<vClie.Count;i++)
                {
                    if (vClie[i].AcauntNumber == AccountNumber)
                    {

                       
                            MyClint temp = vClie[i];
                            temp.acuntBalance += Amount;
                       
                            vClie[i] = temp;

                            SaveFile(vClie);

                        printClintDesposet(vClie);
                        printClintWIthDrow(vClie);
                        return true;
                        


                        

                    }

                }


               
            }
            return false;
        }
        void exsteDeposet()
        {
            double Amount = 0;
            string x = txDeposet.Text;
            MyClint Client = new MyClint();

            List<MyClint> vClients = LoadClientDataFromFile();
            Amount = double.Parse(x);
            if (MessageBox.Show("do you wont desposit this clinte mony [" + txDeposet.Text + "]", "Despoiset",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DepositBalanceToClientByAccountNumber(AccountNumber, Amount, ref vClients);
            }
        }
        void ShowDepositScreen()
        {



            MyClint Client=new MyClint();

            List<MyClint> vClients = LoadClientDataFromFile();
             AccountNumber = txDepositSrch.Text;


            if (!check2(AccountNumber, vClients,ref Client))
            {
                grDeposet.Visible = false;

                MessageBox.Show("AccountNumber not find", "Despoiset", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               
                grDeposet.Visible= true;

                printClintDesposet(vClients);
               
               
            }

        }
        //---------------------------------------------------------------------
        void exsteWithDrow()
        {
            double Amount = 0;
            string x = txWithDrowMony.Text;
            MyClint Client = new MyClint();

            List<MyClint> vClients = LoadClientDataFromFile();
            Amount = double.Parse(x);
            if (MessageBox.Show("do you wont WithDrow this clinte mony [" + txWithDrowMony.Text + "]", "WithDrow",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DepositBalanceToClientByAccountNumber(AccountNumber2, Amount * -1,ref vClients); ;
            }
        }
        void ShowWithDrawScreen()
        {
            MyClint Client = new MyClint();

            List<MyClint> vClients = LoadClientDataFromFile();
            AccountNumber2 = txWithDrawAcunte.Text;





            if (!check2(AccountNumber2, vClients, ref Client))
            {
                grDeposet.Visible = false;

                MessageBox.Show("AccountNumber not find", "Despoiset", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                grWithDrow.Visible = true;

                printClintWIthDrow(vClients);
            }

           

          

        }
        //----------------------------------------------------------------------
        void printClintTotal(MyClint clients)
        {


           

           

                ListViewItem item = new ListViewItem(clients.name);
                item.SubItems.Add(clients.AcauntNumber);
 
                item.SubItems.Add(clients.acuntBalance.ToString() + "$");
                listView1.Items.Add(item);
        }

        
    void ShowTotalBalances()
    {

        List<MyClint> vClients = LoadClientDataFromFile();



        double TotalBalances = 0;

        if (vClients.Count == 0)
            MessageBox.Show("No Clients Available In the System!", "Total Balance", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        else

            foreach (MyClint Client in vClients)
            {

                printClintTotal(Client);
                TotalBalances += Client.acuntBalance;


            }

            LbTotalPalnnce.Text = TotalBalances.ToString();

    }
    private void button1_Click(object sender, EventArgs e)
        {
            tbTranction.SelectedTab = TpDeposit;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowDepositScreen();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            exsteDeposet();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbTranction.SelectedTab = tpWithDrow;
        }

        private void btnWithDrowMony_Click(object sender, EventArgs e)
        {
            exsteWithDrow();
        }

        private void btnSarchWithDraw_Click(object sender, EventArgs e)
        {
            ShowWithDrawScreen();
        }

        private void btnTotalBalances_Click(object sender, EventArgs e)
        {
            ShowTotalBalances();
            tbTranction.SelectedTab = tpTotalBalances;
        }

        private void TpDeposit_Click(object sender, EventArgs e)
        {

        }
    }
}

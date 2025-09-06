using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
namespace DVLDBassnisLayer
{
    public class clsFileRemberMe
    {
        static string FileRemeberMe = @"C:\Users\Mohamed\source\repos\DVLDBassnisLayer\RememberMeUser.txt";
        public string UserName { get; set; }
        public  string Password {  get; set; }
        public bool IsActve {  get; set; }


        public static clsFileRemberMe ConvertUserLineToRecord(string line, string separator = "#//#")
        {
            string[] userData = line.Split(new string[] { separator }, StringSplitOptions.None);

            if (userData.Length < 3)
                throw new FormatException("Invalid user data format!");

            return new clsFileRemberMe
            {
                UserName = userData[0],
                Password = userData[1],
                IsActve =  bool.Parse(userData[2])
               
            };

        }
        public static List<clsFileRemberMe> LoadClientDataFromFile()
        {
            List<clsFileRemberMe> Files = new List<clsFileRemberMe>();

            if (File.Exists(FileRemeberMe))
            {
                foreach (string line in File.ReadAllLines(FileRemeberMe))
                {
                    if (line != "")
                    {
                        clsFileRemberMe File = ConvertUserLineToRecord(line);
                        Files.Add(File);
                    }


                }
            }

            return Files;
        }

       public static string joinString(clsFileRemberMe x, string dolm = "#//#")
        {
            string s1 = "";
            s1 += x.UserName + dolm;
            s1 += x.Password + dolm;
            s1 += x.IsActve + dolm;
            return s1;
        }




        // هنا اضافة الكتابة الى TXTET
        public static void AddNewClientToFile(string dataLine)
        {
            
                if (!string.IsNullOrEmpty(dataLine)) // التأكد من أن السطر ليس فارغًا
                {
                    using (StreamWriter writer = new StreamWriter(FileRemeberMe, false)) // فتح الملف بوضع الإضافة
                    {

                        writer.WriteLine(dataLine);
                    }
                  
                }
            
                return;
            }
        }


    }


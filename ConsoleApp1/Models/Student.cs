using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Student
    {
        private static int No;
        private string _fullname;
        private string _groupno;
        public static string GroupFullNameNumber;
        public string FullName 
        { 
            get
            {
                return _fullname;

            }
            set
            {
                while(!CheckFullName(value))
                {
                    
                    Console.WriteLine("Ad ve Soyadi Bitisik Yazmayin");
                    value = Console.ReadLine();

                }
                _fullname = value;
                

            }
        }
       


        public string GroupNo 
        {
            get => _groupno;
            
                
            set
            {
                
                while(!CheckGroupNo(value))
                {
                    
                    
                    Console.WriteLine("Group Nomrenizi duzgun daxil edin");
                    value = Console.ReadLine();
                }
                _groupno = value;
                
            }
        }


        public static bool CheckGroupNo(string groupnNo)
        {
            if (groupnNo.Length == 4)
            {
                int count = 0;
                bool check = false;

                if (char.IsUpper(groupnNo[0]))
                {
                    for (int i = 1; i < groupnNo.Length; i++)
                    {
                        if (char.IsDigit(groupnNo[i]))
                        {
                            count++;

                        }
                        else
                        {
                            
                            break;
                        }

                    }
                    if (count == 3)
                    {
                        check = true;
                        return check;

                    }


                }
               

            }
           
            return false;

        }

        public static bool CheckFullName(string fullName)
        {
            bool check = false;
            int count = 0;

            if(fullName.Contains(' '))
            {

                foreach (char item in fullName)
                {
                    if(item == ' ')
                    {
                        count++;
                    }

                }
                if(count == 1)
                {
                    return true;
                }

                

            }
            return check;
        }

        public Student(string fullName, string groupNo)
        {
            FullName = fullName;
            GroupNo = groupNo;

            No++;
            GroupFullNameNumber = $"Ad ve Soyad: {_fullname} GroupNo: {_groupno} Special Number: {No}";
           

            

           


        }
        
      

        

           
        
    }
}

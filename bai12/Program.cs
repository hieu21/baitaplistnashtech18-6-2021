using System;
using System.Collections.Generic;

namespace bai12
{
    class Program
    {
        public class members{
            private string firstname;
            private string lastname;
            private string gender;
            private DateTime dob;
            private int phonenumber;
            private string birthplace;
            private int age;
            private string isgraduated;

           // int DateTime.Year Dob { get; }

            public string Firstname { get => firstname; set => firstname = value; }
            public string Lastname { get => lastname; set => lastname = value; }
            public string Gender { get => gender; set => gender = value; }
            public DateTime Dob { get => dob; set => dob = value; }
            public int Phonenumber { get => phonenumber; set => phonenumber = value; }
            public string Birthplace { get => birthplace; set => birthplace = value; }
            public int Age { get => age; set => age = value; }
            public string Isgraduated { get => isgraduated; set => isgraduated = value; }

            public members(string firstname, string lastname, string gender, DateTime dob, int phonenumber, string birthplace, int age, string isgraduated)
            {
                this.Firstname = firstname;
                this.Lastname = lastname;
                this.Gender = gender;
                this.Dob = dob;
                this.Phonenumber = phonenumber;
                this.Birthplace = birthplace;
                this.Age = age;
                this.Isgraduated = isgraduated;
            }
        
        }
        static void Main(string[] args)
        {
            List<members> listmembers = new List<members>();
            listmembers.Add(new members("nguyen van","ba","male",new DateTime(1995,1,2),0123456,"HP",23,"yes"));
            listmembers.Add(new members("nguyen van","bon","male",new DateTime(2002,1,2),0123456,"NA",25,"yes"));
            listmembers.Add(new members("nguyen van","nam","female",new DateTime(2000,1,2),0123456,"HN",19,"no"));
            listmembers.Add(new members("nguyen van","sau","male",new DateTime(2003,1,2),0123456,"TH",27,"yes"));
            listmembers.Add(new members("nguyen van","bay","male",new DateTime(1999,1,2),0123456,"HN",30,"no"));
            listmembers.Add(new members("nguyen van","tam","male",new DateTime(1997,1,2),0123456,"SG",24,"yes"));
            rushb:
            Console.WriteLine("1. hien thi ra ai la gioi tinh nam");
            Console.WriteLine("2. hien thi ra ai la lon tuoi nhat in 1 lan");
            Console.WriteLine("3. hien thi chuoi moi chi ho va ten");
            Console.WriteLine("4. hien thi ra ai sinh nam 2000 hoac nho hon 2000 hoac lon hon 2000");
            Console.WriteLine("5. hien thi ra nguoi dau tien o ha noi");
            Console.WriteLine("6. Thoat");
            int a = Int32.Parse(Console.ReadLine());
            
            switch (a)
            {
                case 1:
                    foreach(var i in listmembers){
                    if(i.Gender =="male"){
                     Console.WriteLine(i.Firstname + " "+ i.Lastname +" " +i.Gender+" "+i.Dob+" "+i.Phonenumber+" " +i.Birthplace+" "+i.Age+" "+i.Isgraduated);
                    }               
                    }
                    
                    break;
                case 2:
                    List<int> tuoi = new List<int>();
                    foreach( var i in listmembers){
                        int age = DateTime.Now.Year - i.Dob.Year;
                        tuoi.Add(age);
                    }
                    int h=0;
                    foreach(var i in tuoi){
                        if (i>h){
                            h=i;
                        }
                    }
                    Console.WriteLine(h);

                    break;
                case 3:
                    foreach(var i in listmembers){
                        Console.WriteLine(i.Firstname+" "+i.Lastname);
                    }
                    goto rushb;
                    
                case 4:
                    Console.WriteLine("1. hien thi ra ai sinh ra nam 2000");
                    Console.WriteLine("2. hien thi ra ai >2000");
                    Console.WriteLine("3. hien thi ra ai <2000");
                    int b= Int32.Parse(Console.ReadLine());
                    switch(b){
                        case 1:
                            foreach(var i in listmembers){
                                if(i.Dob.Year ==2000){
                                    Console.WriteLine(i.Firstname+" "+i.Lastname);
                                }
                            }
                            break;
                        case 2:
                            foreach(var i in listmembers){
                                if(i.Dob.Year >2000){
                                    Console.WriteLine(i.Firstname+" "+i.Lastname);
                                }
                            }
                            break;
                        case 3:
                            foreach(var i in listmembers){
                                if(i.Dob.Year <2000){
                                    Console.WriteLine(i.Firstname+" "+i.Lastname);
                                }
                            }
                            break;
                     }
                    break;
                case 5:
                    foreach(var i in listmembers){
                        if(i.Birthplace == "HN"){
                            Console.WriteLine(i.Firstname+" " + i.Lastname);
                            break;
                        }
                    }
                    break;
                case 6:
                    
                    return ;
                
            }
            goto rushb;
        }
    }
}

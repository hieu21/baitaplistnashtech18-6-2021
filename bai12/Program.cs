using System;
using System.Collections.Generic;
using System.Linq;

namespace bai12
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Member> listMember = new List<Member>();
            listMember.Add(new Member("nguyen van", "ba", "male", new DateTime(1995, 1, 2), 0123456, "HP", 26, "yes"));
            listMember.Add(new Member("nguyen van", "bon", "male", new DateTime(2002, 1, 2), 0123456, "NA", 19, "yes"));
            listMember.Add(new Member("nguyen van", "nam", "female", new DateTime(2000, 1, 2), 0123456, "HN", 21, "no"));
            listMember.Add(new Member("nguyen van", "sau", "male", new DateTime(2003, 1, 2), 0123456, "TH", 18, "yes"));
            listMember.Add(new Member("nguyen van", "bay", "male", new DateTime(1999, 1, 2), 0123456, "HN", 22, "no"));
            listMember.Add(new Member("nguyen van", "tam", "male", new DateTime(1997, 1, 2), 0123456, "SG", 24, "yes"));
        rushb:
            Console.WriteLine("1. hien thi ra ai la gioi tinh nam");
            Console.WriteLine("2. hien thi ra ai la lon tuoi nhat in 1 lan");
            Console.WriteLine("3. hien thi chuoi moi chi ho va ten");
            Console.WriteLine("4. hien thi ra ai sinh nam 2000 hoac nho hon 2000 hoac lon hon 2000");
            Console.WriteLine("5. hien thi ra nguoi dau tien o ha noi");
            Console.WriteLine("6. Thoat");
            Console.Write("Vui long nhap so ban mong muon");
            int a = Int32.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    GetMaleMemberList(listMember);

                    break;
                case 2:
                    //GetOldest(listMember);
                    GetOldestLinQ(listMember);

                    break;
                case 3:
                    GetFullName(listMember);
                    break;

                case 4:
                    GetBirthYear(listMember);
                    break;
                case 5:
                    GetPersonInHaNoi(listMember);
                    break;
                case 6:

                    return;

            }
            goto rushb;
            static void GetMaleMemberList(List<Member> listMember)
            {

                foreach (var i in listMember)
                {
                    if (i.Gender == "male")
                    {
                        Console.WriteLine(i.FirstName + " " + i.LastName + " " + i.Gender + " " + i.Dob + " " + i.PhoneNumber + " " + i.BirthPlace + " " + i.Age + " " + i.IsGraduated);
                    }
                }
            }
            static void GetFullName(List<Member> listMember)
            {
                foreach (var i in listMember)
                {
                    Console.WriteLine(i.FirstName + " " + i.LastName);
                }
            }
            static void GetBirthYear(List<Member> listMember)
            {
                Console.WriteLine("1. hien thi ra ai sinh ra nam 2000");
                Console.WriteLine("2. hien thi ra ai >2000");
                Console.WriteLine("3. hien thi ra ai <2000");
                int b = Int32.Parse(Console.ReadLine());
                switch (b)
                {
                    case 1:
                        foreach (var i in listMember)
                        {
                            if (i.Dob.Year == 2000)
                            {
                                Console.WriteLine(i.FirstName + " " + i.LastName);
                            }
                        }
                        break;
                    case 2:
                        foreach (var i in listMember)
                        {
                            if (i.Dob.Year > 2000)
                            {
                                Console.WriteLine(i.FirstName + " " + i.LastName);
                            }
                        }
                        break;
                    case 3:
                        foreach (var i in listMember)
                        {
                            if (i.Dob.Year < 2000)
                            {
                                Console.WriteLine(i.FirstName + " " + i.LastName);
                            }
                        }
                        break;
                }
            }
            static void GetPersonInHaNoi(List<Member> listMember)
            {
                foreach (var i in listMember)
                {
                    if (i.BirthPlace == "HN")
                    {
                        Console.WriteLine(i.FirstName + " " + i.LastName);
                        break;
                    }
                }
            }
            static void GetOldest(List<Member> listMember)
            {
                List<int> temp = new List<int>();
                foreach (var i in listMember)
                {
                    int age = DateTime.Now.Year - i.Dob.Year;
                    temp.Add(age);
                }
                int h = 0;
                foreach (var i in temp)
                {
                    if (i > h)
                    {
                        h = i;
                    }
                }
                foreach (var i in listMember)
                {
                    if (i.Age == h)
                    {
                        Console.WriteLine(i.FirstName + " " + i.LastName + " " + i.Age);
                    }
                }
            }
            static void GetOldestLinQ(List<Member> listMember)
            {
                var result = (from member in listMember
                              select member.Age).Max();
                foreach (var i in listMember)
                {
                    if (i.Age == result)
                    {
                        Console.WriteLine(i.FirstName + " " + i.LastName + " " + i.Age);
                    }
                }
            }
        }

    }
}

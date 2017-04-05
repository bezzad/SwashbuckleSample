using System;
using System.Collections.Generic;
using WebApiSwagger.Models;

namespace WebApiSwagger.Controllers
{
    public class StudentsData
    {
        public static List<Student> CreateStudents()
        {

            List<Student> studentsList = new List<Student>();

            for (int i = 0; i < studentNames.Length; i++)
            {
                var nameGenderMail = SplitValue(studentNames[i]);
                var student = new Student()
                {
                    Email = String.Format("{0}.{1}@{2}", nameGenderMail[0], nameGenderMail[1], nameGenderMail[3]),
                    UserName = String.Format("{0}{1}", nameGenderMail[0], nameGenderMail[1]),
                    FirstName = nameGenderMail[0],
                    LastName = nameGenderMail[1],
                    DateOfBirth = DateTime.UtcNow.AddDays(-new Random().Next(7000, 8000)),
                };

                studentsList.Add(student);
            }

            return studentsList;
        }

        static string[] studentNames = 
        { 
            "Taiseer,Joudeh,Male,hotmail.com", 
            "Hasan,Ahmad,Male,mymail.com", 
            "Moatasem,Ahmad,Male,outlook.com", 
            "Salma,Tamer,Female,outlook.com", 
            "Ahmad,Radi,Male,gmail.com", 
            "Bill,Gates,Male,yahoo.com", 
            "Shareef,Khaled,Male,gmail.com", 
            "Aram,Naser,Male,gmail.com", 
            "Layla,Ibrahim,Female,mymail.com", 
            "Rema,Oday,Female,hotmail.com",
            "Fikri,Husein,Male,gmail.com",
            "Zakari,Husein,Male,outlook.com",
            "Taher,Waleed,Male,mymail.com",
            "Tamer,Wesam,Male,yahoo.com",
            "Khaled,Hasaan,Male,gmail.com",
            "Asaad,Ibrahim,Male,hotmail.com",
            "Tareq,Nassar,Male,outlook.com",
            "Diana,Lutfi,Female,outlook.com",
            "Tamara,Malek,Female,gmail.com",
            "Arwa,Kamal,Female,yahoo.com",
            "Jana,Ahmad,Female,yahoo.com",
            "Nisreen,Tamer,Female,gmail.com",
            "Noura,Ahmad,Female,outlook.com"
        };

        private static string[] SplitValue(string val)
        {
            return val.Split(',');
        }
    }
}
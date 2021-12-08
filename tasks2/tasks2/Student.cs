using System;
using System.Collections.Generic;
using System.Text;

namespace tasks2
{
    class Student
    {
       public string Name;
       public string Course;
       public string Subject;
       public string Universty;
       public string Email;
       public int Phonenumber;


        public Student(string name,string course,string subject,string universty,string email,int phonenumber)
        {
            this.Name = name;
            this.Course = course;
            this.Subject = subject;
            this.Universty = universty;
            this.Email = email;
            this.Phonenumber = phonenumber;
        }

        public void Stud()
        {
            Console.WriteLine($"{Name}\n{Course}\n{Subject}\n{Universty}\n{Email}\n{Phonenumber}");
        }

    }
    
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    class Student
    {

        private string name;
        private string id;
        private string department;
        private float cgpa;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Id
        {
            set { id = value; }
            get { return id; }
        }

        public string Department
        {
            set { department = value; }
            get { return department; }
        }

        public float Cgpa
        {
            set { cgpa = value; }
            get { return cgpa; }
        }

        public void showInfo()
        {
            Console.WriteLine("Student Name : " + Name);
            Console.WriteLine("ID : " + Id);
            Console.WriteLine("Department : " + Department);
            Console.WriteLine("CGPA : " + cgpa);


        }
    }
}

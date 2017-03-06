using System;

namespace Exercise1
{
    //Superclass
    public class PersonClass : Person
    {
        public string name;
        public string Name
        {
            get { return name; }
        }

        public string surname;
        public string Surname
        {
            get { return surname; }
        }

        public int age;
        public int Age
        {
            get { return age; }
        }
        
        //Person Methods
        void Person.Birthday()
        {
            age++;
        }

        void Person.Eat()
        {
            Console.WriteLine("EEEEEEAAAAAAATTTTTTTTTIIIIIIINNNNNNNGGGGGGG");
        }

        void Person.Sleep()
        {
            Console.WriteLine("SSSSSLLLLLEEEEEPPPPPIIIIINNNNNGGGGG");
        }
    }

    // Customer class
    public class Customer : PersonClass
    {
        // Constructor
        public Customer()
        {
            this.name = "JoostCustomer";
            this.surname = "ZonneveldCustomer";
            this.age = 20;
        }

        //Customer Methods
        public void Buy()
        {
            Console.WriteLine("Buy stuff");
        }

        public void Return()
        {
            Console.WriteLine("Return stuff");
        }

        public void AskStupidQuestions()
        {
            Console.WriteLine("Ask Employee");
        }
    }

    //student Class
    public class Student : PersonClass
    {
        //Constructor
        public Student()
        {
            this.name = "JoostStudent";
            this.surname = "ZonneveldStudent";
            this.age = 20;
        }

        //Student methods

        public void Study()
        {
            Console.WriteLine("Studying");
        }

        public void Party()
        {
            Console.WriteLine("Partyyyy");
        }

        public void Struggle()
        {
            Console.WriteLine("Why isn't my dev project working!?!?!?!?!?");
        }
    }

    public class Teacher : PersonClass
    {
        //Constructor
        public Teacher()
        {
            this.name = "JoostTeacher";
            this.surname = "ZonneveldTeacher";
            this.age = 20;
        }

        //Teacher methods
        public void Teach()
        {
            Console.WriteLine("Teach stuff");
        }

        public void GiveHomework()
        {
            Console.WriteLine("Make this before friday");
        }

        public void Nag()
        {
            Console.WriteLine("Yeah its right, but..... ");
        }
    }
}
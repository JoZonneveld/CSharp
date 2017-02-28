using System;

namespace Exercise1
{

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

    public class Customer : PersonClass
    {
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
}
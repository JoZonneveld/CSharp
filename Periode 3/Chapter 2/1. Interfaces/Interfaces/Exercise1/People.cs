using System;

namespace Exercise1
{
    public class Customer : Person
    {
        private string name;
        public string Name
        {
            get { return name; }
        }

        private string surname;
        public string Surname
        {
            get { return surname; }
        }

        private int age;
        public int Age
        {
            get { return age; }
        }

        public Customer()
        {
            this.name = "Joost";
            this.surname = "Zonneveld";
            this.age = 21;
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
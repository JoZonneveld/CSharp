using System;

namespace Exercise0
{
    public class Cat : Animal
    {
        public string Talk;

        public Cat()
        {
            this.Talk = "Miao";
        }

        void Animal.SaySomething()
        {
            Console.WriteLine(this.Talk);
        }

    }

    public class Dog : Animal
    {
        public string Talk;

        public Dog()
        {
            this.Talk = "Bao";
        }

        void Animal.SaySomething()
        {
            Console.WriteLine(this.Talk);
        }
    }

    public class Cow : Animal
    {
        public string Talk;

        public Cow()
        {
            this.Talk = "Muuuuu";
        }

        void Animal.SaySomething()
        {
            Console.WriteLine(this.Talk);
        }
    }
}
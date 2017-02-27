namespace Exercise1
{
    public interface Person
    {
        // values & getters
        string Name { get; }
        string Surname { get; }
        int Age { get; }

        //Methods
        void Birthday();
        void Eat();
        void Sleep();
    }
}
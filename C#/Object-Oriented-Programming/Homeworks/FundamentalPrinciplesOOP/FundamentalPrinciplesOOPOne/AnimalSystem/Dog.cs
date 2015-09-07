namespace AnimalSystem
{
    public class Dog : Animal, ISound
    {
        public Dog(int age, string name, Gender sex)
            : base(age, name, sex)
        {
        }


        public override string Sound()
        {
            return "Bau!";
        }

        public override string ToString()
        {
            return "dogs";
        }
    }
}

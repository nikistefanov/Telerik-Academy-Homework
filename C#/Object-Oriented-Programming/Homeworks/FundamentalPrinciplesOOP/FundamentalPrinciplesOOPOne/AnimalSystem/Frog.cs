namespace AnimalSystem
{
    public class Frog : Animal, ISound
    {
        public Frog(int age, string name, Gender sex)
            : base (age, name, sex)
        {
        }



        public override string Sound()
        {
            return "Quaq!";
        }
    }
}

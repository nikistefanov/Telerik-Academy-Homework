namespace AnimalSystem
{
    public class Cat : Animal, ISound
    {
        public Cat(int age, string name, Gender sex)
            : base (age, name, sex)
        {
        }



        public override string Sound()
        {
            return "Miaaaw!";
        }
    }
}

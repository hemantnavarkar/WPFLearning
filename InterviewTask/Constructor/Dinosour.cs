namespace InterviewTask.Constructor
{
    public class Dinosour : Animal
    {
        public Dinosour(int legs, string name):base(legs, name)
        {
            Console.WriteLine("Dinosour instantiate");
        }

        public override void CreateSound()
        {
            Console.WriteLine("Vhhhhhhhhaaa");
        }
    }
}

namespace InterviewTask.Constructor
{
    public class Dog : Animal
    {
        public Dog(int legs, string name):base(legs, name)
        {
            Console.WriteLine("Dog instantiate");
        }

        public override void CreateSound()
        {
            Console.WriteLine("Bhu Bhuu");
        }
    }
}

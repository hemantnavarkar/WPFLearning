namespace InterviewTask.GC
{
    public class Derived : Base
    {
        /// <summary>
        /// The derived instance object.
        /// </summary>
        public static int DerivedInt = 2000;

        /// <summary>
        /// Default constructior.
        /// </summary>
        public Derived() 
        {
            DerivedInt = 100;
            Console.WriteLine("Derived Default Constructor");
        }

        /// <summary>
        /// Static derived constructor.
        /// </summary>
        static Derived()
        {
            Console.WriteLine("Static Default Constructor");
        }

        /// <summary>
        /// Instance Method.
        /// </summary>
        void PrintD()
        {
            Console.WriteLine("PrintD");
        }
    }
}

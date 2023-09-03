namespace InterviewTask.GC
{
    public abstract class BaseAbstract : ConcreteAbstract
    {
        /// <summary>
        /// The abstarct method
        /// </summary>
        public abstract void DoSome();

        public void BaseNonAbstract() 
        {
            Console.WriteLine("Base non abstract method");
        }
    }
}

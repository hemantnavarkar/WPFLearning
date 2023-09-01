using InterviewTask.Contratcs;

namespace InterviewTask.Implemetation
{
    internal class Cage<T> : ICage<T> where T : IAnimal
    {
        public void Enclose(T animal, int size = 10)
        {
            // busniess logic
        }
    }
}

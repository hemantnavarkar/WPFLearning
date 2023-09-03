namespace InterviewTask.Contratcs
{
    /// <summary>
    /// Contract for Zoo class
    /// </summary>
    public interface IZoo<T> where T : IAnimal
    {
        /// <summary>
        /// Includes the animal in to zoo.
        /// </summary>
        /// <param name="animal"></param>
        public void Include(T animal);

        /// <summary>
        /// Exclude the animals from zoo.
        /// </summary>
        /// <param name="animal"></param>
        public void Exclude(T animal);
    }
}

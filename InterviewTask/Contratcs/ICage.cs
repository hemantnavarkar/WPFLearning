namespace InterviewTask.Contratcs
{
    internal interface ICage<T> where T: IAnimal
    {
        /// <summary>
        /// This enclose the animal in cage.
        /// </summary>
        /// <param name="animal"> The animal to enclosed</param>
        /// <param name="size">The total number of animals to enclosed</param>
        void Enclose(T animal, int size = 0);
    }
}

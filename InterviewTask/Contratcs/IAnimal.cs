namespace InterviewTask.Contratcs
{
    /// <summary>
    /// Thw animal contract
    /// </summary>
    public interface IAnimal
    {
        public int Legs { get; set; }

        public string Name { get; set; }

        public void CreateSound();
    }
}
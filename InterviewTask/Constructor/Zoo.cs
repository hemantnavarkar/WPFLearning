using InterviewTask.Contratcs;
using System.Collections;

namespace InterviewTask.Constructor
{

    /// <summary>
    /// Maximum 1000 Animals can be added in zoo.
    /// </summary>
    public class Zoo : IZoo<IAnimal>, IEnumerable
    {
        
        private readonly IList<IAnimal> animals;
        public Zoo()
        {
            this.animals = new List<IAnimal>();
        }
        
        public const int MAX_ANIMAL = 1000;


        public void Exclude(IAnimal animal)
        {
            this.animals.Remove(animal);
        }

        public void Include(IAnimal animal)
        {
            this.animals.Add(animal);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Animal theAnimal in animals.Cast<Animal>())
            {
                yield return theAnimal;
            }
        }

        /// <summary>
        /// Defind indexers to directly set the content
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public IAnimal this[int i] 
        {
            get { return animals[i]; }
            set { animals[i] = value; }
        }
    }
}

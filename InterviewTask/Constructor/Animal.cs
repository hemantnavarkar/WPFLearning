

using InterviewTask.Contratcs;

namespace InterviewTask.Constructor
{
    public abstract class Animal : IAnimal
    {
        /// <summary>
        /// Parameteeriese constructor
        /// </summary>
        /// <param name="legs"></param>
        /// <param name="name"></param>
        public Animal(int legs, string name)
        {
            Legs = legs;
            Name = name;
            // Console.WriteLine("Animal Instantiate");
        }

        /// <summary>
        /// This will called only once when you refer any field or tried creatong the instance
        /// </summary>
        static Animal()
        {
            // Console.WriteLine("Inside the static constructor");
        }

        public int Legs { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Every animal needs to override this CreateSound Method .... 
        /// </summary>
        public abstract void CreateSound();
    }
}

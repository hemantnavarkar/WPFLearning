// See https://aka.ms/new-console-template for more information
using InterviewTask.Contratcs;
using InterviewTask.Implemetation;
using InterviewTask.Implemetation.Singleton;

Console.WriteLine("Hello, World!");


 Logger.Logger_Instance.Log();




IAnimal animal = new Animal();
ICage<IAnimal> cage = new Cage<IAnimal>();
cage.Enclose(animal);







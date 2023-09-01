// See https://aka.ms/new-console-template for more information
using InterviewTask.Constructor;
using InterviewTask.Contratcs;
using InterviewTask.Implemetation;
using InterviewTask.Implemetation.Singleton;

Console.WriteLine("Hello, World!");



// Constructor Demo


Dog dog = new Dog(4, "Tommy");
Dog dog2 = new Dog(5, "Tommy2");

Console.ReadLine();


/// Struct 

Point pt = new Point
{
    X = 100,
    Y = 100
};





/// Singleton demo
Logger.Logger_Instance.Log();






// This is interface demo 
IAnimal animal = new Animal();
ICage<IAnimal> cage = new Cage<IAnimal>();
cage.Enclose(animal);







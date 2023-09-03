// See https://aka.ms/new-console-template for more information
////// Constructor Demo


////Dog dog = new Dog(4, "Tommy");
////Dog dog2 = new Dog(5, "Tommy2");

////Console.ReadLine();


/////// Struct 

////Point pt = new Point
////{
////    X = 100,
////    Y = 100
////};


/////// Singleton demo
////Logger.Logger_Instance.Log();


////for (int i=0 ; i < 100000; i++)
////{
////    BaseClass1 testClass = new BaseClass1();

////    ////using (BaseClass1 testClass = new BaseClass1()) 
////    ////{

////    ////}
////}

////using (
////BaseClass1 testClass = new BaseClass1())
////{ 

////}


////var jurasicPark = new Zoo();
////// Add some dinasors


////for (int i = 0; i < 100; i++)
////{
////    jurasicPark.Include(new Dinosour(4, $"Dino {i}")); 
////}


////// Iterate the zoo animals 

////foreach (IAnimal animal in jurasicPark) 
////{
////    Console.WriteLine(animal.Name);
////}


using InterviewTask.GC;
using InterviewTask.Struct;
/// IDisposable Patter
/// ZOO MANGER CLASS
////Derived dobj = new Derived();
///



Point p = new Point(10,10);
Point pp = p;

Console.WriteLine($"{p.X} {p.Y}");
Console.WriteLine($"{pp.X} {pp.Y}");

p.X = 100;
p.Y = 100;

Console.WriteLine($"{pp.X} {pp.Y}");
Console.WriteLine($"{p.X} {p.Y}");

StructEva(ref pp);

Console.WriteLine($"{pp.X} {pp.Y}");
Console.WriteLine($"{p.X} {p.Y}");


void StructEva(ref Point ppp)
{
    ppp.X = 10000;
    ppp.Y = 10000;


}












Console.ReadLine();

////// This is interface demo 
////IAnimal animal = new Animal();
////ICage<IAnimal> cage = new Cage<IAnimal>();
////cage.Enclose(animal);







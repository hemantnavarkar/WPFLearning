// See https://aka.ms/new-console-template for more information
using DesignPatternsDemo;
using DesignPatternsDemo.Generics;
using DesignPatternsDemo.ThreadDemo;
using System.Collections;

Console.WriteLine("***********************Thread Demo**************************");

int data1 = 5;
int data2 = 10;

Utility.Swap(ref data1, ref data2);

Console.WriteLine(data1);
Console.WriteLine(data2);

var floatPoint = new Point<int>(10, 10);
var stringPoint = new Point<string>("10", "1"); 








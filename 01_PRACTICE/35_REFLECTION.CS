_using System;
using System.Reflection;

class Demo
{
    public void Show(string message) => Console.WriteLine("Message: " + message);
}

class Program
{
    static void Main()
    {
        Type type = typeof(Demo);
        object obj = Activator.CreateInstance(type);

        MethodInfo method = type.GetMethod("Show");
        method.I

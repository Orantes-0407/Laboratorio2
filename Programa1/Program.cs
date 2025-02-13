using System;
using System.Linq.Expressions;
string num1, num2;
int resultado;
Console.WriteLine("ingrese numero1");
num1= Console.ReadLine();
Console.WriteLine("ingrese numero2:");
num2= Console.ReadLine();
Console.Writeline("El resultado de la suma es: " +resultado);
try
{
    resultado = int.Parse(num1) + int.Parse(num2);
    catch(Exception error){
        Console.WriteLine("Ups, ingresa numeros validos");

    }
Console.WriteLine("fin del programa");
  



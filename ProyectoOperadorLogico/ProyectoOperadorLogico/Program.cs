// See https://aka.ms/new-console-template for more information
int num1, num2;
Console.WriteLine("Ingrese un numero");
num1=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese otro numero");
num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("El numero ingresado " + num1 + " es mayor que " + num2);
}
else if (num1 < num2)
{
    Console.WriteLine("El numero ingresado " + num1 + " es menor que " + num2);
}
else
{
    Console.WriteLine("Los numeros son iguales");
}
if (num1 > 0 && num2 > 0)
{
    Console.WriteLine("Ambos numeros ingresados son positivos");
}
else if (num1 < 0 || num2 < 0)
{
    Console.WriteLine("Uno de los numeros es negativo");
}

